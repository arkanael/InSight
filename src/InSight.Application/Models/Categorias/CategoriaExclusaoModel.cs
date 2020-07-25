using System.ComponentModel.DataAnnotations;

namespace InSight.Application.Models.Categorias
{
    public class CategoriaExclusaoModel
    {
        [Required(ErrorMessage = "Informe o id categoria.")]
        public string Id { get; set; }
    }
}
