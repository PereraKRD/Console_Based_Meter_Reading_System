using MeterReadingApplication;

Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("         M E T E R   R E A D I N G   S Y S T E M         ");
Console.WriteLine();
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine("(If you want to exit the application, Just hit -1 and Enter)");
Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.WriteLine();

do
{
    Console.WriteLine();
    Console.Write("Please enter the meter reading: ");

    var input = Console.ReadLine();
    bool isValidInput = double.TryParse(input, out double meterReadingValue);

    //Fail Fast
    if (isValidInput is false)
    {
        Console.WriteLine("Please enter a valid value");
        continue;
    }
    if (meterReadingValue >= 0)
    {
        var proccessedBill = Utilities.ProccessBill(meterReadingValue);

        Console.WriteLine($"Total Unit Charge (Rs.) : {proccessedBill.TotalUnitCost}");
        Console.WriteLine($"Fixed Charge (Rs.)      : {proccessedBill.FixedCost}");
        Console.WriteLine($"Total Bill (Rs.)        : {proccessedBill.TotalAmount}");
        Console.WriteLine();

        //Console.WriteLine(proccessedBill.ToString());
    }
    else
    {
        Console.WriteLine("Thank you !!! Have a nice day !!");
        break;
    }
} while (true);