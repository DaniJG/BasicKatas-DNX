using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicKatas
{
    public class Fibonacci
    {
        private static Dictionary<long, long> CalculatedNumbers = new Dictionary<long, long>();

        public static long Of(long n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            if (CalculatedNumbers.ContainsKey(n)) return CalculatedNumbers[n];

            var fib = Fibonacci.Of(n - 1) + Fibonacci.Of(n - 2);
            CalculatedNumbers[n] = fib;
            return  fib;
        }
    }
}
