using InSight.Domain.Aggregates.Bases.Contracts;
using InSight.Domain.Aggregates.Produtos.Contracts;
using InSight.Domain.Aggregates.Produtos.Models;
using System;
using System.Collections.Generic;

namespace InSight.Domain.Aggregates.Produtos.Services
{
    public class ProdutoDomainService : IProdutoDomainService
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoDomainService(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public void Create(Produto obj)
        {
            _produtoRepository.Create(obj);
        }

        public void Update(Produto obj)
        {
            _produtoRepository.Update(obj);

        }

        public void Delete(Produto obj)
        {
            _produtoRepository.Delete(obj);

        }

        public List<Produto> GetAll()
        {
            return _produtoRepository.GetAll();
        }

        public Produto GetById(Guid id)
        {
            return _produtoRepository.GetById(id);
        }
    }
}
