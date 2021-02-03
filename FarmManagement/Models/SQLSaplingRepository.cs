using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FarmManagement.Models
{
    public class SQLSaplingRepository : ISaplingRepository
    {
        private readonly AppDbContext _context;
        public SQLSaplingRepository(AppDbContext context)
        {
            _context = context;
        }
        public Sapling AddSapling(Sapling sapling)
        {
            _context.Saplings.Add(sapling);
            _context.SaveChanges();
            return sapling;
        }

        public Sapling DeleteSapling(int id)
        {
            Sapling sapling = _context.Saplings.Find(id);
            if(sapling != null)
            {
                _context.Saplings.Remove(sapling);
                _context.SaveChanges();
            }
            return sapling;
        }

        public IEnumerable<Sapling> GetAllSaplings()
        {
            return _context.Saplings;
        }

        public Sapling GetSapling(int? id)
        {
            return _context.Saplings.Find(id);
        }

        public Sapling UpdateSapling(Sapling saplingChanges)
        {
            var sapling = _context.Saplings.Attach(saplingChanges);
            sapling.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return saplingChanges;
        }
    }
}
