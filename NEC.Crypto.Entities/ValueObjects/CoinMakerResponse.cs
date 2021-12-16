using NEC.Crypto.Entities.POCOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEC.Crypto.Entities.ValueObjects
{
    public class CoinMakerResponse
    {
        public List<CrytoCurrency> Data { get; set; }
        public Status Status { get; set; }
    }
}
