using System;
using System.Collections.Generic;

namespace MathProject.Algorithms
{
    /// <summary>
    /// Class which contains static Maths methods
    /// </summary>
    public static class Maths
    {
        /// <summary>
        /// Checks if a number is prime by checking for any dividers in the range [2, √number].
        /// </summary>
        /// <param name="number">The number to be checked.</param>
        /// <returns>True if prime, else False.</returns>
        public static bool IsPrime(int number)
        {
            if (number <= 1)
                return false;

            for (int div = 2; div <= Math.Sqrt(number); div++)
            {
                if (number % div == 0)
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>Finds the primes from a range [start, end] and returns them in a list.
        /// </summary>
        /// <param name="start">Top of range</param>
        /// <param name="end">End of range</param>
        /// <returns>A list of all the found primes, if start>=end this method returns null.</returns>
        public static List<int> FindPrimes(int start, int end)
        {
            if (start >= end)
                return (List<int>)null;

          var primes = new List<int>();

          for(int i = start; i<=end; i++)
            {
                if (IsPrime(i))
                {
                    primes.Add(i);
                }
            }

            return primes;
        }
    }
}
