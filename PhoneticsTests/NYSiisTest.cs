using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PhoneticsTests
{
    [TestClass]
    public class NYSiisTest
    {
        [TestMethod]
        public void NYSiiS_Start(){
            Assert.AreEqual("MC", Phonetics.LongPhonetic(2, "MAC"));
            Assert.AreEqual("MC", Phonetics.LongPhonetic(2, " MAC"));
            Assert.AreEqual("F", Phonetics.LongPhonetic(2, "PH"));
            Assert.AreEqual("S", Phonetics.LongPhonetic(2, "SCH"));
            Assert.AreEqual("F", Phonetics.LongPhonetic(2, " PF"));

        }

        [TestMethod]
        public void NYSIS_WordEnd()
        {
            Assert.AreEqual("MY", Phonetics.LongPhonetic(2, "MAY"));
            Assert.AreEqual("FAD", Phonetics.LongPhonetic(2, "PHART"));
            Assert.AreEqual("MCY", Phonetics.LongPhonetic(2, "MACKIE"));
            Assert.AreEqual("CASTAFAN", Phonetics.LongPhonetic(2, "CASSTEVENS"));
            Assert.AreEqual("MCANT", Phonetics.LongPhonetic(2, "MACINTOSH"));
            /*
             * MACINTOSH
             */

        }
    }
}
