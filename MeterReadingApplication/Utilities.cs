using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeterReadingApplication
{
    internal class Utilities
    {
        public static void ProccessBill(double meterReadingValue, ref double totalCost)
        {
            
            var fixedCost = ChooseTheFixedCost(meterReadingValue);


            if (meterReadingValue <= 60)
            {
                if (meterReadingValue > 30)
                {
                    totalCost += (meterReadingValue - 30) * 9 + 30 * 6;
                }
                else
                {
                    totalCost += meterReadingValue * 6;
                }
            }
            else
            {
                if (meterReadingValue > 180)
                {
                    totalCost += ((meterReadingValue - 180) * 65) + (60 * 42) + (30 * 30) + (30*18) + (60*15);
                }
                else if (meterReadingValue > 120 && meterReadingValue <= 180)
                {
                    totalCost += ((meterReadingValue - 120) * 42) + (30 * 30) + (30 * 18) + (60 * 15);
                }
                else if ((meterReadingValue > 90) && (meterReadingValue <= 120))
                {
                    totalCost += ((meterReadingValue - 90) * 30) + (30 * 18) + (60 * 15);
                }
                else
                {
                    totalCost += ((meterReadingValue - 60) * 18) + (60 * 15);
                }
            }

            Console.WriteLine($"Total Unit Charge (Rs.) : {totalCost}");
            Console.WriteLine($"Fixed Charge (Rs.)      : {fixedCost}");
            Console.WriteLine($"Total Bill (Rs.)        : {totalCost + fixedCost}");
            Console.WriteLine();
        }

        public static double ChooseTheFixedCost(double meterReadingValue) 
        {
            if (meterReadingValue <= 30) return 100;
            else if ((meterReadingValue > 30) && (meterReadingValue <= 60)) return 250;
            else if((meterReadingValue > 60) && (meterReadingValue <= 90)) return 400;
            else if ((meterReadingValue > 90) && (meterReadingValue <= 120)) return 1000;
            else if ((meterReadingValue > 120) && (meterReadingValue <= 180)) return 1500;
            else return 2000;
        }
    }
}
