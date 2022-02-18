using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions1To10
{
    static class InterestisInteresting
    {
        public static float InterestRate(decimal balance)
        {
            if (balance < 0)
            {
                return 3.213f;
            }
            if (balance < 1000)
            {
                return 0.5f;
            }
            if (balance < 5000)
            {
                return 1.621f;
            }

            return 2.475f;
        }
        public static decimal Interest(decimal balance)
        {
            return (decimal)InterestRate(balance) * balance / 100;
        }
        public static decimal AnnualBalanceUpdate(decimal balance)
        {
            return Interest(balance) + balance;
        }
        public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
        {
            int year = 0;
            do
            {
                year++;
                decimal yearlyBalance = AnnualBalanceUpdate(balance) - balance;
                balance += yearlyBalance;
            } while (targetBalance > balance);

            return year;
        }
    }
}
/*
 * Instructions
In this exercise you'll be working with savings accounts. Each year, the balance of your savings account is updated based on its interest rate. 
The interest rate your bank gives you depends on the amount of money in your account (its balance):

3.213% for a negative balance (balance gets more negative).
0.5% for a positive balance less than 1000 dollars.
1.621% for a positive balance greater than or equal to 1000 dollars and less than 5000 dollars.
2.475% for a positive balance greater than or equal to 5000 dollars.
You have four tasks, each of which will deal your balance and its interest rate.

1. Calculate the interest rate
Implement the (static) SavingsAccount.InterestRate() method to calculate the interest rate based on the specified balance:

SavingsAccount.InterestRate(balance: 200.75m)
// 0.5f
Note that the value returned is a float.

2. Calculate the interest
Implement the (static) SavingsAccount.Interest() method to calculate the interest based on the specified balance:

SavingsAccount.Interest(balance: 200.75m)
// 1.00375m
Note that the value returned is a decimal.

3. Calculate the annual balance update
Implement the (static) SavingsAccount.AnnualBalanceUpdate() method to calculate the annual balance update, taking into account the interest rate:

SavingsAccount.AnnualBalanceUpdate(balance: 200.75m)
// 201.75375m
Note that the value returned is a decimal.

4. Calculate the years before reaching the desired balance
Implement the (static) SavingsAccount.YearsBeforeDesiredBalance() method to calculate the minimum number of years required to reach the desired balance given annually compounding interest:

SavingsAccount.YearsBeforeDesiredBalance(balance: 200.75m, targetBalance: 214.88m)
// 14
*/