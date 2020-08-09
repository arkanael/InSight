using InSight.Application.DTOs;
using InSight.Application.Models.Categorias;
using System.Collections.Generic;

namespace InSight.Application.Contracts
{
    public interface ICategoriaApplicationService
    {
        CategoriaDTO Create(CategoriaCadastroModel model);
        CategoriaDTO Update(CategoriaEdicaoModel model);
        CategoriaDTO Delete(CategoriaExclusaoModel model);
        List<CategoriaDTO> GetAll();
        CategoriaDTO GetById(string id);
    }
}
