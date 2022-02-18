using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions1To10
{
    static class Leap
    {
        public static bool IsLeapYear(int year)
        {
            return year % 4 == 0 ? (year % 100 == 0 && year % 400 != 0 ? false : true) : false;
        }
    }
}
/*
 * Instructions
Given a year, report if it is a leap year.

The tricky thing here is that a leap year in the Gregorian calendar occurs:

on every year that is evenly divisible by 4
  except every year that is evenly divisible by 100
    unless the year is also evenly divisible by 400
For example, 1997 is not a leap year, but 1996 is. 1900 is not a leap year, but 2000 is.
*/
