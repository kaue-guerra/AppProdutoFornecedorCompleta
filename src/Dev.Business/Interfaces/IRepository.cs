using Dev.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Dev.Business.Interfaces
{
    public interface IRepository<T> : IDisposable where T : Entity
    {

        Task Create(T entity);
        Task<T> GetById(Guid id);
        Task<List<T>> GetAll();
        Task Delete(Guid id);
        Task Update(T entity);
        Task<IEnumerable<T>> Search(Expression<Func<T, bool>> predicate);
        Task<int> SaveChanges();

    }
}
