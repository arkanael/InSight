using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace InSight.Api.Tests.Contexts
{
    public class TestContext
    {
        //prop + 2x[tab]
        public HttpClient HttpClient { get; set; }

        //construtor -> ctor + 2x[tab]
        public TestContext()
        {
            //ler o arquivo appsettings.json do projeto Presentation.Api
            var configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json").Build();

            //executando o projeto Presentation.Api (Startup)
            var testServer = new TestServer(
                    new WebHostBuilder()
                    .UseConfiguration(configuration)
                    .UseStartup<InSight.Presentation.API.Startup>()
                );

            //criando o HttpClient (cliente da api)
            HttpClient = testServer.CreateClient();
        }
    }
}

