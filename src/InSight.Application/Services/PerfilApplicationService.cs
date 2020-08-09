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

        public PerfilDTO Create(PerfilCadastroModel model)
        {
            var perfil = mapper.Map<Perfil>(model);
            PerfilDomainService.Create(perfil);

            return mapper.Map<PerfilDTO>(perfil);
        }

        public PerfilDTO Update(PerfilEdicaoModel model)
        {
            var perfil = mapper.Map<Perfil>(model);
            PerfilDomainService.Update(perfil);

            return mapper.Map<PerfilDTO>(perfil);
        }

        public PerfilDTO Delete(PerfilExclusaoModel model)
        {
            var perfil = mapper.Map<Perfil>(model);
            PerfilDomainService.Delete(perfil);

            return mapper.Map<PerfilDTO>(perfil);
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
