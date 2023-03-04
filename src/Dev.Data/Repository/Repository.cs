using Dev.Business.Interfaces;
using Dev.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Dev.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Dev.Data.Repository
{
    public abstract class Repository<T> : IRepository<T> where T : Entity , new()
    {
        protected readonly AppDbContext Db;
        protected readonly DbSet<T> DbSet;

        protected Repository(AppDbContext db)
        {
            Db = db;
            DbSet = db.Set<T>();
        }

        public virtual async Task Create(T entity)
        {
            DbSet.Add(entity);
            await SaveChanges();
        }
        public virtual async Task Update(T entity)
        {
            DbSet.Update(entity);
            await SaveChanges();
        }

        public virtual async Task Delete(Guid id)
        {
            DbSet.Remove(new T { Id = id });
            await SaveChanges();
        }

        public virtual async Task<List<T>> GetAll()
        {
            return await DbSet.ToListAsync();
        }

        public virtual async Task<T> GetById(Guid id)
        {
            return await DbSet.FindAsync(id);
        }

        public async Task<IEnumerable<T>> Search(Expression<Func<T, bool>> predicate)
        {
            return await DbSet.AsNoTracking().Where(predicate).ToListAsync();
        }

      
        public async Task<int> SaveChanges()
        {
           return await Db.SaveChangesAsync();
        }

        public void Dispose()
        {
            Db?.Dispose();
        }

    }
}
