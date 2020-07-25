using System.ComponentModel.DataAnnotations;

namespace InSight.Application.Models.Usuarios
{
    public class UsuarioExclusaoModel
    {
        [Required(ErrorMessage = "Informe o id do usuário.")]
        public string IdUsuario { get; set; }
    }
}
