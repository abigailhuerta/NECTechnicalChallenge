using Microsoft.AspNetCore.Components;
using NEC.Crypto.DTOs.GetCryptoByConversion;
using NEC.Crypto.ViewModels;
using System.Net.Http.Json;

namespace NEC.Crypto.Blazor.Client.Shared
{
    public partial class Converter : ComponentBase
    {
        [Inject]
        public HttpClient Client { get; set; }

        public CryptoConversionViewModel Conversion;
        public GetCryptoByConversionDTO CryptoDTO = new()
        {
            Amount = 1
        };

        private string Symbol;

        private string ErrorMessage;

        [EditorRequired]
        [Parameter]
        public CryptoViewModel Crypto { get; set; }

        [EditorRequired]
        [Parameter]
        public List<CryptoViewModel> ListCryptos { get; set; }

        [Parameter] 
        public string CryptoConversion { get; set; }

        [Parameter]
        public EventCallback<string> CryptoConversionChanged { get; set; }

        public async void Convert()
        {
            if(Symbol != null)
            {
                CryptoDTO.CryptoSymbolConversion = Symbol;
                CryptoDTO.IdCrypto = Crypto.Id;

                if (CryptoDTO.Amount != 0)
                {
                    var Response = await Client.PostAsJsonAsync("api/CryptoConversion", CryptoDTO);
                    if (Response.IsSuccessStatusCode)
                    {
                        Conversion = await Response.Content.ReadFromJsonAsync<CryptoConversionViewModel>();
                        StateHasChanged();
                    }
                }
            }
            else
            {
                ErrorMessage = "Seleciona una cryptomoneda";
            }

        }

    }
}
