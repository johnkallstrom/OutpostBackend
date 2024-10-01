using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OutpostBackend.Core.Interfaces;
using OutpostBackend.Data.Services;

namespace OutpostBackend.Data
{
    public static class RegisterServices
    {
        public static IServiceCollection AddDataServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<OutpostDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("Default")));
            services.AddScoped(typeof(IGenericService<>), typeof(GenericService<>));

            return services;
        }
    }
}
