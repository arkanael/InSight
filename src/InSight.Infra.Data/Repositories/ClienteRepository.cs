using InSight.Domain.Aggregates.Clientes.Contracts;
using InSight.Domain.Aggregates.Clientes.Models;
using InSight.Infra.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Text;

namespace InSight.Infra.Data.Repositories
{
    public class ClienteRepository : BaseRepository<Cliente>, IClienteRepository
    {
        private readonly DataContext dataContext;

        public ClienteRepository(DataContext dataContext):base(dataContext)
        {
            this.dataContext = dataContext;
        }
    }
}
