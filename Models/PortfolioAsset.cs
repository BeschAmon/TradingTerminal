namespace TradingTerminal.Models
{
    public class PortfolioAsset
    {
        public string Name { get; set; }
        public decimal Available { get; set; }
        public decimal Price { get; set; }
        public decimal Value { get; set; }
        public decimal Profit { get; set; }
        public decimal ProfitPercent { get; set; }
        public bool IsProfit { get; set; }
    }
}