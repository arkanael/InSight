using InSight.Domain.Aggregates.Bases.Contracts;
using InSight.Domain.Aggregates.Produtos.Contracts;
using InSight.Domain.Aggregates.Produtos.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace InSight.Domain.Aggregates.Produtos.Services
{
    public class CategoriaDomainService : ICategoriaDomainService
    {
        private readonly ICategoriaRepository _categoriaRepository;

        public CategoriaDomainService(ICategoriaRepository categoriaRepository)
        {
            _categoriaRepository = categoriaRepository;
        }

        public void Create(Categoria obj)
        {
            _categoriaRepository.Create(obj);
        }

        public void Update(Categoria obj)
        {
            _categoriaRepository.Update(obj);

        }

        public void Delete(Categoria obj)
        {
            _categoriaRepository.Delete(obj);

        }

        public List<Categoria> GetAll()
        {
            return _categoriaRepository.GetAll();
        }

        public Categoria GetById(Guid id)
        {
            return _categoriaRepository.GetById(id);
        }
    }
}
