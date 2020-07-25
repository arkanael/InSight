using System;
using System.Collections.Generic;

namespace InSight.Application.DTOs
{
    public class UsuarioDTO
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataCriacao { get; set; }
        public List<PerfilDTO> Perfils { get; set; }
    }
}
