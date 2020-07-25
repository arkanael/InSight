using InSight.Domain.Aggregates.Bases.Models;
using System;
using System.Collections.Generic;

namespace InSight.Domain.Aggregates.Usuarios.Models
{
    public class Usuario : BaseEnity<Usuario>
    {
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime DataCriacao { get; set; }

        public List<UsuarioPerfil> Perfis { get; set; }

    }
}
