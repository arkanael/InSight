using InSight.Domain.Aggregates.Bases.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace InSight.Infra.Data.Contracts
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {

        public void Create(TEntity obj)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(TEntity obj)
        {
            throw new NotImplementedException();
        }

        public List<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public TEntity GetById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
