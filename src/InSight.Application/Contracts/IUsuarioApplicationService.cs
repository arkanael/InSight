using InSight.Application.DTOs;
using InSight.Application.Models.Usuarios;
using System.Collections.Generic;

namespace InSight.Application.Contracts
{
    public interface IUsuarioApplicationService
    {
        UsuarioDTO Create(UsuarioCadastroModel model);
        UsuarioDTO Update(UsuarioEdicaoModel model);
        UsuarioDTO Delete(UsuarioExclusaoModel model);
        List<UsuarioDTO> GetAll();
        UsuarioDTO GetById(string id);
    }
}
