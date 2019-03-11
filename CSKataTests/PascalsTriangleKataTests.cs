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
    public class PascalsTriangleKataTests
    {
        [TestMethod()]
        public void SimpleCase_Level1()
        {
            ResultShouldBe(1, new int[] { 1 });
        }

        [TestMethod()]
        public void SimpleCase_Level2()
        {
            ResultShouldBe(2, new int[] { 1, 1, 1 });
        }

        [TestMethod()]
        public void SimpleCase_Level3()
        {
            ResultShouldBe(3, new int[] { 1, 1, 1, 1, 2, 1 });
        }

        [TestMethod()]
        public void AdvanceCase_Level5()
        {
            ResultShouldBe(5, new int[] { 1, 1, 1, 1, 2, 1, 1, 3, 3, 1, 1, 4, 6, 4, 1 });
        }

        [TestMethod()]
        public void AdvanceCase_Level6()
        {
            ResultShouldBe(6, new int[] { 1, 1, 1, 1, 2, 1, 1, 3, 3, 1, 1, 4, 6, 4, 1, 1, 5, 10, 10, 5, 1 });
        }

        private void ResultShouldBe(int level, int[] expected)
        {
            CollectionAssert.AreEqual(expected, PascalsTriangleKata.PascalsTriangle(level));
        }
    }
}