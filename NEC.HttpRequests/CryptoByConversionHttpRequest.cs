using NEC.Crypto.DTOs.GetCryptoByConversion;
using NEC.Crypto.Entities.ValueObjects;
using NEC.Crypto.UseCases.GetCryptoByConversion;
using NEC.Entities.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace NEC.Crypto.HttpRequests
{
    public class CryptoByConversionHttpRequest : ICryptoByConversionHttpRequest
    {
        readonly string ApiKey;

        public CryptoByConversionHttpRequest(string apiKey)
        {
            ApiKey = apiKey;
        }

        public async Task<CoinMakerConversionResponse> GetCryptoByConversion(GetCryptoByConversionDTO dto)
        {
            CoinMakerConversionResponse Result;
            var HttpClient = new HttpClient();
            HttpClient.BaseAddress = new Uri("https://pro-api.coinmarketcap.com/");
            HttpClient.DefaultRequestHeaders.Add("X-CMC_PRO_API_KEY", ApiKey);
            HttpClient.DefaultRequestHeaders.Add("Accepts", "application/json");
            var Response = await HttpClient.
                GetAsync($"v1/tools/price-conversion?amount={dto.Amount}&id={dto.IdCrypto}&convert={dto.CryptoSymbolConversion}");
            Result = await Response.Content.ReadFromJsonAsync<CoinMakerConversionResponse>();
            if (!Response.IsSuccessStatusCode)
            {
                throw new GeneralException(Result.Status.Error_Message);
            }
            Result.SymbolConversion = dto.CryptoSymbolConversion;
            return Result;
        }
    }
}
