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
    public class SortTheOddKataTests
    {
        [TestMethod()]
        public void EmptyArray()
        {
            var array = new int[0];
            var expected = array;
            SortedResultShouldBe(array, expected);
        }

        

        [TestMethod()]
        public void AllOddArray()
        {
            var array = new int[] { 5, 9, 7, 1 };
            var expected = new int[] { 1, 5, 7, 9 };
            SortedResultShouldBe(array, expected);
        }

        [TestMethod()]
        public void AllEvenArray()
        {
            var array = new int[] { 6, 4, 2, 8 };
            var expected = new int[] { 6, 4, 2, 8 };
            SortedResultShouldBe(array, expected);
        }

        [TestMethod()]
        public void NormalArray()
        {
            var array = new int[] { 5, 3, 2, 8, 1, 4 };
            var expected = new int[] { 1, 3, 2, 8, 5, 4 };
            SortedResultShouldBe(array, expected);
        }

        [TestMethod()]
        public void NormalArray02()
        {
            var array = new int[] { 5, 3, 1, 8, 0 };
            var expected = new int[] { 1, 3, 5, 8, 0 };
            SortedResultShouldBe(array, expected);
        }

        private void SortedResultShouldBe(int[] array, int[] expected)
        {
            CollectionAssert.AreEqual(expected, SortTheOddKata.SortArray(array));
        }
    }
}