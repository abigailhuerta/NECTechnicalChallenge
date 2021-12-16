using NEC.Crypto.DTOs.GetCryptoByConversion;
using NEC.Crypto.UseCasePorts.GetCryptoByConversion;
using NEC.Crypto.ViewModels;
using NEC.Entities.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEC.Crypto.Controllers.GetCryptoByConversion
{
    public class GetCryptoByConversionController : IGetCryptoByConversionController
    {

        readonly IGetCryptoByConversionInputPort Input;
        readonly IGetCryptoByConversionOutputPort Output;

        public GetCryptoByConversionController(IGetCryptoByConversionInputPort input, IGetCryptoByConversionOutputPort output)
        {
            Input = input;
            Output = output;
        }

        public async ValueTask<CryptoConversionViewModel> GetCryptoByConversion(GetCryptoByConversionDTO dto)
        {
            await Input.Handle(dto);
            return ((IPresenter<CryptoConversionViewModel>)Output).Content;
        }
    }
}
