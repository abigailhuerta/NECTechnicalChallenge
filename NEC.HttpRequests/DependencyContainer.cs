using Microsoft.Extensions.DependencyInjection;
using NEC.Crypto.UseCasePorts.GetCryptoByLimit;
using NEC.Crypto.UseCases.CreateOrder;
using NEC.Crypto.UseCases.GetCryptoByConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEC.Crypto.HttpRequests
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddHttpRequest(
            this IServiceCollection services,string apiKey)
        {
            services.AddScoped<ICryptoByLimitHttpRequest>(C => new CryptoByLimitHttpRequest(apiKey));
            services.AddScoped<ICryptoByConversionHttpRequest>(C => new CryptoByConversionHttpRequest(apiKey));
            return services;
        }
    }
}
