using AutoMapper;
using InSight.Application.Contracts;
using InSight.Application.DTOs;
using InSight.Application.Models.Categorias;
using InSight.Domain.Aggregates.Bases.Contracts;
using InSight.Domain.Aggregates.Produtos.Models;
using System;
using System.Collections.Generic;

namespace InSight.Application.Services
{
    public class CategoriaApplicationService : ICategoriaApplicationServices
    {
        private readonly ICategoriaDomainService categoriaDomainService;
        private readonly IMapper mapper;
        public CategoriaApplicationService(ICategoriaDomainService categoriaDomainService, IMapper mapper)
        {
            this.categoriaDomainService = categoriaDomainService;
            this.mapper = mapper;
        }

        public void Create(CategoriaCadastroModel model)
        {
            categoriaDomainService.Create(mapper.Map<Categoria>(model));
        }

        public void Update(CategoriaEdicaoModel model)
        {
            categoriaDomainService.Update(mapper.Map<Categoria>(model));
        }

        public void Delete(CategoriaExclusaoModel model)
        {
            categoriaDomainService.Delete(categoriaDomainService.GetById(Guid.Parse(model.Id)));
        }

        public List<CategoriaDTO> GetAll()
        {
            return mapper.Map<List<CategoriaDTO>>(categoriaDomainService.GetAll());
        }

        public CategoriaDTO GetById(string id)
        {
            return mapper.Map<CategoriaDTO>(categoriaDomainService.GetById(Guid.Parse(id)));
        }
    }
}
