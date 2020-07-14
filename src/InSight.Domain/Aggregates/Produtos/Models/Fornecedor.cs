using InSight.Domain.Aggregates.Bases.Models;
using System.Collections.Generic;

namespace InSight.Domain.Aggregates.Produtos.Models
{
    public class Fornecedor : BaseEnity<Fornecedor>
    {
        public string Nome { get; set; }
        public string Cnpj { get; set; }
        public List<Produto> Produtos { get; set; }

    }
}
