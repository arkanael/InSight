using InSight.Application.DTOs;
using InSight.Application.Models.Fornecedores;
using System.Collections.Generic;

namespace InSight.Application.Contracts
{
    public interface IFornecedorApplicationService
    {
        void Create(FornecedorCadastroModel model);
        void Update(FornecedorEdicaoModel model);
        void Delete(FornecedorExclusaoModel model);
        List<FornecedorDTO> GetAll();
        FornecedorDTO GetById(string id);
    }
}
