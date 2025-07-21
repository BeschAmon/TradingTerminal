using CommunityToolkit.Mvvm.ComponentModel;
using TradingTerminal.Models;
using System.Collections.ObjectModel;

namespace TradingTerminal.ViewModels;

public partial class OperationHistoryViewModel : ObservableObject
{
    [ObservableProperty]
    private ObservableCollection<OperationHistoryItem> _operations = new();

    public OperationHistoryViewModel()
    {
        LoadSampleData();
    }

    private void LoadSampleData()
    {
        for (int i = 0; i < 11; i++)
        {
            Operations.Add(new OperationHistoryItem
            {
                Date = DateTime.Now.AddDays(-3),
                Title = "Вывод средств",
                Description = "Брокерский счет • 23:32",
                Amount = 8194.86m,
                IsNegative = true,
                IconCode = "💰",
                IconColor = "#FFEBEE"
            });

            Operations.Add(new OperationHistoryItem
            {
                Date = DateTime.Now.AddDays(-5),
                Title = "Покупка акций Сбербанк",
                Description = "10 лотов по 3029.9 ₽ • 15:50",
                Amount = 30299.00m,
                IsNegative = true,
                IconCode = "🏦",
                IconColor = "#E5F6FD"
            });
        }

    }
}