using NEC.Crypto.Entities.ValueObjects;
using NEC.Crypto.UseCases.CreateOrder;
using NEC.Entities.Exceptions;
using System.Net.Http.Json;

namespace NEC.Crypto.HttpRequests
{
    public class CryptoByLimitHttpRequest : ICryptoByLimitHttpRequest
    {
        readonly string ApiKey;
        public CryptoByLimitHttpRequest(string apiKey)
        {
            ApiKey = apiKey;
        }

        public async Task<CoinMakerResponse> GetCryptoByLimit(int limit)
        {
            CoinMakerResponse Result;
            var HttpClient = new HttpClient();
            HttpClient.BaseAddress = new Uri("https://pro-api.coinmarketcap.com/");
            HttpClient.DefaultRequestHeaders.Add("X-CMC_PRO_API_KEY", ApiKey);
            HttpClient.DefaultRequestHeaders.Add("Accepts", "application/json");
            var Response = await HttpClient.GetAsync($"v1/cryptocurrency/listings/latest?limit={limit}");
            Result = await Response.Content.ReadFromJsonAsync<CoinMakerResponse>();
            if (!Response.IsSuccessStatusCode)
            {
                throw new GeneralException(Result.Status.Error_Message);
            }
            return Result;
        }
    }
}
