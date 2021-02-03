using FarmManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FarmManagement.Models
{
    public class MockSaplingRepository : ISaplingRepository
    {
        private List<Sapling> _saplingList;
        //Constructor of the class to initiate private field
        public MockSaplingRepository()
        {
            _saplingList = new List<Sapling>()
            {
                new Sapling() {Id = 1, Name = "Banganapalli Mamidi", CultivarName = "Banganapalli", SpeciesName = Species.Mango, InitialPrice = 155 },
                new Sapling() {Id = 2, Name = "Red Jama", CultivarName = "Thai Pink Guava", SpeciesName = Species.Guava, InitialPrice = 203 },
                new Sapling() {Id = 3, Name = "Pedha Regayi", CultivarName = "Apple Bear", SpeciesName = Species.Jujube, InitialPrice = 255 },
            };
        }

        public Sapling AddSapling(Sapling sapling)
        {
            sapling.Id = _saplingList.Max(s => s.Id) + 1;
            _saplingList.Add(sapling);
            return sapling;
        }

        public Sapling DeleteSapling(int id)
        {
            Sapling sapling = _saplingList.FirstOrDefault(s => s.Id == id);
            if(sapling != null)
            {
                _saplingList.Remove(sapling);
            }
            return sapling;
        }

        public IEnumerable<Sapling> GetAllSaplings()
        {
            return _saplingList;
        }

        public Sapling GetSapling(int? id)
        {
            return _saplingList.FirstOrDefault(s => s.Id == id);             
        }

        public Sapling UpdateSapling(Sapling saplingChanges)
        {
            Sapling sapling = _saplingList.FirstOrDefault(s => s.Id == saplingChanges.Id);
            if (sapling != null)
            {
                sapling.Name = saplingChanges.Name;
                sapling.CultivarName = saplingChanges.CultivarName;
                sapling.SpeciesName = saplingChanges.SpeciesName;
                sapling.InitialPrice = saplingChanges.InitialPrice;
            }
            return sapling;
        }
    }
}
