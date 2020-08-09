using AutoMapper;
using InSight.Application.Contracts;
using InSight.Application.DTOs;
using InSight.Application.Models.Fornecedores;
using InSight.Domain.Aggregates.Bases.Contracts;
using InSight.Domain.Aggregates.Fornecedors.Services;
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

        public FornecedorDTO Create(FornecedorCadastroModel model)
        {
            var fornecedor = mapper.Map<Fornecedor>(model);
            FornecedorDomainService.Create(fornecedor);

            return mapper.Map<FornecedorDTO>(fornecedor);
        }

        public FornecedorDTO Update(FornecedorEdicaoModel model)
        {
            var fornecedor = mapper.Map<Fornecedor>(model);
            FornecedorDomainService.Update(fornecedor);

            return mapper.Map<FornecedorDTO>(fornecedor);
        }

        public FornecedorDTO Delete(FornecedorExclusaoModel model)
        {
            var idFornecedor = Guid.Parse(model.Id);
            var fornecedor = FornecedorDomainService.GetById(idFornecedor);

            FornecedorDomainService.Delete(fornecedor);

            return mapper.Map<FornecedorDTO>(fornecedor);
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
