using InSight.Domain.Aggregates.Bases.Models;
using System.Collections.Generic;

namespace InSight.Domain.Aggregates.Usuarios.Models
{
    public class Perfil : BaseEnity<Perfil>
    {
        public List<UsuarioPerfil> Usuarios { get; set; }
    }
}
