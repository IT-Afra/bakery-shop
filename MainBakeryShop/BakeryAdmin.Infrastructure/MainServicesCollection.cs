using BakeryAdmin.Domain.IRepositories;
using Bakeryshop.Infrastructure.EntityFramework;
using BakeryAdmin.Infrastructure.Mapper;
using BakeryAdmin.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class MainServicesCollection
    {
        public static IServiceCollection AddMainServices(this IServiceCollection services, ConfigurationManager configurationManager)
        {
            services.AddDbContext<BakeryshopContext>(options =>
                options.UseSqlServer(configurationManager.GetConnectionString("BakeryshopConnection")));

            services.AddAutoMapper(typeof(TypeBreadProfile));
            services.AddScoped<ITypeBreadRepository, TypeBreadRepository>();


            services.AddScoped<IAuthenticationRepository, AuthenticationRepository>();

            return services;
        }
    }
}
