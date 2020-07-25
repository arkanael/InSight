using InSight.Application.DTOs;
using InSight.Application.Models.Categorias;
using System.Collections.Generic;

namespace InSight.Application.Contracts
{
    public interface ICategoriaApplicationServices
    {
        void Create(CategoriaCadastroModel model);
        void Update(CategoriaEdicaoModel model);
        void Delete(CategoriaExclusaoModel model);
        List<CategoriaDTO> GetAll();
        CategoriaDTO GetById(string id);
    }
}
