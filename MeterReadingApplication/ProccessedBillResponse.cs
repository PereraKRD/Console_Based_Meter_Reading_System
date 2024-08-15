namespace MeterReadingApplication;

internal sealed record ProccessedBillResponse
{
    public double TotalUnitCost { get; set; } 
    public double FixedCost { get; set; } 
    public double TotalAmount => TotalUnitCost + FixedCost;
}
