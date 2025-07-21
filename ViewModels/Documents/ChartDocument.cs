using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace TradingTerminal.ViewModels.Documents
{
    public partial class ChartDocument : ObservableObject
    {
        [RelayCommand]
        public Task Test()
        {
            Console.WriteLine("Test");
            return Task.CompletedTask;
        }
    }
}
