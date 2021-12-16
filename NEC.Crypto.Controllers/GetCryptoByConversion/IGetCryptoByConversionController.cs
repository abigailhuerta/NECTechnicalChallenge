using NEC.Crypto.DTOs.GetCryptoByConversion;
using NEC.Crypto.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEC.Crypto.Controllers.GetCryptoByConversion
{
    public interface IGetCryptoByConversionController
    {
        ValueTask<CryptoConversionViewModel> GetCryptoByConversion(GetCryptoByConversionDTO dto);
    }
}
