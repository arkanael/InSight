using InSight.Domain.Aggregates.Usuarios.Contracts;
using InSight.Domain.Aggregates.Usuarios.Models;
using InSight.Infra.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Text;

namespace InSight.Infra.Data.Repositories
{
    public class UsuarioRepository : BaseRepository<Usuario>, IUsuarioRepository
    {
        private readonly DataContext dataContext;

        public UsuarioRepository(DataContext dataContext):base(dataContext)
        {
            this.dataContext = dataContext;
        }
    }
}
