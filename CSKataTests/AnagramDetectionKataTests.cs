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
            string original = "A";
            string test = "A";

            Assert.AreEqual(true, AnagramDetectionKata.IsAnagram(test, original));
        }

        [TestMethod()]
        public void OneLetterAndDiffentCase()
        {
            string original = "a";
            string test = "A";

            Assert.AreEqual(true, AnagramDetectionKata.IsAnagram(test, original));
        }

        [TestMethod()]
        public void SameWord()
        {
            string original = "coffee";
            string test = "coffee";

            Assert.AreEqual(true, AnagramDetectionKata.IsAnagram(test, original));
        }

        [TestMethod()]
        public void SameLettersSameCount()
        {
            string original = "toffee";
            string test = "foefet";

            Assert.AreEqual(true, AnagramDetectionKata.IsAnagram(test, original));
        }

        [TestMethod()]
        public void SameLettersDifferentCount()
        {
            string original = "apple";
            string test = "pale";

            Assert.AreEqual(false, AnagramDetectionKata.IsAnagram(test, original));
        }
    }
}