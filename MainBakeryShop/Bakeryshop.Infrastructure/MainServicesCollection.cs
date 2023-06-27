using Bakeryshop.Domain.IRepositories;
using Bakeryshop.Infrastructure.EntityFramework;
using Bakeryshop.Infrastructure.Mapper;
using Bakeryshop.Infrastructure.Repositories;
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

            services.AddAutoMapper(typeof(OrderProfile));
            services.AddScoped<IOrderRepository, OrderRepository>();

            services.AddAutoMapper(typeof(SchaduleProfile));
            services.AddScoped<ISchaduleRepository, SchaduleRepository>();

            services.AddAutoMapper(typeof(TypeBreadProfile));
            services.AddScoped<ITypeBreadRepository, TypeBreadRepository>();

            services.AddAutoMapper(typeof(UserProfile));

            return services;
        }
    }
}
