using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace BasicKatas.Test
{
    public class PrimeNumbersTest
    {
        [Fact]
        public void PrimeNumbersTest_PrimesOfOne()
        {
            Assert.Equal(new[] { 1 }, PrimeNumbers.Of(1));
        }

        [Fact]
        public void PrimeNumbersTest_PrimesOfTwo()
        {
            Assert.Equal(new[] { 2 }, PrimeNumbers.Of(2));
        }

        [Fact]
        public void PrimeNumbersTest_PrimesOfThree()
        {
            Assert.Equal(new[] { 3 }, PrimeNumbers.Of(3));
        }

        [Fact]
        public void PrimeNumbersTest_PrimesOfFour()
        {
            Assert.Equal(new[] { 2, 2 }, PrimeNumbers.Of(4));
        }

        [Fact]
        public void PrimeNumbersTest_PrimesOfFive()
        {
            Assert.Equal(new[] { 5 }, PrimeNumbers.Of(5));
        }

        [Fact]
        public void PrimeNumbersTest_PrimesOfSix()
        {
            Assert.Equal(new[] { 2, 3 }, PrimeNumbers.Of(6));
        }

        [Fact]
        public void PrimeNumbersTest_PrimesOfSeven()
        {
            Assert.Equal(new[] { 7 }, PrimeNumbers.Of(7));
        }

        [Fact]
        public void PrimeNumbersTest_PrimesOfNine()
        {
            Assert.Equal(new[] { 3, 3 }, PrimeNumbers.Of(9));
        }

        [Fact]
        public void PrimeNumbersTest_PrimesOfTwenty()
        {
            Assert.Equal(new[] { 2, 2, 5 }, PrimeNumbers.Of(20));
        }

        [Fact]
        public void PrimeNumbersTest_PrimesOfBigNumbers()
        {
            Assert.Equal(new[] { 2, 2, 3, 3, 13 }, PrimeNumbers.Of(468));
            Assert.Equal(new[] { 367, 178469 }, PrimeNumbers.Of(65498123));
            
        }
    }
}
