using FluentAssertions;
using InSight.Api.Tests.Contexts;
using InSight.API.Tests.Response;
using InSight.API.Tests.Utils;
using InSight.Application.Models.Fornecedores;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace Projeto.Api.Tests.TestSteps
{
    [Trait("Fornecedor", "")]

    public class FornecedorTestSteps
    {
        private readonly TestContext testContext;
        private const string resource = "api/Fornecedores";

        public FornecedorTestSteps()
        {
            testContext = new TestContext();
        }

        [Fact]
        public async Task CadastrarFornecedor()
        {
            var model = new FornecedorCadastroModel
            {
                Cnpj = $"{new Random().Next(9999999)}{new Random().Next(9999999)}",
                Nome = "Fornecedor Teste"
            };

            var request = HttpClientUtil.CreateContent(model);
            var response = await testContext.HttpClient.PostAsync(resource, request);

            response.StatusCode.Should().Be(HttpStatusCode.OK);

            var result = JsonConvert.DeserializeObject<FornecedorResponse>
                (HttpClientUtil.GetContent(response));

            result.Message.Should().Be("Fornecedor cadastrado com sucesso.");
            result.fornecedor.Id.Should().NotBeNullOrEmpty();
            result.fornecedor.CNPJ.Should().Be(model.Cnpj);
            result.fornecedor.Nome.Should().Be(model.Nome);
        }

        [Fact(Skip = "Não implementado.")]
        public async Task AtualizarFornecedor()
        {

        }

        [Fact(Skip = "Não implementado.")]
        public async Task ExcluirFornecedor()
        {

        }

        [Fact]
        public async Task ConsultarFornecedores()
        {
            var response = await testContext.HttpClient.GetAsync(resource);
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }

        [Fact(Skip = "Não implementado.")]
        public async Task ObterFornecedorPorId()
        {

        }
    }
}
