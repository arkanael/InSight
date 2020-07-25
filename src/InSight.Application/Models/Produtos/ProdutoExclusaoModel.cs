using System.ComponentModel.DataAnnotations;

namespace InSight.Application.Models.Produtos
{
    public class ProdutoExclusaoModel
    {
        [Required(ErrorMessage = "Informe o id do produto.")]
        public string Id { get; set; }
    }
}
