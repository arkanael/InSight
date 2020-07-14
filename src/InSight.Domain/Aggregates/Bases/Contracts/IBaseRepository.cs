using System;
using System.Collections.Generic;
using System.Text;

namespace InSight.Domain.Aggregates.Bases.Contracts
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        void Create(TEntity obj);
        void Update(TEntity obj);
        void Delete(TEntity obj);

        List<TEntity> GetAll();
        TEntity GetById(Guid id);
    }
}
