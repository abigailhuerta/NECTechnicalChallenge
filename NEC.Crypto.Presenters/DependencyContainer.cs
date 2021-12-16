using Microsoft.Extensions.DependencyInjection;
using NEC.Crypto.Presenters;
using NEC.Crypto.UseCasePorts.GetCryptoByConversion;
using NEC.Crypto.UseCasePorts.GetCryptoByLimit;

namespace NorthWind.Sales.Presenters
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddPresenters(
            this IServiceCollection services)
        {
            services.AddScoped<IGetCryptoByConversionOutputPort, CryptoConversionPresenter>();
            services.AddScoped<IGetCryptoByLimitOutputPort, CryptosPresenter>();

            return services;
        }
    }
}
