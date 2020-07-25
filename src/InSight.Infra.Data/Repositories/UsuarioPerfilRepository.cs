using InSight.Domain.Aggregates.Usuarios.Contracts.Repositories;
using InSight.Domain.Aggregates.Usuarios.Models;
using InSight.Infra.Data.Contexts;

namespace InSight.Infra.Data.Repositories
{
    public class UsuarioPerfilRepository : BaseRepository<UsuarioPerfil>, IUsuarioPerfilRepository
    {
        private readonly DataContext _dataContext;

        public UsuarioPerfilRepository(DataContext dataContext):base(dataContext)
        {
            _dataContext = dataContext;
        }
    }
}
