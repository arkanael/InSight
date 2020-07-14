using InSight.Domain.Aggregates.Bases.Contracts;
using InSight.Infra.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InSight.Infra.Data.Repositories
{
    public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity>  where TEntity : class
    {
        private readonly DataContext dataContext;

        protected BaseRepository(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public void Create(TEntity obj)
        {
            dataContext.Entry(obj).State = EntityState.Added;
            dataContext.SaveChanges();
        }

        public void Update(TEntity obj)
        {
            dataContext.Entry(obj).State = EntityState.Modified;
            dataContext.SaveChanges();
        }

        public void Delete(TEntity obj)
        {
            dataContext.Entry(obj).State = EntityState.Deleted;
            dataContext.SaveChanges();
        }

        public List<TEntity> GetAll()
        {
            return dataContext.Set<TEntity>().ToList();
        }

        public TEntity GetById(Guid id)
        {
            return dataContext.Set<TEntity>().Find(id);
        }
    }
}
