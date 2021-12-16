using NEC.Crypto.DTOs.GetCryptoByConversion;
using NEC.Crypto.Entities.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEC.Crypto.UseCases.GetCryptoByConversion
{
    public interface ICryptoByConversionHttpRequest
    {
        Task<CoinMakerConversionResponse> GetCryptoByConversion(GetCryptoByConversionDTO dto);
    }
}
