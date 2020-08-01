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

        public void Create(UsuarioCadastroModel model)
        {
            var usuario = mapper.Map<Usuario>(model);
            usuarioDomainService.Create(usuario);
        }

        public void Update(UsuarioEdicaoModel model)
        {
            var usuario = mapper.Map<Usuario>(model);
            usuarioDomainService.Update(usuario);
        }

        public void Delete(UsuarioExclusaoModel model)
        {
            var idUsuario = Guid.Parse(model.IdUsuario);
            var usuario = usuarioDomainService.GetById(idUsuario);

            usuarioDomainService.Delete(usuario);
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

