using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEC.Crypto.Entities.ValueObjects
{
    public class Quote
    {
        public BaseSymbol USD { get; set; }
        public BaseSymbol BTC { get; set; }
        public BaseSymbol ETH { get; set; }
        public BaseSymbol BNB { get; set; }
        public BaseSymbol USDT { get; set; }
        public BaseSymbol SOL { get; set; }
        public BaseSymbol ADA { get; set; }
    }
}
