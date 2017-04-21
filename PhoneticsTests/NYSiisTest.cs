using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PhoneticsTests
{
    [TestClass]
    public class NYSiisTest
    {
        const int NYSIIS = 2;

        [TestMethod]
        public void NYSiiS_Start(){
            Assert.AreEqual("MC", Phonetics.LongPhonetic(NYSIIS, "MAC"));
            Assert.AreEqual("MC", Phonetics.LongPhonetic(NYSIIS, " MAC"));
            Assert.AreEqual("N", Phonetics.LongPhonetic(NYSIIS, "KN"));
            Assert.AreEqual("F", Phonetics.LongPhonetic(NYSIIS, "PH"));
            Assert.AreEqual("S", Phonetics.LongPhonetic(NYSIIS, "SCH"));
            Assert.AreEqual("F", Phonetics.LongPhonetic(NYSIIS, "PF"));
            Assert.AreEqual("C", Phonetics.LongPhonetic(NYSIIS, "K"));
            Assert.AreEqual("C", Phonetics.LongPhonetic(NYSIIS, " K"));

        }

        [TestMethod]
        public void NYSIS_WordEnd()
        {
            Assert.AreEqual("MY", Phonetics.LongPhonetic(NYSIIS, "MAY"));
            Assert.AreEqual("FAD", Phonetics.LongPhonetic(NYSIIS, "PHART"));
            Assert.AreEqual("MCY", Phonetics.LongPhonetic(NYSIIS, "MACKIE"));
            Assert.AreEqual("MCY", Phonetics.LongPhonetic(NYSIIS, "MACKEE"));
            Assert.AreEqual("SNAD", Phonetics.LongPhonetic(NYSIIS, "SCHMIDT"));
            Assert.AreEqual("BAD", Phonetics.LongPhonetic(NYSIIS, "Bart"));
            Assert.AreEqual("HAD", Phonetics.LongPhonetic(NYSIIS, "Hurd"));
            Assert.AreEqual("HAD", Phonetics.LongPhonetic(NYSIIS, "Hunt"));
            Assert.AreEqual("WASTARLAD", Phonetics.LongPhonetic(NYSIIS, "WESTERLUND"));
            Assert.AreEqual("CARAY", Phonetics.LongPhonetic(NYSIIS, "CARRAWAY"));
            /*
             * MACINTOSH
             */

        }

        [TestMethod]
        public void NYSIS_EV()
        {
            Assert.AreEqual("CASTAFAN", Phonetics.LongPhonetic(NYSIIS, "CASSTEVENS"));
        }


        [TestMethod]
        public void NYSIIS_H_Test()
        {
            Assert.AreEqual("MCANTAS", Phonetics.LongPhonetic(NYSIIS, "Mackcintosh"));
            Assert.AreEqual("SAH", Phonetics.LongPhonetic(NYSIIS, "Soho"));
            Assert.AreEqual("Arax", Phonetics.LongPhonetic(NYSIIS, "Ahyrax"));
            Assert.AreEqual("NAT", Phonetics.LongPhonetic(NYSIIS, "KNUTH"));

        }
        [TestMethod]
        public void NYSIIS_Q_Test()
        {
            Assert.AreEqual("VASG", Phonetics.LongPhonetic(NYSIIS, "VASQUEZ"));
            Assert.AreEqual("QAN", Phonetics.LongPhonetic(NYSIIS, "Queen"));

        }

        [TestMethod]
        public void NYSIIS_M_Test()
        {
            Assert.AreEqual("BANAN", Phonetics.LongPhonetic(NYSIIS, "BOWMAN"));

        }
        [TestMethod]
        public void NYSIIS_TwoWordTest()
        {
            Assert.AreEqual("DAVAD PAL", Phonetics.LongPhonetic(NYSIIS, "David-@Poole"));
            Assert.AreEqual("AH AH", Phonetics.LongPhonetic(NYSIIS, "-AH-AH"));

        }
    }
}
