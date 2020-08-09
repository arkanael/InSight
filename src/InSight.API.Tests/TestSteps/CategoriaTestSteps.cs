using FluentAssertions;
using InSight.Api.Tests.Contexts;
using InSight.API.Tests.Response;
using InSight.API.Tests.Utils;
using InSight.Application.DTOs;
using InSight.Application.Models.Categorias;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace Projeto.Api.Tests.TestSteps
{
    [Trait("Categoria", "")]
    public class CategoriaTestSteps
    {
        private readonly TestContext testContext;
        private const string resource = "api/Categorias";

        public CategoriaTestSteps()
        {
            testContext = new TestContext();
        }

        [Trait("Categoria","")]
        [Fact(DisplayName = "Cadastrar nova categoria.")]
        public async Task CadastrarCategoria()
        {
            var model = new CategoriaCadastroModel
            {
                Nome = $"Categoria {Guid.NewGuid()}"
            };

            var request = HttpClientUtil.CreateContent(model);
            var response = await testContext.HttpClient.PostAsync(resource, request);

            response.StatusCode.Should().Be(HttpStatusCode.OK);

            var result = JsonConvert.DeserializeObject<CategoriaResponse>
                (HttpClientUtil.GetContent(response));

            result.Message.Should().Be("Categoria cadastrado com sucesso.");
            result.categoria.Id.Should().NotBeNullOrEmpty();
            result.categoria.Nome.Should().Be(model.Nome);
        }

        [Trait("Categoria", "")]
        [Fact(DisplayName = "Atualizar categoria.")]
        public async Task AtualizarCategoria()
        {
            //1) cadastrando uma categoria
            var modelCadastro = new CategoriaCadastroModel
            {
                Nome = $"Categoria teste {Guid.NewGuid()}"
            };

            var requestCadastro = HttpClientUtil.CreateContent(modelCadastro);
            var responseCadastro = await testContext.HttpClient.PostAsync(resource, requestCadastro);

            var resultCadastro = JsonConvert.DeserializeObject<CategoriaResponse>
                (HttpClientUtil.GetContent(responseCadastro));

            //2) atualizando a categoria cadastrada
            var modelEdicao = new CategoriaEdicaoModel
            {
                Id = resultCadastro.categoria.Id,
                Nome = $"Categoria teste {Guid.NewGuid()}"
            };

            var requestEdicao = HttpClientUtil.CreateContent(modelEdicao);
            var responseEdicao = await testContext.HttpClient.PutAsync(resource, requestEdicao);

            responseEdicao.StatusCode.Should().Be(HttpStatusCode.OK);

            var resultEdicao = JsonConvert.DeserializeObject<CategoriaResponse>
                (HttpClientUtil.GetContent(responseEdicao));

            resultEdicao.Message.Should().Be("Categoria atualizado com sucesso.");
            resultEdicao.categoria.Id.Should().Be(modelEdicao.Id);
            resultEdicao.categoria.Nome.Should().Be(modelEdicao.Nome);
        }

        [Trait("Categoria", "")]
        [Fact(DisplayName = "Excluir nova categoria.")]
        public async Task ExcluirCategoria()
        {
            //1) cadastrando uma categoria
            var modelCadastro = new CategoriaCadastroModel
            {
                Nome = $"Categoria {Guid.NewGuid()}"
            };

            var requestCadastro = HttpClientUtil.CreateContent(modelCadastro);
            var responseCadastro = await testContext.HttpClient.PostAsync(resource, requestCadastro);

            var resultCadastro = JsonConvert.DeserializeObject<CategoriaResponse>
                (HttpClientUtil.GetContent(responseCadastro));

            //2) excluindo a categoria cadastrada        
            var responseExclusao = await testContext.HttpClient
                .DeleteAsync(resource + "/" + resultCadastro.categoria.Id);

            responseExclusao.StatusCode.Should().Be(HttpStatusCode.OK);

            var resultExclusao = JsonConvert.DeserializeObject<CategoriaResponse>
                (HttpClientUtil.GetContent(responseExclusao));

            resultExclusao.Message.Should().Be("Categoria excluído com sucesso.");
            resultExclusao.categoria.Id.Should().Be(resultCadastro.categoria.Id);
            resultExclusao.categoria.Nome.Should().Be(resultCadastro.categoria.Nome);
        }

        [Trait("Categoria", "")]
        [Fact(DisplayName = "Consultar categoria.")]
        public async Task ConsultarCategorias()
        {
            var response = await testContext.HttpClient.GetAsync(resource);
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }

        [Trait("Categoria", "")]
        [Fact(DisplayName = "Consultar categoria por id.")]
        public async Task ObterCategoriaPorId()
        {
            //1) cadastrando uma categoria
            var modelCadastro = new CategoriaCadastroModel
            {
                Nome = $"Categoria {Guid.NewGuid()}"
            };

            var requestCadastro = HttpClientUtil.CreateContent(modelCadastro);
            var responseCadastro = await testContext.HttpClient.PostAsync(resource, requestCadastro);

            var resultCadastro = JsonConvert.DeserializeObject<CategoriaResponse>
                (HttpClientUtil.GetContent(responseCadastro));

            //2) consulta a categoria cadastrada pelo id        
            var responseConsulta = await testContext.HttpClient
                .GetAsync(resource + "/" + resultCadastro.categoria.Id);

            responseConsulta.StatusCode.Should().Be(HttpStatusCode.OK);

            var resultConsulta = JsonConvert.DeserializeObject<CategoriaDTO>
                (HttpClientUtil.GetContent(responseConsulta));

            resultConsulta.Id.Should().Be(resultCadastro.categoria.Id);
            resultConsulta.Nome.Should().Be(resultCadastro.categoria.Nome);
        }
    }
}



