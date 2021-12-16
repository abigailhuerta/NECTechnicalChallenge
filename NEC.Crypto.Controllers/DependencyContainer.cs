using Microsoft.Extensions.DependencyInjection;
using NEC.Crypto.Controllers.GetCryptoByConversion;
using NEC.Crypto.Controllers.GetCryptoByLimit;

namespace NEC.Crypto.Controllers
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddNecCryptoControllers(
            this IServiceCollection services)
        {
            services.AddScoped<IGetCryptosByLimitController,
                GetCryptosByLimitController>();
            services.AddScoped<IGetCryptoByConversionController, GetCryptoByConversionController>();

            return services;
        }
    }
}
