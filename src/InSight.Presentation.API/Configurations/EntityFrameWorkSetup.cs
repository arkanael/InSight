using InSight.Infra.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InSight.Presentation.API.Configurations
{
    public static class EntityFrameWorkSetup
    {
        public static void ConfigurationServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DataContext>(options => options.UseSqlServer(configuration.GetConnectionString("InSight"), b => b.MigrationsAssembly("InSight.Presentation.API")));
        }
    }
}
