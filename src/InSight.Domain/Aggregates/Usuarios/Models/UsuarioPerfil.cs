using System;

namespace InSight.Domain.Aggregates.Usuarios.Models
{
    public class UsuarioPerfil
    {
        public Guid UsuarioId { get; set; }
        public Guid PerfilId { get; set; }
        public Perfil Perfil { get; set; }
        public Usuario Usuario { get; set; }
    }
}
