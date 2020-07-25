using InSight.Application.DTOs;
using InSight.Application.Models.Clientes;
using System.Collections.Generic;

namespace InSight.Application.Contracts
{
    public interface IClienteApplicationServices
    {
        void Create(ClienteCadastroModel model);
        void Update(ClienteEdicaoModel model);
        void Delete(ClienteExclusaoModel model);
        List<ClienteDTO> GetAll();
        ClienteDTO GetById(string id);
    }
}
