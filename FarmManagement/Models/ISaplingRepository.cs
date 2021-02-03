using FarmManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FarmManagement.Models
{
    public interface ISaplingRepository
    {
        Sapling GetSapling(int? id);
        IEnumerable<Sapling> GetAllSaplings();
        Sapling AddSapling(Sapling sapling);
        Sapling UpdateSapling(Sapling saplingChanges);
        Sapling DeleteSapling(int id);
    }
}
