using Dev.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dev.Business.Interfaces
{
    public interface IProductRepository : IRepository<Product>
    {
        Task<IEnumerable<Product>> GetProductBySupplier(Guid supplierId);
        Task<IEnumerable<Product>> GetProductsSuppliers();
        Task<Product> GetProductSupplier(Guid id);


    }
}
