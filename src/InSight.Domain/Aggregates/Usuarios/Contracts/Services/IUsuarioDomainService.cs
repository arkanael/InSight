using InSight.Domain.Aggregates.Usuarios.Models;

namespace InSight.Domain.Aggregates.Bases.Contracts
{
    public interface IUsuarioDomainService : IBaseDomainService<Usuario>
    {
        Usuario GetByEmailSenha(string email, string senha);
    }
}
