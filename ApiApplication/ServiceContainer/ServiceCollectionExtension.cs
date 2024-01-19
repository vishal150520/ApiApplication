using ApiApplication.Services;
using Microsoft.Extensions.Caching.Memory;

namespace ApiApplication.Services
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection RegisterService(this IServiceCollection services)
        {
            services.AddTransient<IUserService,UserService>();
            services.AddHttpClient();
            return services;
        }
    }
}
