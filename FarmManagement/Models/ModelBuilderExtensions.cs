using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FarmManagement.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sapling>().HasData(
                    new Sapling
                    {
                        Id = 1,
                        Name = "Banganapalli Mamidi",
                        CultivarName = "Banganapalli",
                        SpeciesName = Species.Mango,
                        InitialPrice = 155
                    },
                    new Sapling
                    {
                        Id = 2,
                        Name = "Red Jama",
                        CultivarName = "Thai Pink Guava",
                        SpeciesName = Species.Guava,
                        InitialPrice = 203
                    },
                    new Sapling
                    {
                        Id = 3,
                        Name = "Pedha Regayi",
                        CultivarName = "Apple Bear",
                        SpeciesName = Species.Jujube,
                        InitialPrice = 255
                    }
                );
        }
    }
}
