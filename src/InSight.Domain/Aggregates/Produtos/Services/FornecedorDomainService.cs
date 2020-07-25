using InSight.Domain.Aggregates.Bases.Contracts;
using InSight.Domain.Aggregates.Produtos.Contracts;
using InSight.Domain.Aggregates.Produtos.Models;
using System;
using System.Collections.Generic;

namespace InSight.Domain.Aggregates.Fornecedors.Services
{
    public class FornecedorDomainService : IFornecedorDomainService
    {
        private readonly IFornecedorRepository _fornecedorRepository;

        public FornecedorDomainService(IFornecedorRepository fornecedorRepository)
        {
            _fornecedorRepository = fornecedorRepository;
        }

        public void Create(Fornecedor obj)
        {
            _fornecedorRepository.Create(obj);
        }

        public void Update(Fornecedor obj)
        {
            _fornecedorRepository.Update(obj);

        }

        public void Delete(Fornecedor obj)
        {
            _fornecedorRepository.Delete(obj);

        }

        public List<Fornecedor> GetAll()
        {
            return _fornecedorRepository.GetAll();
        }

        public Fornecedor GetById(Guid id)
        {
            return _fornecedorRepository.GetById(id);
        }
    }
}
