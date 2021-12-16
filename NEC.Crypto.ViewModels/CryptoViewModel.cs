namespace NEC.Crypto.ViewModels
{
    public class CryptoViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }
        public DateTime LastUpdate { get; set; }
        public double TotalSupply { get; set; }
        public double Price { get; set; }
        public double MarketCap { get; set; }
    }
}