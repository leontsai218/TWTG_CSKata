using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSKata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSKata.Tests
{
    [TestClass()]
    public class LargestSumKataTests
    {
        [TestMethod()]
        public void WithoutNumbers()
        {
            var numbers = SetNumbers();
            LargestSumShouldBe(numbers, 0);
        }

        [TestMethod()]
        public void AllNegativeNumbers()
        {
            var numbers = SetNumbers(-1, -2, -3);
            LargestSumShouldBe(numbers, 0);
        }

        [TestMethod()]
        public void AllPositiveNumbers()
        {
            var numbers = SetNumbers(1, 2, 3);
            LargestSumShouldBe(numbers, 6);
        }

        [TestMethod()]
        public void MixNumbers()
        {
            var numbers = SetNumbers(31, -41, 59, 26, -53, 58, 97, -93, -23, 84);
            LargestSumShouldBe(numbers, 187);
        }

        private int[] SetNumbers(params int[] numbers)
        {
            return numbers;
        }

        private void LargestSumShouldBe(int[] numbers, int expected)
        {
            Assert.AreEqual(expected, LargestSumKata.largestSum(numbers));
        }
    }
}