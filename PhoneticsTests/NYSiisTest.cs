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
            Assert.AreEqual("N", Phonetics.LongPhonetic(2, "KN"));
            Assert.AreEqual("F", Phonetics.LongPhonetic(2, "PH"));
            Assert.AreEqual("S", Phonetics.LongPhonetic(2, "SCH"));
            Assert.AreEqual("F", Phonetics.LongPhonetic(2, "PF"));
            Assert.AreEqual("C", Phonetics.LongPhonetic(2, "K"));
            Assert.AreEqual("C", Phonetics.LongPhonetic(2, " K"));

        }

        [TestMethod]
        public void NYSIS_WordEnd()
        {
            Assert.AreEqual("MY", Phonetics.LongPhonetic(2, "MAY"));
            Assert.AreEqual("FAD", Phonetics.LongPhonetic(2, "PHART"));
            Assert.AreEqual("MCY", Phonetics.LongPhonetic(2, "MACKIE"));
            Assert.AreEqual("MCY", Phonetics.LongPhonetic(2, "MACKEE"));
            Assert.AreEqual("SNAD", Phonetics.LongPhonetic(2, "SCHMIDT"));
            Assert.AreEqual("BAD", Phonetics.LongPhonetic(2, "Bart"));
            Assert.AreEqual("HAD", Phonetics.LongPhonetic(2, "Hurd"));
            Assert.AreEqual("HAD", Phonetics.LongPhonetic(2, "Hunt"));
            Assert.AreEqual("WASTARLAD", Phonetics.LongPhonetic(2, "WESTERLUND"));
            Assert.AreEqual("CARAY", Phonetics.LongPhonetic(2, "CARRAWAY"));
            /*
             * MACINTOSH
             */

        }

        [TestMethod]
        public void NYSIS_EV()
        {
            Assert.AreEqual("CASTAFAN", Phonetics.LongPhonetic(2, "CASSTEVENS"));
        }


        [TestMethod]
        public void NYSIIS_H_Test()
        {
            Assert.AreEqual("MCANTAS", Phonetics.LongPhonetic(2, "Mackcintosh"));
            Assert.AreEqual("SAH", Phonetics.LongPhonetic(2, "Soho"));
            Assert.AreEqual("Arax", Phonetics.LongPhonetic(2, "Ahyrax"));
            Assert.AreEqual("NAT", Phonetics.LongPhonetic(2, "KNUTH"));

        }
        [TestMethod]
        public void NYSIIS_Q_Test()
        {
            Assert.AreEqual("VASG", Phonetics.LongPhonetic(2, "VASQUEZ"));
            Assert.AreEqual("QAN", Phonetics.LongPhonetic(2, "Queen"));

        }

        [TestMethod]
        public void NYSIIS_M_Test()
        {
            Assert.AreEqual("BANAN", Phonetics.LongPhonetic(2, "BOWMAN"));

        }
    }
}
