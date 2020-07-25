using System.ComponentModel.DataAnnotations;

namespace InSight.Application.Models.Clientes
{
    public class ClienteExclusaoModel
    {
        [Required(ErrorMessage = "Informe o id do cliente.")]
        public string Id { get; set; }
    }
}
