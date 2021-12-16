using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEC.Crypto.Entities.ValueObjects
{
    public class BaseSymbol
    {
        public double Price { get; set; }
        public double Volume_24h { get; set; }
        public double Market_Cap { get; set; }
        public DateTime Last_Updated { get; set; }
    }
}
