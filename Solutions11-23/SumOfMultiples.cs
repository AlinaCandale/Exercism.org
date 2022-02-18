using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions11_23
{
    static class SumOfMultiples
    {
        public static int Sum(IEnumerable<int> multiples, int max)
        {
            return Enumerable.Range(0, max)
                .Where(item => multiples.Any(item2 => (item2 != 0) && item % item2 == 0))
                .Sum();
        }
    }
}

/*
 * Instructions
Given a number, find the sum of all the unique multiples of particular numbers up to but not including that number.

If we list all the natural numbers below 20 that are multiples of 3 or 5, we get 3, 5, 6, 9, 10, 12, 15, and 18.

The sum of these multiples is 78.
*/
