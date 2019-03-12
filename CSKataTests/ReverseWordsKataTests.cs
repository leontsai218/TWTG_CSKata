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
    public class ReverseWordsKataTests
    {
        string OriginalString;

        [TestMethod()]
        public void OneLetterWord()
        {
            GivenString("A");
            ShouldBe("A");
        }

        [TestMethod()]
        public void OneWord()
        {
            GivenString("Apple!");
            ShouldBe("!elppA");
        }

        [TestMethod()]
        public void NormalSentence()
        {
            GivenString("This is an example!");
            ShouldBe("sihT si na !elpmaxe");
        }

        [TestMethod()]
        public void WithDoubleSpace()
        {
            GivenString("double  spaces");
            ShouldBe("elbuod  secaps");
        }

        private void GivenString(string str)
        {
            OriginalString = str;
        }
        private void ShouldBe(string expected)
        {
            Assert.AreEqual(expected, ReverseWordsKata.ReverseWords(OriginalString));
        }
    }
}