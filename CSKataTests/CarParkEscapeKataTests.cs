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
    public class CarParkEscapeKataTests
    {
        [TestMethod]
        public void OneFloorAndParkNextExit()
        {
            int[,] carpark = new int[,] { { 2, 0 } };
            string[] result = new string[] { "R1" };
            ResultShouldBe(carpark, result);
        }

        [TestMethod]
        public void BasicTest1()
        {
            int[,] carpark = new int[,] { { 1, 0, 0, 0, 2 },
                                          { 0, 0, 0, 0, 0 } };
            string[] result = new string[] { "L4", "D1", "R4" };
            ResultShouldBe(carpark, result);
        }

        [TestMethod]
        public void BasicTest2()
        {
            int[,] carpark = new int[,] { { 2, 0, 0, 1, 0 },
                                          { 0, 0, 0, 1, 0 },
                                          { 0, 0, 0, 0, 0 } };
            string[] result = new string[] { "R3", "D2", "R1" };
            ResultShouldBe(carpark, result);
        }

        [TestMethod]
        public void BasicTest3()
        {
            int[,] carpark = new int[,] { { 0, 2, 0, 0, 1 },
                                          { 0, 0, 0, 0, 1 },
                                          { 0, 0, 0, 0, 1 },
                                          { 0, 0, 0, 0, 0 } };
            string[] result = new string[] { "R3", "D3" };
            ResultShouldBe(carpark, result);
        }

        [TestMethod]
        public void BasicTest4()
        {
            int[,] carpark = new int[,] { { 1, 0, 0, 0, 2 },
                                          { 0, 0, 0, 0, 1 },
                                          { 1, 0, 0, 0, 0 },
                                          { 0, 0, 0, 0, 0 } };
            string[] result = new string[] { "L4", "D1", "R4", "D1", "L4", "D1", "R4" };
            ResultShouldBe(carpark, result);
        }

        [TestMethod]
        public void BasicTest5()
        {
            int[,] carpark = new int[,] { { 0, 0, 0, 0, 2 } };
            string[] result = new string[] { };
            ResultShouldBe(carpark, result);
        }



        private void ResultShouldBe(int[,] carpark, string[] expected)
        {
            string[] actual = CarParkEscapeKata.Escape(carpark);
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}