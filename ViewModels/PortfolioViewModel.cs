using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using TradingTerminal.Models;

namespace TradingTerminal.ViewModels
{
    public partial class PortfolioViewModel : ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<PortfolioAsset> _assets = new();

        public PortfolioViewModel()
        {
            LoadSampleData();
        }

        private void LoadSampleData()
        {
            Assets.Add(new PortfolioAsset
            {
                Name = "Российский рубль",
                Available = 10000,
                Price = 1,
                Value = 10000,
                Profit = 0,
                ProfitPercent = 0,
                IsProfit = false
            });

            Assets.Add(new PortfolioAsset
            {
                Name = "Сбер Банк",
                Available = 20,
                Price = 311.01m,
                Value = 6220.20m,
                Profit = 160.40m,
                ProfitPercent = 2.65m,
                IsProfit = true
            });

            Assets.Add(new PortfolioAsset
            {
                Name = "Газпром",
                Available = 15,
                Price = 165.50m,
                Value = 2482.50m,
                Profit = -120.75m,
                ProfitPercent = -4.63m,
                IsProfit = false
            });
        }
    }
}