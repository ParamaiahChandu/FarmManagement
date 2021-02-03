using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FarmManagement.Models;
using FarmManagement.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;

namespace FarmManagement.Controllers
{
    //[Route("[Controller]/[action]")]
    public class HomeController : Controller
    {
        private readonly ISaplingRepository _saplingRepository;
        //Constructor Injection
        public HomeController(ISaplingRepository saplingRepository)
        {
            _saplingRepository = saplingRepository;
        }
        //[Route("")]
        //[Route("~/")]
        public ViewResult Index()
        {
            var model = _saplingRepository.GetAllSaplings();
            return View(model);
        }
        //[Route("{id?}")]
        public ViewResult Details(int? id)
        {
            HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel
            {
                Sapling = _saplingRepository.GetSapling(id),
                PageTitle = "Sapling Details"
            };
            return View(homeDetailsViewModel);
        }

        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Create(Sapling sapling)
        {
            if (ModelState.IsValid)
            {
                Sapling newSapling = _saplingRepository.AddSapling(sapling);
                return RedirectToAction("details", new { id = newSapling.Id });
            }
            return View();
        }
    }
}