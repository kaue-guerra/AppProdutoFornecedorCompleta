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
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(AppDbContext context) : base(context){  }
        public async Task<IEnumerable<Product>> GetProductBySupplier(Guid supplierId)
        {
            return await Search(p => p.SupplierId == supplierId);
        }

        public async Task<IEnumerable<Product>> GetProductsSuppliers()
        {
            return await Db.Products.AsNoTracking().Include(s=> s.Supplier).OrderBy(p=> p.Name).ToListAsync();
        }

        public async Task<Product> GetProductSupplier(Guid id)
        {
            return await Db.Products.AsNoTracking().Include(s => s.Supplier).FirstOrDefaultAsync(p => p.Id == id);
        }
    }
}
