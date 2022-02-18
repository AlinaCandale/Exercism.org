using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions1To10
{
    static class CarsAssemble
    {
        public static double SuccessRate(int speed)
        {
            switch (speed)
            {
                case 0: return 0.00;
                case 1:
                case 2:
                case 3:
                case 4: return 1;
                case 5:
                case 6:
                case 7:
                case 8: return 0.9;
                case 9: return 0.8;
                case 10: return 0.77;
                default: return -1;
            }
        }

        public static double ProductionRatePerHour(int speed) => speed * 221 * SuccessRate(speed);

        public static int WorkingItemsPerMinute(int speed) => (int)ProductionRatePerHour(speed) / 60;

    }
}
/*
 * Instructions
In this exercise you'll be writing code to analyze the production of an assembly line in a car factory. The assembly line's speed can range from 0 (off) to 10 (maximum).

At its lowest speed (1), 221 cars are produced each hour. The production increases linearly with the speed. So with the speed set to 4, it should produce 4 * 221 = 884 cars per hour. However, higher speeds increase the likelihood that faulty cars are produced, which then have to be discarded.

You have three tasks.

1. Calculate the success rate
Implement the (static) AssemblyLine.SuccessRate() method to calculate the ratio of an item being created without error for a given speed. The following table shows how speed influences the success rate:

0: 0% success rate.
1 to 4: 100% success rate.
5 to 8: 90% success rate.
9: 80% success rate.
10: 77% success rate.
AssemblyLine.SuccessRate(10)
// => 0.77

2. Calculate the production rate per hour
Implement the (static) AssemblyLine.ProductionRatePerHour() method to calculate the assembly line's production rate per hour, taking into account its success rate:

AssemblyLine.ProductionRatePerHour(6)
// => 1193.4
Note that the value returned is a double.

3. Calculate the number of working items produced per minute
Implement the (static) AssemblyLine.WorkingItemsPerMinute() method to calculate how many working cars are produced per minute:

AssemblyLine.WorkingItemsPerMinute(6)
// => 19
*/
