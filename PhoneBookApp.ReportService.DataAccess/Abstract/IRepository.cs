using PhoneBookApp.ReportService.DataAccess.Entities.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace PhoneBookApp.ReportService.DataAccess.Abstract
{
    public interface IRepository<TEntity, TContext> where TEntity : class, IEntity, new()
    {
        IQueryable<TEntity> GetAll();
        IQueryable<TEntity> Get(Expression<Func<TEntity, bool>> filter);
        bool Add(TEntity entity);
        bool Remove(TEntity entity);
        bool Update(TEntity entity);
    }
}
