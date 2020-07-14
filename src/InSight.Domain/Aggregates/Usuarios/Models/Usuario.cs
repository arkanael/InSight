using InSight.Domain.Aggregates.Bases.Models;

namespace InSight.Domain.Aggregates.Usuarios.Models
{
    public class Usuario : BaseEnity<Usuario>
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public string Senha { get; set; }
    }
}
