using InSight.Application.DTOs;
using InSight.Application.Models.Fornecedores;
using System.Collections.Generic;

namespace InSight.Application.Contracts
{
    public interface IFornecedorApplicationService
    {
        FornecedorDTO Create(FornecedorCadastroModel model);
        FornecedorDTO Update(FornecedorEdicaoModel model);
        FornecedorDTO Delete(FornecedorExclusaoModel model);
        List<FornecedorDTO> GetAll();
        FornecedorDTO GetById(string id);
    }
}
