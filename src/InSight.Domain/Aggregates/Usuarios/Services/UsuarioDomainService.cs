using InSight.Domain.Aggregates.Bases.Contracts;
using InSight.Domain.Aggregates.Usuarios.Contracts;
using InSight.Domain.Aggregates.Usuarios.Contracts.CrossCutting;
using InSight.Domain.Aggregates.Usuarios.Contracts.Exceptions;
using InSight.Domain.Aggregates.Usuarios.Models;
using System;
using System.Collections.Generic;

namespace InSight.Domain.Aggregates.Usuarios.Services
{
    public class UsuarioDomainService : IUsuarioDomainService
    {
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IMD5Cryptography _cryptography;
        public UsuarioDomainService(IUsuarioRepository usuarioRepository, IMD5Cryptography cryptography)
        {
            _usuarioRepository = usuarioRepository;
            _cryptography = cryptography;
        }

        public void Create(Usuario obj)
        {
            if (_usuarioRepository.Count(u => u.Email.Equals(obj.Email)) > 0)
                throw new EmaiUnicoException();

            obj.Senha = _cryptography.Encrypt(obj.Senha);

            _usuarioRepository.Create(obj);
        }

        public void Update(Usuario obj)
        {
            obj.Senha = _cryptography.Encrypt(obj.Senha);
            _usuarioRepository.Update(obj);
        }

        public void Delete(Usuario obj)
        {
            _usuarioRepository.Delete(obj);
        }

        public List<Usuario> GetAll()
        {
            return _usuarioRepository.GetAll();
        }

        public Usuario GetById(Guid id)
        {
            return _usuarioRepository.GetById(id);
        }

        public Usuario GetByEmailSenha(string email, string senha)
        {
            senha = _cryptography.Encrypt(senha);
            return _usuarioRepository.Get(u => u.Email.Equals(email) && u.Senha.Equals(senha));
        }
    }
}