namespace MeterReadingApplication;

internal sealed record ProccessedBillResponse
{
    public required double TotalUnitCost { get; init; } 
    public required double FixedCost { get; init; } 
    public double TotalAmount => TotalUnitCost + FixedCost;
}
