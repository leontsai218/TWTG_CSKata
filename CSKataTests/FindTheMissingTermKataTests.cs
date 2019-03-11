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
    public class FindTheMissingTermKataTests
    {
        [TestMethod()]
        public void SimpleCase_7()
        {
            var result = FindTheMissingTermKata.FindMissing(new List<int> { 1, 3, 5, 9, 11 });
            int expected = 7;
            Assert.AreEqual(7, result);
        }
    }
}