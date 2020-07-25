using InSight.Application.DTOs;
using InSight.Application.Models.Usuarios;
using System.Collections.Generic;

namespace InSight.Application.Contracts
{
    public interface IUsuarioApplicationService
    {
        void Create(UsuarioCadastroModel model);
        void Update(UsuarioEdicaoModel model);
        void Delete(UsuarioExclusaoModel model);
        List<UsuarioDTO> GetAll();
        UsuarioDTO GetById(string id);
    }
}
