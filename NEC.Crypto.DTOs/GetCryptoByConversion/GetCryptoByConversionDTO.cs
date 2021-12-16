using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEC.Crypto.DTOs.GetCryptoByConversion
{
    public class GetCryptoByConversionDTO
    {
        public int Amount { get; set; }
        public int IdCrypto { get; set; }
        public string CryptoSymbolConversion { get; set; }
    }
}
