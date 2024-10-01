using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace OutpostBackend.Core
{
    public static class RegisterServices
    {
        public static IServiceCollection AddCoreServices(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            return services;
        }
    }
}
