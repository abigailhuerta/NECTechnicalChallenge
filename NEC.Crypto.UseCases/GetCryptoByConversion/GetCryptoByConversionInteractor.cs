using NEC.Crypto.DTOs.GetCryptoByConversion;
using NEC.Crypto.UseCasePorts.GetCryptoByConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEC.Crypto.UseCases.GetCryptoByConversion
{
    public class GetCryptoByConversionInteractor : IGetCryptoByConversionInputPort
    {
        readonly IGetCryptoByConversionOutputPort OutputPort;
        readonly GetCryptoByConversionService Service;

        public GetCryptoByConversionInteractor(IGetCryptoByConversionOutputPort outputPort, GetCryptoByConversionService service)
        {
            OutputPort = outputPort;
            Service = service;
        }

        public ValueTask Handle(GetCryptoByConversionDTO dto)
        {
            var Result = Service.RunGetCryptoByConversionGuard(dto);
            return OutputPort.Handle(Result);
        }
    }
}
