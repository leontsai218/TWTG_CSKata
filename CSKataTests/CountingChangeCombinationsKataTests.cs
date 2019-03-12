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
    public class CountingChangeCombinationsKataTests
    {
        [TestMethod()]
        public void NoMoneyAndOneCombination()
        {
            ResultShouldBe(1, new int[] { 2 }, 0);
        }
        

        [TestMethod()]
        public void OnlyOneCombination()
        {
            ResultShouldBe(1, new int[] { 1 }, 1);
        }

        [TestMethod()]
        public void CoinsAreGreaterThanMoneyAndNoCombination()
        {
            ResultShouldBe(1, new int[] { 2 }, 0);
        }

        [TestMethod()]
        public void CoinsAreLessThanMoneyAndNoCombination()
        {
            ResultShouldBe(5, new int[] { 2 }, 0);
        }

        [TestMethod()]
        public void TwoCombination()
        {
            ResultShouldBe(2, new int[] { 1, 2 }, 2);
        }

        [TestMethod()]
        public void SimpleCase()
        {
            ResultShouldBe(4, new[] { 1, 2 }, 3);
        }

        [TestMethod()]
        public void AnotherSimpleCase()
        {
            ResultShouldBe(10, new[] { 5, 2, 3 }, 4);
        }

        [TestMethod()]
        public void NoChange()
        {
            ResultShouldBe(11, new[] { 5, 7 }, 0);
        }

        private void ResultShouldBe(int money, int[] coins, int expected)
        {
            var result = CountingChangeCombinationsKata.CountCombinations(money, coins);
            Assert.AreEqual(expected, result);
        }
    }
}