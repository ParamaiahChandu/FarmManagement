using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FarmManagement.Models
{
    public class Sapling
    {
        public int Id { get; set; }
        
        [Required]
        [Display(Name = "Plant Name")]
        public string Name { get; set; }
        
        [Required]
        [Display(Name = "Variety Name")]
        public string CultivarName { get; set; }
        
        [Required]
        [Display(Name = "Plant Type")]
        public Species? SpeciesName { get; set; }
        
        [Required]
        [Display(Name = "Initial Price")]
        [RegularExpression(@"^\+?[1-9]\d*$", ErrorMessage = "Initial Price should be a positive value")]
        public int? InitialPrice { get; set; }

        public string PhotoPath { get; set; }
    }
}
