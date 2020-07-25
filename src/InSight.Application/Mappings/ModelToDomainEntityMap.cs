using AutoMapper;
using InSight.Application.Models.Categorias;
using InSight.Application.Models.Clientes;
using InSight.Application.Models.Fornecedores;
using InSight.Application.Models.Perfils;
using InSight.Application.Models.Produtos;
using InSight.Application.Models.Usuarios;
using InSight.Domain.Aggregates.Clientes.Models;
using InSight.Domain.Aggregates.Produtos.Models;
using InSight.Domain.Aggregates.Usuarios.Models;
using System;

namespace InSight.Application.Mappings
{
    public class ModelToDomainEntityMap : Profile
    {
        public ModelToDomainEntityMap()
        {

            CreateMap<ClienteCadastroModel, Categoria>()
               .AfterMap((src, dest) => {
                   dest.Id = Guid.NewGuid();
               });

            CreateMap<ClienteEdicaoModel, Categoria>()
                .AfterMap((src, dest) => {
                    dest.Id = Guid.Parse(src.Id);
                });

            #region Categorias

            CreateMap<CategoriaCadastroModel, Categoria>()
                .AfterMap((src, dest) => {
                    dest.Id = Guid.NewGuid();
                });

            CreateMap<CategoriaEdicaoModel, Categoria>()
                .AfterMap((src, dest) => {
                    dest.Id = Guid.Parse(src.Id);
                });

            #endregion

            #region Fornecedores

            CreateMap<FornecedorCadastroModel, Fornecedor>()
               .AfterMap((src, dest) => {
                   dest.Id = Guid.NewGuid();
               });

            CreateMap<FornecedorEdicaoModel, Fornecedor>()
                .AfterMap((src, dest) => {
                    dest.Id = Guid.Parse(src.Id);
                });

            #endregion

            #region Perfis

            CreateMap<PerfilCadastroModel, Perfil>()
              .AfterMap((src, dest) => {
                  dest.Id = Guid.NewGuid();
              });

            CreateMap<PerfilEdicaoModel, Perfil>()
                .AfterMap((src, dest) => {
                    dest.Id = Guid.Parse(src.Id);
                });

            #endregion

            #region Produtos

            CreateMap<ProdutoCadastroModel, Produto>()
              .AfterMap((src, dest) => {
                  dest.Id = Guid.NewGuid();
                  dest.Preco = decimal.Parse(src.Preco);
                  dest.Quantidade = int.Parse(src.Quantidade);
                  dest.CategoriaId = Guid.Parse(src.IdCategoria);
                  dest.FornecedorId = Guid.Parse(src.IdFornecedor);
              });

            CreateMap<ProdutoEdicaoModel, Produto>()
                .AfterMap((src, dest) => {
                    dest.Id = Guid.Parse(src.Id);
                    dest.Preco = decimal.Parse(src.Preco);
                    dest.Quantidade = int.Parse(src.Quantidade);
                    dest.CategoriaId = Guid.Parse(src.IdCategoria);
                    dest.FornecedorId = Guid.Parse(src.IdFornecedor);
                });

            #endregion

            #region Usuarios

            CreateMap<UsuarioCadastroModel, Usuario>()
              .AfterMap((src, dest) => {
                  dest.Id = Guid.NewGuid();
                  dest.DataCriacao = DateTime.Now;
              });

            CreateMap<UsuarioEdicaoModel, Usuario>()
              .AfterMap((src, dest) => {
                  dest.Id = Guid.Parse(src.Id);
                  dest.DataCriacao = DateTime.Now;
              });

            #endregion
        }
    }
}
