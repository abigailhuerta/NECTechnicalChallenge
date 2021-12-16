using NEC.Crypto.Entities.ValueObjects;
using NEC.Entities.Interface.Ports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEC.Crypto.UseCasePorts.GetCryptoByConversion
{
    public interface IGetCryptoByConversionOutputPort : IPort<CoinMakerConversionResponse>
    {
    }
}
