using InSight.Application.DTOs;
using InSight.Application.Models.Produtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace InSight.Application.Contracts
{
    public interface  IProdutoApplicationService
    {
        void Create(ProdutoCadastroModel model);
        void Update(ProdutoEdicaoModel model);
        void Delete(ProdutoExclusaoModel model);
        List<ProdutoDTO> GetAll();
        ProdutoDTO GetById(string id);
    }
}
