using InSight.Application.DTOs;
using InSight.Application.Models.Produtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace InSight.Application.Contracts
{
    public interface  IProdutoApplicationService
    {
        ProdutoDTO Create(ProdutoCadastroModel model);
        ProdutoDTO Update(ProdutoEdicaoModel model);
        ProdutoDTO Delete(ProdutoExclusaoModel model);
        List<ProdutoDTO> GetAll();
        ProdutoDTO GetById(string id);
    }
}
