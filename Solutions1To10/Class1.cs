using System;

namespace Solutions1To10
{
    class BirdCount
    {
        private int[] birdsPerDay;
        public BirdCount(int[] birdsPerDay)
        {
            this.birdsPerDay = birdsPerDay;
        }
        public static int[] LastWeek()
        {
            return new int[] { 0, 2, 5, 3, 7, 8, 4 };
        }
        public int Today()
        {
            return birdsPerDay[birdsPerDay.Length - 1];
        }
        public void IncrementTodaysCount()
        {
            birdsPerDay[birdsPerDay.Length - 1]++;
        }
        public bool HasDayWithoutBirds()
        {
            for (int i = 0; i < birdsPerDay.Length; i++)
            {
                if (birdsPerDay[i] == 0)
                {
                    return true;
                }
            }
            return false;
        }
        public int CountForFirstDays(int numberOfDays)
        {
            int sum = 0;
            for (int i = 0; i < numberOfDays; i++)
            {
                sum += birdsPerDay[i];
            }
            return sum;
        }
        public int BusyDays()
        {
            int countBusyDays = 0;
            for (int i = 0; i < birdsPerDay.Length; i++)
            {
                if (birdsPerDay[i] >= 5)
                {
                    countBusyDays++;
                }
            }
            return countBusyDays;
        }
    }
}

/*Instructions - Bird Watcher
You're an avid bird watcher that keeps track of how many birds have visited your garden in the last seven days.
You have six tasks, all dealing with the numbers of birds that visited your garden.

1. Check what the counts were last week
2. Check how many birds visited today
3. Increment today's count
4. Check if there was a day with no visiting birds
5. Calculate the number of visiting birds for the first number of days
6. Calculate the number of busy days
 */
