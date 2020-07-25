using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace InSight.Domain.Aggregates.Bases.Contracts
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        void Create(TEntity obj);
        void Update(TEntity obj);
        void Delete(TEntity obj);

        List<TEntity> GetAll();
        List<TEntity> GetAll(Expression<Func<TEntity, bool>> where);

        TEntity GetById(Guid id);
        TEntity Get(Expression<Func<TEntity, bool>> where);

        int Count();
        int Count(Expression<Func<TEntity, bool>> where);
    }
}
