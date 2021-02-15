using Microsoft.EntityFrameworkCore;
using PhoneBookApp.PersonService.DataAccess.Abstract;
using PhoneBookApp.PersonService.DataAccess.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace PhoneBookApp.PersonService.DataAccess.Concrete
{
    public class Repository<TEntity, TContext> : IRepository<TEntity, TContext> where TEntity : class, IEntity, new()
        where TContext : DbContext
    {
        private readonly TContext _context;
        private DbSet<TEntity> _dbSet;
        public Repository(TContext context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }
        public bool Add(TEntity entity)
        {
            try { _dbSet.Add(entity); return true; }
            catch { return false; }
        }

        public IQueryable<TEntity> Get(Expression<Func<TEntity, bool>> filter)
        {
            return _dbSet.Where(filter);
        }

        public IQueryable<TEntity> GetAll()
        {
            return _dbSet;
        }

        public bool Remove(TEntity entity)
        {
            try { _dbSet.Update(entity);  return true; }
            catch { return false; }
        }

        public bool Update(TEntity entity)
        {
            try { _dbSet.Update(entity); return true; }
            catch { return false; }
        }
    }
}
