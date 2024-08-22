using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeterReadingApplication
{
    internal sealed class Utilities
    {
        public static ProccessedBillResponse ProccessBill(double meterReadingValue)
        {
            double totalUnitCost = 0;

            switch (meterReadingValue)
            {
                case <= 30:
                    totalUnitCost += meterReadingValue * 6;
                    break;
                case > 30 and <= 60:
                    totalUnitCost += (meterReadingValue - 30) * 9 + (30 * 6);
                    break;
                case > 60 and <= 90:
                    totalUnitCost += (meterReadingValue - 60) * 18 + (60 * 15);
                    break;
                case > 90 and <= 120:
                    totalUnitCost += (meterReadingValue - 90) * 30 + (30 * 18) + (60 * 15);
                    break;
                case > 120 and <= 180:
                    totalUnitCost += (meterReadingValue - 120) * 42 + (30 * 30) + (30 * 18) + (60 * 15);
                    break;
                default:
                    totalUnitCost += (meterReadingValue - 180) * 65 + (60 * 42) + (30 * 30) + (30 * 18) + (60 * 15);
                    break;
            }

            var fixedCost = ChooseTheFixedCost(meterReadingValue);

            ProccessedBillResponse billResponse = new ()
            {
                FixedCost = fixedCost,
                TotalUnitCost = totalUnitCost,
            };
            /*ProccessedBillResponse billResponse1 = billResponse with { FixedCost = 0 };*/

            return billResponse;

        }

        private static double ChooseTheFixedCost(double meterReadingValue) 
        {
            switch (meterReadingValue)
            {
                case <= 30:
                    return 100;
                case > 30 and <= 60:
                    return 250;
                case > 60 and <= 90:
                    return 400;
                case > 90 and <= 120:
                    return 1000;
                case > 120 and <= 180:
                    return 1500;
                default:
                    return 2000;
            }
        }
    }
}
