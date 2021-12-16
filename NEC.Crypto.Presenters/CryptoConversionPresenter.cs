using NEC.Crypto.Entities.ValueObjects;
using NEC.Crypto.UseCasePorts.GetCryptoByConversion;
using NEC.Crypto.ViewModels;
using NEC.Entities.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEC.Crypto.Presenters
{
    public class CryptoConversionPresenter : IGetCryptoByConversionOutputPort, IPresenter<CryptoConversionViewModel>
    {
        public CryptoConversionViewModel Content { get; set; }

        public ValueTask Handle(CoinMakerConversionResponse dto)
        {
            switch (dto.SymbolConversion)
            {
                case "BTC":
                    Content = new CryptoConversionViewModel()
                    {
                        LastUpdate = dto.Data.Quote.BTC.Last_Updated,
                        Price = dto.Data.Quote.BTC.Price
                    };
                    break;
                case "ETH":
                    Content = new CryptoConversionViewModel()
                    {
                        LastUpdate = dto.Data.Quote.ETH.Last_Updated,
                        Price = dto.Data.Quote.ETH.Price
                    };
                    break;
                case "BNB":
                    Content = new CryptoConversionViewModel()
                    {
                        LastUpdate = dto.Data.Quote.BNB.Last_Updated,
                        Price = dto.Data.Quote.BNB.Price
                    };
                    break;
                case "USDT":
                    Content = new CryptoConversionViewModel()
                    {
                        LastUpdate = dto.Data.Quote.USDT.Last_Updated,
                        Price = dto.Data.Quote.USDT.Price
                    };
                    break;
                case "SOL":
                    Content = new CryptoConversionViewModel()
                    {
                        LastUpdate = dto.Data.Quote.SOL.Last_Updated,
                        Price = dto.Data.Quote.SOL.Price
                    };
                    break;
                case "ADA":
                    Content = new CryptoConversionViewModel()
                    {
                        LastUpdate = dto.Data.Quote.ADA.Last_Updated,
                        Price = dto.Data.Quote.ADA.Price
                    };
                    break;
            }
            return ValueTask.CompletedTask;
        }
    }
}
