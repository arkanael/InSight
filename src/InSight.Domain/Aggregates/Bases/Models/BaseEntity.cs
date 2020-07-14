using System;

namespace InSight.Domain.Aggregates.Bases.Models
{
    public abstract class BaseEnity<T> where T : BaseEnity<T>
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }

        protected BaseEnity()
        {
            Id = Guid.NewGuid();
        }
    }
}
