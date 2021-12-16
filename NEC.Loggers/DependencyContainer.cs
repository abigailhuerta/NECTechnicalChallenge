using Microsoft.Extensions.DependencyInjection;
using NEC.Entities.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEC.Crypto.Loggers
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddLogger(this IServiceCollection services)
        {
            services.AddScoped<IApplicationStatusLogger, DebugStatusLogger>();
            return services;
        }
    }
}
