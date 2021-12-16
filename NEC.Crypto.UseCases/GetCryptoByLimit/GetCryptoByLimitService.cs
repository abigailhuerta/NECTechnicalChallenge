using NEC.Crypto.Entities.ValueObjects;
using NEC.Entities.Exceptions;
using NEC.Entities.Interface;

namespace NEC.Crypto.UseCases.CreateOrder
{
    public class GetCryptoByLimitService
    {
        readonly ICryptoByLimitHttpRequest CryptoRequest;
        readonly IApplicationStatusLogger StatusLog;

        public GetCryptoByLimitService(ICryptoByLimitHttpRequest cryptoRequest, IApplicationStatusLogger statusLog)
        {
            CryptoRequest = cryptoRequest;
            StatusLog = statusLog;
        }

        public CoinMakerResponse RunGetCryptoByLimitGuard(int limit)
        {
            CoinMakerResponse Result;
            try
            {
                StatusLog.Log("Inicio de peticion");
                Result = CryptoRequest.GetCryptoByLimit(limit).Result;
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
