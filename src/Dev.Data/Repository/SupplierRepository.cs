using Dev.Business.Interfaces;
using Dev.Business.Models;
using Dev.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dev.Data.Repository
{
    public class SupplierRepository : Repository<Supplier>, ISupplierRepository
    {
        public SupplierRepository(AppDbContext context) : base(context) { }
        public async Task<Supplier> GetSupplierAddress(Guid id)
        {
            return await Db.Suppliers.AsNoTracking().Include(a => a.Address).FirstOrDefaultAsync(s=> s.Id == id);
        }

        public async Task<Supplier> GetSupplierProductsAddress(Guid id)
        {
            return await Db.Suppliers.AsNoTracking().Include(p => p.Products).Include(a => a.Address).FirstOrDefaultAsync(s => s.Id == id);
        }
    }
}
