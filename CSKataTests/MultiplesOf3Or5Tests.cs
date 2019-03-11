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
    public class MultiplesOf3Or5Tests
    {
        [TestMethod()]
        public void SimpleCase()
        {
            ResultShouldBe(10, 23);
        }

        [TestMethod()]
        public void Zero()
        {
            ResultShouldBe(0, 0);
        }

        [TestMethod()]
        public void HaveCommonMultiple()
        {
            ResultShouldBe(20, 78);
        }

        [TestMethod()]
        public void EdgeSituation()
        {
            ResultShouldBe(22, 119);
        }

        private static void ResultShouldBe(int value, int expected)
        {
            Assert.AreEqual(expected, MultiplesOf3Or5.Solution(value));
        }


    }
}