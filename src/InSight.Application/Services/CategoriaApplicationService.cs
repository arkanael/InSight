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
    public class CategoriaApplicationService : ICategoriaApplicationService
    {
        private readonly ICategoriaDomainService categoriaDomainService;
        private readonly IMapper mapper;
        public CategoriaApplicationService(ICategoriaDomainService categoriaDomainService, IMapper mapper)
        {
            this.categoriaDomainService = categoriaDomainService;
            this.mapper = mapper;
        }

        public CategoriaDTO Create(CategoriaCadastroModel model)
        {
            var categoria = mapper.Map<Categoria>(model);
            categoriaDomainService.Create(categoria);

            return mapper.Map<CategoriaDTO>(categoria);
        }

        public CategoriaDTO Update(CategoriaEdicaoModel model)
        {
            var categoria = mapper.Map<Categoria>(model);
            categoriaDomainService.Update(categoria);

            return mapper.Map<CategoriaDTO>(categoria);
        }

        public CategoriaDTO Delete(CategoriaExclusaoModel model)
        {
            var id = Guid.Parse(model.Id);
            var categoria = categoriaDomainService.GetById(id);

            categoriaDomainService.Delete(categoria);

            return mapper.Map<CategoriaDTO>(categoria);
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
