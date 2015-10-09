using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicKatas
{
    public class PrimeNumbers
    {
        public static IEnumerable<int> Of(int n)
        {            
            if (n == 1) return new int[] { 1 };

            var primes = new List<int>();
            var prime = 2;
            while (prime <= n)
            {
                if (n % prime == 0)
                {
                    n = n / prime;
                    primes.Add(prime);
                }
                else
                {
                    prime++;
                }
                
            }
            return primes;
        }
    }
}
