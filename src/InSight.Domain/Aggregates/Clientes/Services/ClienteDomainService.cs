using InSight.Domain.Aggregates.Bases.Contracts;
using InSight.Domain.Aggregates.Clientes.Contracts;
using InSight.Domain.Aggregates.Clientes.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace InSight.Domain.Aggregates.Clientes.Services
{
    public class ClienteDomainService : IClienteDomainService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteDomainService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public void Create(Cliente obj)
        {
            _clienteRepository.Create(obj);
        }

        public void Update(Cliente obj)
        {
            _clienteRepository.Update(obj);

        }

        public void Delete(Cliente obj)
        {
            _clienteRepository.Delete(obj);

        }

        public List<Cliente> GetAll()
        {
            return _clienteRepository.GetAll();
        }

        public Cliente GetById(Guid id)
        {
            return _clienteRepository.GetById(id);
        }
    }
}
