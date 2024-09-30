using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace OutpostBackend.Data
{
    public static class RegisterServices
    {
        public static IServiceCollection AddDataServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<OutpostDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("Default")));

            return services;
        }
    }
}
