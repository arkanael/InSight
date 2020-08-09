using AutoMapper;
using InSight.Application.Contracts;
using InSight.Application.DTOs;
using InSight.Application.Models.Usuarios;
using InSight.Domain.Aggregates.Bases.Contracts;
using InSight.Domain.Aggregates.Usuarios.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace InSight.Application.Services
{
    public class UsuarioApplicationService : IUsuarioApplicationService
    {

        private readonly IUsuarioDomainService usuarioDomainService;
        private readonly IMapper mapper;

        public UsuarioApplicationService(IUsuarioDomainService usuarioDomainService, IMapper mapper)
        {
            this.usuarioDomainService = usuarioDomainService;
            this.mapper = mapper;
        }

        public UsuarioDTO Create(UsuarioCadastroModel model)
        {

            var usuario = mapper.Map<Usuario>(model);
            usuarioDomainService.Create(usuario);

            return mapper.Map<UsuarioDTO>(usuario);
        }

        public UsuarioDTO Update(UsuarioEdicaoModel model)
        {
            var usuario = mapper.Map<Usuario>(model);
            usuarioDomainService.Update(usuario);

            return mapper.Map<UsuarioDTO>(usuario);
        }

        public UsuarioDTO Delete(UsuarioExclusaoModel model)
        {
            var usuario = mapper.Map<Usuario>(model);
            usuarioDomainService.Delete(usuario);

            return mapper.Map<UsuarioDTO>(usuario);
        }

        public List<UsuarioDTO> GetAll()
        {
            return mapper.Map<List<UsuarioDTO>>
                (usuarioDomainService.GetAll());
        }

        public UsuarioDTO GetById(string id)
        {
            return mapper.Map<UsuarioDTO>
                (usuarioDomainService.GetById(Guid.Parse(id)));
        }
    }
}

