using Microsoft.Extensions.DependencyInjection;
using NEC.Crypto.UseCasePorts.GetCryptoByConversion;
using NEC.Crypto.UseCasePorts.GetCryptoByLimit;
using NEC.Crypto.UseCases.CreateOrder;
using NEC.Crypto.UseCases.GetCryptoByConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEC.Crypto.UseCases
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddUseCasesServices(
            this IServiceCollection services)
        {
            services.AddScoped<GetCryptoByLimitService>();
            services.AddScoped<IGetCryptoByLimitInputPort, GetCryptoByLimitInteractor>();
            services.AddScoped<GetCryptoByConversionService>();
            services.AddScoped<IGetCryptoByConversionInputPort, GetCryptoByConversionInteractor>();
            return services;
        }
    }
}
