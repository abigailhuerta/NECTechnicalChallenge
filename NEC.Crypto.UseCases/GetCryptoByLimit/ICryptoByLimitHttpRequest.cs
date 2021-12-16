using NEC.Crypto.Entities.ValueObjects;

namespace NEC.Crypto.UseCases.CreateOrder
{
    public interface ICryptoByLimitHttpRequest
    {
        Task<CoinMakerResponse> GetCryptoByLimit(int limit);
    }
}
