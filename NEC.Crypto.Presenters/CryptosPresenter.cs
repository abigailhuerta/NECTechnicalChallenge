using NEC.Crypto.Entities.ValueObjects;
using NEC.Crypto.UseCasePorts.GetCryptoByLimit;
using NEC.Crypto.ViewModels;
using NEC.Entities.Interface;

namespace NorthWind.Sales.Presenters
{
    public class CryptosPresenter :
        IGetCryptoByLimitOutputPort, IPresenter<IEnumerable<CryptoViewModel>>
    {
        public IEnumerable<CryptoViewModel> Content { get; set; }


        public ValueTask Handle(CoinMakerResponse cryptos)
        {
            Content = cryptos.Data.ConvertAll(Cryto => new CryptoViewModel()
            {
                Id = Cryto.Id,
                Symbol = Cryto.Symbol,
                Name  = Cryto.Name,
                TotalSupply = Cryto.Total_Supply,
                LastUpdate = Cryto.Quote.USD.Last_Updated,
                MarketCap = Cryto.Quote.USD.Market_Cap,
                Price = Cryto.Quote.USD.Price,
            });
            return ValueTask.CompletedTask;
        }
    }
}
