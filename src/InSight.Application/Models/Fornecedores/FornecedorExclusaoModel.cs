using System.ComponentModel.DataAnnotations;

namespace InSight.Application.Models.Fornecedores
{
    public class FornecedorExclusaoModel
    {
        [Required(ErrorMessage = "Informe o id do fornecedor.")]
        public string Id { get; set; }
    }
}
