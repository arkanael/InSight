using InSight.Application.DTOs;
using InSight.Application.Models.Clientes;
using System.Collections.Generic;

namespace InSight.Application.Contracts
{
    public interface IClienteApplicationServices
    {
        ClienteDTO Create(ClienteCadastroModel model);
        ClienteDTO Update(ClienteEdicaoModel model);
        ClienteDTO Delete(ClienteExclusaoModel model);
        List<ClienteDTO> GetAll();
        ClienteDTO GetById(string id);
    }
}
