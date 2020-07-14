using InSight.Domain.Aggregates.Produtos.Contracts;
using InSight.Domain.Aggregates.Produtos.Models;
using InSight.Infra.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Text;

namespace InSight.Infra.Data.Repositories
{
    public class ProdutoRepository
       : BaseRepository<Produto>, IProdutoRepository
    {
        private readonly DataContext dataContext;

        public ProdutoRepository(DataContext dataContext)
            : base(dataContext)
        {
            this.dataContext = dataContext;
        }
    }
}
