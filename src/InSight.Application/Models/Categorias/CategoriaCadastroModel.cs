using System.ComponentModel.DataAnnotations;

namespace InSight.Application.Models.Categorias
{
    public class CategoriaCadastroModel
    {

        [MinLength(6, ErrorMessage = "Informe no mínimo {1} caracteres.")]
        [MaxLength(250, ErrorMessage = "Informe no máximo {1} caracteres.")]
        [Required(ErrorMessage = "Informe a descrição da categoria.")]
        public string Nome { get; set; }
    }
}
