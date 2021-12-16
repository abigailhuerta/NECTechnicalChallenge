using NEC.Crypto.ViewModels;

namespace NEC.Crypto.Controllers.GetCryptoByLimit
{
    public interface IGetCryptosByLimitController
    {
        ValueTask<IEnumerable<CryptoViewModel>> GetCryptoByLimit(int limit);
    }
}
