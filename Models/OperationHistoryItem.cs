namespace TradingTerminal.Models;

public class OperationHistoryItem
{
    public DateTime Date { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public decimal Amount { get; set; }
    public bool IsNegative { get; set; }
    public string IconCode { get; set; }
    public string IconColor { get; set; }

    public string FormattedDate => Date.ToString("dd MMMM yyyy");
    public string FormattedAmount => $"{(IsNegative ? "-" : "+")}{Math.Abs(Amount):N2} ₽";
}