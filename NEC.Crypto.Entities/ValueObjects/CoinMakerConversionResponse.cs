using NEC.Crypto.Entities.POCOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEC.Crypto.Entities.ValueObjects
{
    public class CoinMakerConversionResponse
    {
        public CrytoCurrency Data { get; set; }
        public Status Status { get; set; }
        public string SymbolConversion { get; set; }
    }
}
