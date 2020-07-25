using AutoMapper;
using InSight.Application.Contracts;
using InSight.Application.DTOs;
using InSight.Application.Models.Perfils;
using InSight.Domain.Aggregates.Usuarios.Contracts.Services;
using InSight.Domain.Aggregates.Usuarios.Models;
using System;
using System.Collections.Generic;

namespace InSight.Application.Services
{
    public class PerfilApplicationService : IPerfilAppicationService
    {
        private readonly IPerfilDomainService PerfilDomainService;
        private readonly IMapper mapper;
        public PerfilApplicationService(IPerfilDomainService PerfilDomainService, IMapper mapper)
        {
            this.PerfilDomainService = PerfilDomainService;
            this.mapper = mapper;
        }

        public void Create(PerfilCadastroModel model)
        {
            PerfilDomainService.Create(mapper.Map<Perfil>(model));
        }

        public void Update(PerfilEdicaoModel model)
        {
            PerfilDomainService.Update(mapper.Map<Perfil>(model));
        }

        public void Delete(PerfilExclusaoModel model)
        {
            PerfilDomainService.Delete(PerfilDomainService.GetById(Guid.Parse(model.Id)));
        }

        public List<PerfilDTO> GetAll()
        {
            return mapper.Map<List<PerfilDTO>>(PerfilDomainService.GetAll());
        }

        public PerfilDTO GetById(string id)
        {
            return mapper.Map<PerfilDTO>(PerfilDomainService.GetById(Guid.Parse(id)));
        }
    }
}
