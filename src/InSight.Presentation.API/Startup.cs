using InSight.Presentation.API.Configurations;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Projeto.Presentation.Api.Configurations;

namespace InSight.Presentation.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }


        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            SwaggerSetup.ConfigureServices(services);

            CorsSetup.ConfigureServices(services);

            EntityFrameWorkSetup.ConfigurationServices(services, Configuration);

            DependencyInjectionSetup.ConfigureServices(services);

            JWTSetup.ConfigureServices(services, Configuration);

            AutoMapperSetup.ConfigureServices(services);

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            SwaggerSetup.Configure(app);
            
            CorsSetup.Configure(app);

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
