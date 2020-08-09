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

        public ProdutoDTO Create(ProdutoCadastroModel model)
        {
            var produto = mapper.Map<Produto>(model);
            ProdutoDomainService.Create(produto);

            return mapper.Map<ProdutoDTO>(produto);
        }

        public ProdutoDTO Update(ProdutoEdicaoModel model)
        {
            var produto = mapper.Map<Produto>(model);
            ProdutoDomainService.Update(produto);

            return mapper.Map<ProdutoDTO>(produto);
        }

        public ProdutoDTO Delete(ProdutoExclusaoModel model)
        {
            var produto = mapper.Map<Produto>(model);
            ProdutoDomainService.Delete(produto);

            return mapper.Map<ProdutoDTO>(produto);
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
