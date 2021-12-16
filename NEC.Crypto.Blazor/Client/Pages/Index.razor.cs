using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using NEC.Crypto.ViewModels;
using System.Net.Http.Json;
using NEC.Crypto.DTOs.GetCryptoByConversion;

namespace NEC.Crypto.Blazor.Client.Pages
{
    public partial class Index : ComponentBase , IDisposable
    {
        public List<CryptoViewModel> Cryptos { get; set; }

        CancellationTokenSource PollingCancellationToken;

        public bool ShowDialog { get; set; }

        public CryptoViewModel DialogCrypto { get; set; }

        private List<CryptoViewModel> CrytoSymbols;

        public string CryptoConversion { get; set; }

        [Inject]
        public HttpClient Client { get; set; }
        protected async override Task OnInitializedAsync()
        {
            PollingCancellationToken?.Cancel();
            try
            {
                CrytoSymbols = await Client.GetFromJsonAsync<List<CryptoViewModel>>("api/cryptos");
            }
            catch(Exception ex)
            {
                Console.Error.WriteLine(ex.Message);
            }
            PoolForUpdates();
        }

        public void ShowConversion(CryptoViewModel dto)
        {
            PollingCancellationToken?.Cancel();
            ShowDialog = true;
            DialogCrypto = dto;            
        }

        private async void PoolForUpdates()
        { 
            PollingCancellationToken = new CancellationTokenSource();
            while (!PollingCancellationToken.IsCancellationRequested)
            {
                try
                {
                    Cryptos = await Client.GetFromJsonAsync<List<CryptoViewModel>>("api/cryptos");
                    this.StateHasChanged();
                    await Task.Delay(5000);

                }
                catch (Exception ex)
                {
                    PollingCancellationToken.Cancel();
                    Console.Error.WriteLine(ex.Message);
                    StateHasChanged();
                }
            }

        }

        public void Dispose()
        {
            PollingCancellationToken?.Cancel();
        }
    }
}
