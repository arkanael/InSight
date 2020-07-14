using InSight.Domain.Aggregates.Bases.Models;
using System;

namespace InSight.Domain.Aggregates.Produtos.Models
{
    public class Produto : BaseEnity<Produto>
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }

        public Guid FornecedorId { get; set; }
        public Guid CategoriaId { get; set; }

        public Fornecedor Fornecedor { get; set; }
        public Categoria Categoria { get; set; }
    }
}
