using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PhoneticsTests
{
    [TestClass]
    public class MetaphoneTests
    {
        const int METAPHONE = 4;

        [TestMethod]
        public void MetaphoneStart()
        {
            Assert.AreEqual("N", Phonetics.LongPhonetic(METAPHONE, "KN"));
            Assert.AreEqual("N", Phonetics.LongPhonetic(METAPHONE, "GN"));
            Assert.AreEqual("N", Phonetics.LongPhonetic(METAPHONE, "PN"));
            Assert.AreEqual("E", Phonetics.LongPhonetic(METAPHONE, "AE"));
            Assert.AreEqual("R", Phonetics.LongPhonetic(METAPHONE, "WR"));
            Assert.AreEqual("S", Phonetics.LongPhonetic(METAPHONE, "X"));

        }
    }
}
