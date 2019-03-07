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
    public class AnagramDetectionKataTests
    {
        [TestMethod()]
        public void OneLetterAndSameCase()
        {
            CompareResultShouldBe("A", "A", true);
        }

        [TestMethod()]
        public void OneLetterAndDiffentCase()
        {
            CompareResultShouldBe("a", "A", true);
        }

        [TestMethod()]
        public void SameWord()
        {
            CompareResultShouldBe("coffee", "coffee", true);
        }

        [TestMethod()]
        public void SameLettersSameCount()
        {
            CompareResultShouldBe("toffee", "foefet", true);
        }

        [TestMethod()]
        public void SameLettersDifferentCount()
        {
            CompareResultShouldBe("apple", "pale", false);
        }

        private void CompareResultShouldBe(string original, string test, bool expected)
        {
            Assert.AreEqual(expected, AnagramDetectionKata.IsAnagram(test, original));
        }
    }
}