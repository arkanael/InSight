using InSight.Application.Contracts;
using InSight.Application.Services;
using InSight.Domain.Aggregates.Bases.Contracts;
using InSight.Domain.Aggregates.Fornecedors.Services;
using InSight.Domain.Aggregates.Produtos.Contracts;
using InSight.Domain.Aggregates.Produtos.Services;
using InSight.Domain.Aggregates.Usuarios.Contracts;
using InSight.Domain.Aggregates.Usuarios.Contracts.CrossCutting;
using InSight.Domain.Aggregates.Usuarios.Contracts.Repositories;
using InSight.Domain.Aggregates.Usuarios.Contracts.Services;
using InSight.Domain.Aggregates.Usuarios.Services;
using InSight.Infra.CrossCutting.Criptography;
using InSight.Infra.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Projeto.Presentation.Api.Configurations
{
    public class DependencyInjectionSetup
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            #region Application

            services.AddTransient<ICategoriaApplicationService, CategoriaApplicationService>();
            services.AddTransient<IFornecedorApplicationService, FornecedorApplicationService>();
            services.AddTransient<IPerfilAppicationService, PerfilApplicationService>();
            services.AddTransient<IProdutoApplicationService, ProdutoApplicationService>();
            services.AddTransient<IUsuarioApplicationService, UsuarioApplicationService>();

            #endregion

            #region Domain

            services.AddTransient<ICategoriaDomainService, CategoriaDomainService>();
            services.AddTransient<IFornecedorDomainService, FornecedorDomainService>();
            services.AddTransient<IPerfilDomainService, PerfilDomainService>();
            services.AddTransient<IProdutoDomainService, ProdutoDomainService>();
            services.AddTransient<IUsuarioDomainService, UsuarioDomainService>();

            #endregion

            #region InfraStructure

            services.AddTransient<ICategoriaRepository, CategoriaRepository>();
            services.AddTransient<IFornecedorRepository, FornecedorRepository>();
            services.AddTransient<IPerfilRepository, PerfilRepository>();
            services.AddTransient<IProdutoRepository, ProdutoRepository>();
            services.AddTransient<IUsuarioRepository, UsuarioRepository>();
            services.AddTransient<IMD5Cryptography, MD5Cryptography>();

            #endregion
        }
    }
}