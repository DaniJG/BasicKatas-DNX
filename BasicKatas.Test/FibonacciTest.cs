using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace BasicKatas.Test
{    
    public class FibonacciTest
    {
        [Fact]
        public void FibonacciTest_FibonacciZero()
        {
            Assert.Equal(0, Fibonacci.Of(0));
        }

        [Fact]
        public void FibonacciTest_FibonacciOne()
        {
            Assert.Equal(1, Fibonacci.Of(1));
        }

        [Fact]
        public void FibonacciTest_FibonacciTwo()
        {
            Assert.Equal(1, Fibonacci.Of(2));
        }

        [Fact]
        public void FibonacciTest_FibonacciThree()
        {
            Assert.Equal(2, Fibonacci.Of(3));
        }

        [Fact]
        public void FibonacciTest_FibonacciFifty()
        {
            Assert.Equal(12586269025, Fibonacci.Of(50));
        }
    }
}
