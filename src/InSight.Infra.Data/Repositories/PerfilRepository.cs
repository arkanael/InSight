using InSight.Domain.Aggregates.Bases.Contracts;
using InSight.Domain.Aggregates.Usuarios.Contracts.Repositories;
using InSight.Domain.Aggregates.Usuarios.Models;
using InSight.Infra.Data.Contexts;

namespace InSight.Infra.Data.Repositories
{
    public class PerfilRepository : BaseRepository<Perfil>, IPerfilRepository
    { 
        private readonly DataContext _dataContext;

        public PerfilRepository(DataContext dataContext):base(dataContext)
        {
            _dataContext = dataContext;
        }
    }
}
