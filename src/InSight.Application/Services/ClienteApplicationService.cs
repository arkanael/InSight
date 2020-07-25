using AutoMapper;
using InSight.Application.Contracts;
using InSight.Application.DTOs;
using InSight.Application.Models.Clientes;
using InSight.Domain.Aggregates.Bases.Contracts;
using InSight.Domain.Aggregates.Clientes.Models;
using System;
using System.Collections.Generic;

namespace InSight.Application.Services
{
    public class ClienteApplicationService : IClienteApplicationServices
    {
        private readonly IClienteDomainService ClienteDomainService;
        private readonly IMapper mapper;
        public ClienteApplicationService(IClienteDomainService ClienteDomainService, IMapper mapper)
        {
            this.ClienteDomainService = ClienteDomainService;
            this.mapper = mapper;
        }

        public void Create(ClienteCadastroModel model)
        {
            ClienteDomainService.Create(mapper.Map<Cliente>(model));
        }

        public void Update(ClienteEdicaoModel model)
        {
            ClienteDomainService.Update(mapper.Map<Cliente>(model));
        }

        public void Delete(ClienteExclusaoModel model)
        {
            ClienteDomainService.Delete(ClienteDomainService.GetById(Guid.Parse(model.Id)));
        }

        public List<ClienteDTO> GetAll()
        {
            return mapper.Map<List<ClienteDTO>>(ClienteDomainService.GetAll());
        }

        public ClienteDTO GetById(string id)
        {
            return mapper.Map<ClienteDTO>(ClienteDomainService.GetById(Guid.Parse(id)));
        }
    }
}