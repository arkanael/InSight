using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Projeto.Presentation.Api.Configurations
{
    public class AutoMapperSetup
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        }
    }
}
