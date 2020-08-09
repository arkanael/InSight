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

        public ClienteDTO Create(ClienteCadastroModel model)
        {
            var cliente = mapper.Map<Cliente>(model);
            ClienteDomainService.Create(cliente);

            return mapper.Map<ClienteDTO>(cliente);
        }

        public ClienteDTO Update(ClienteEdicaoModel model)
        {
            var cliente = mapper.Map<Cliente>(model);
            ClienteDomainService.Update(cliente);

            return mapper.Map<ClienteDTO>(cliente);
        }

        public ClienteDTO Delete(ClienteExclusaoModel model)
        {
            var cliente = mapper.Map<Cliente>(model);
            ClienteDomainService.Delete(cliente);

            return mapper.Map<ClienteDTO>(cliente);
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