using NEC.Crypto.UseCasePorts.GetCryptoByLimit;
using NEC.Crypto.ViewModels;
using NEC.Entities.Interface;

namespace NEC.Crypto.Controllers.GetCryptoByLimit
{
    public class GetCryptosByLimitController : IGetCryptosByLimitController
    {
        readonly IGetCryptoByLimitInputPort Input;
        readonly IGetCryptoByLimitOutputPort Output;

        public GetCryptosByLimitController(IGetCryptoByLimitInputPort input, IGetCryptoByLimitOutputPort output)
        {
            Input = input;
            Output = output;
        }

        public async ValueTask<IEnumerable<CryptoViewModel>> GetCryptoByLimit(int limit)
        {
            await Input.Handle(limit);
            return ((IPresenter<IEnumerable<CryptoViewModel>>)Output).Content;
        }
    }
}
