using AutoMapper;
using InSight.Application.Contracts;
using InSight.Application.DTOs;
using InSight.Application.Models.Fornecedores;
using InSight.Domain.Aggregates.Bases.Contracts;
using InSight.Domain.Aggregates.Produtos.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace InSight.Application.Services
{
    public class FornecedorApplicationService : IFornecedorApplicationService
    {
        private readonly IFornecedorDomainService FornecedorDomainService;
        private readonly IMapper mapper;
        public FornecedorApplicationService(IFornecedorDomainService FornecedorDomainService, IMapper mapper)
        {
            this.FornecedorDomainService = FornecedorDomainService;
            this.mapper = mapper;
        }

        public void Create(FornecedorCadastroModel model)
        {
            FornecedorDomainService.Create(mapper.Map<Fornecedor>(model));
        }

        public void Update(FornecedorEdicaoModel model)
        {
            FornecedorDomainService.Update(mapper.Map<Fornecedor>(model));
        }

        public void Delete(FornecedorExclusaoModel model)
        {
            FornecedorDomainService.Delete(FornecedorDomainService.GetById(Guid.Parse(model.Id)));
        }

        public List<FornecedorDTO> GetAll()
        {
            return mapper.Map<List<FornecedorDTO>>(FornecedorDomainService.GetAll());
        }

        public FornecedorDTO GetById(string id)
        {
            return mapper.Map<FornecedorDTO>(FornecedorDomainService.GetById(Guid.Parse(id)));
        }
    }
}
