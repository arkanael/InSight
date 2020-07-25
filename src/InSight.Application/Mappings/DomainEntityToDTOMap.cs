using AutoMapper;
using InSight.Application.DTOs;
using InSight.Domain.Aggregates.Clientes.Models;
using InSight.Domain.Aggregates.Produtos.Models;
using InSight.Domain.Aggregates.Usuarios.Models;

namespace InSight.Application.Mappings
{
    public class DomainEntityToDTOMap : Profile
    {
        public DomainEntityToDTOMap()
        {
            CreateMap<Categoria, CategoriaDTO>()
              .AfterMap((src, dest) =>
              {
                  dest.Id = src.Id.ToString();
              });

            CreateMap<Cliente, ClienteDTO>()
                .AfterMap((src, dest) =>
                {
                    dest.Id = src.Id.ToString();
                });

            CreateMap<Fornecedor, FornecedorDTO>()
              .AfterMap((src, dest) =>
              {
                  dest.Id = src.Id.ToString();
              });


            CreateMap<Perfil, PerfilDTO>()
              .AfterMap((src, dest) =>
              {
                  dest.Id = src.Id.ToString();
              });

            CreateMap<Produto, ProdutoDTO>()
             .AfterMap((src, dest) =>
             {
                 dest.Id = src.Id.ToString();
                 dest.Total = (src.Preco * src.Quantidade);
             });

            CreateMap<Usuario, UsuarioDTO>()
             .AfterMap((src, dest) =>
             {
                 dest.Id = src.Id.ToString();
             });

        }
    }
}
