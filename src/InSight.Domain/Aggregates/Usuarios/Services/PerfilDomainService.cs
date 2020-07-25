using InSight.Domain.Aggregates.Usuarios.Contracts.Repositories;
using InSight.Domain.Aggregates.Usuarios.Contracts.Services;
using InSight.Domain.Aggregates.Usuarios.Exceptions;
using InSight.Domain.Aggregates.Usuarios.Models;
using System;
using System.Collections.Generic;

namespace InSight.Domain.Aggregates.Usuarios.Services
{
    public class PerfilDomainService : IPerfilDomainService
    {
        private readonly IPerfilRepository _perfilRepository;

        public PerfilDomainService(IPerfilRepository perfilRepository)
        {
            _perfilRepository = perfilRepository;
        }

        public void Create(Perfil obj)
        {
            if(_perfilRepository.Count(p => p.Nome.Equals(obj.Nome)) > 0)
                throw new PerfilUnicoException();

            _perfilRepository.Create(obj);
        }

        public void Update(Perfil obj)
        {
            _perfilRepository.Update(obj);
        }

        public void Delete(Perfil obj)
        {
            _perfilRepository.Delete(obj);
        }

        public List<Perfil> GetAll()
        {
            return _perfilRepository.GetAll();
        }

        public Perfil GetById(Guid id)
        {
            return _perfilRepository.GetById(id);
        }
    }
}
