using NEC.Crypto.UseCasePorts.GetCryptoByLimit;

namespace NEC.Crypto.UseCases.CreateOrder
{
    public class GetCryptoByLimitInteractor : IGetCryptoByLimitInputPort
    {
        readonly IGetCryptoByLimitOutputPort OutputPort;
        readonly GetCryptoByLimitService Service;

        public GetCryptoByLimitInteractor(IGetCryptoByLimitOutputPort outputPort, GetCryptoByLimitService service)
        {
            OutputPort = outputPort;
            Service = service;
        }

        public ValueTask Handle(int limit)
        {
            var Result = Service.RunGetCryptoByLimitGuard(limit);
            return OutputPort.Handle(Result);

        }
    }
}
