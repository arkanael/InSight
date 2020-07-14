using InSight.Domain.Aggregates.Bases.Models;
using System.Collections.Generic;

namespace InSight.Domain.Aggregates.Produtos.Models
{
    public class Categoria : BaseEnity<Categoria>
    {
        public List<Produto> Produtos { get; set; }
    }
}