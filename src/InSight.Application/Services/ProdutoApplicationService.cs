using AutoMapper;
using InSight.Application.Contracts;
using InSight.Application.DTOs;
using InSight.Application.Models.Produtos;
using InSight.Domain.Aggregates.Bases.Contracts;
using InSight.Domain.Aggregates.Produtos.Models;
using InSight.Domain.Aggregates.Usuarios.Contracts.Services;
using InSight.Domain.Aggregates.Usuarios.Models;
using System;
using System.Collections.Generic;

namespace InSight.Application.Services
{
    public class ProdutoApplicationService : IProdutoApplicationService
    {
        private readonly IProdutoDomainService ProdutoDomainService;
        private readonly IMapper mapper;
        public ProdutoApplicationService(IProdutoDomainService ProdutoDomainService, IMapper mapper)
        {
            this.ProdutoDomainService = ProdutoDomainService;
            this.mapper = mapper;
        }

        public void Create(ProdutoCadastroModel model)
        {
            ProdutoDomainService.Create(mapper.Map<Produto>(model));
        }

        public void Update(ProdutoEdicaoModel model)
        {
            ProdutoDomainService.Update(mapper.Map<Produto>(model));
        }

        public void Delete(ProdutoExclusaoModel model)
        {
            ProdutoDomainService.Delete(ProdutoDomainService.GetById(Guid.Parse(model.Id)));
        }

        public List<ProdutoDTO> GetAll()
        {
            return mapper.Map<List<ProdutoDTO>>(ProdutoDomainService.GetAll());
        }

        public ProdutoDTO GetById(string id)
        {
            return mapper.Map<ProdutoDTO>(ProdutoDomainService.GetById(Guid.Parse(id)));
        }
    }
}
