using NEC.Crypto.DTOs.GetCryptoByConversion;
using NEC.Crypto.Entities.ValueObjects;
using NEC.Entities.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEC.Crypto.UseCases.GetCryptoByConversion
{
    public class GetCryptoByConversionService
    {
        readonly ICryptoByConversionHttpRequest CryptoRequest;
        readonly IApplicationStatusLogger StatusLog;

        public GetCryptoByConversionService(ICryptoByConversionHttpRequest cryptoRequest, IApplicationStatusLogger statusLog)
        {
            CryptoRequest = cryptoRequest;
            StatusLog = statusLog;
        }

        public CoinMakerConversionResponse RunGetCryptoByConversionGuard(GetCryptoByConversionDTO dTO)
        {
            CoinMakerConversionResponse Result;
            try
            {
                StatusLog.Log("Inicio de peticion");
                Result = CryptoRequest.GetCryptoByConversion(dTO).Result;
                StatusLog.Log($"Fin de la peticion");
            }
            catch
            {
                StatusLog.Log("Error con la peticion");
                throw;
            }
            return Result;
        }

    }
}
