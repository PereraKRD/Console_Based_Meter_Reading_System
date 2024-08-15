using MeterReadingApplication;

Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("         M E T E R   R E A D I N G   S Y S T E M         ");
Console.WriteLine();
Console.WriteLine();


bool running = true;

while (running)
{
    Console.WriteLine();
    Console.Write("Please enter the meter reading: ");

    double meterReadingValue;
    double totalCost = 0;
    bool res = double.TryParse(Console.ReadLine(), out meterReadingValue);

    if (res)
    {
        if (meterReadingValue < 0)
        {
            Console.WriteLine("Thank you !!! Have a nice day !!");
            running = false;
        }
        else
        {
            Utilities.ProccessBill(meterReadingValue,ref totalCost);
        }
    }
    else
    {
        Console.WriteLine("Please enter a valid value");
    }
}