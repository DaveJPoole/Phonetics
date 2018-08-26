using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PhoneticsTests
{
    [TestClass]
    public class MetaphoneTests
    {
        const int METAPHONE = 4;

        [TestMethod]
        public void MetaphoneStart_ThreeLetterSubsitutitions()
        {
            Assert.AreEqual("X", Phonetics.LongPhonetic(METAPHONE, "CIA"));
            Assert.AreEqual("J", Phonetics.LongPhonetic(METAPHONE, "DGE"));
            Assert.AreEqual("J", Phonetics.LongPhonetic(METAPHONE, "DGI"));
            Assert.AreEqual("J", Phonetics.LongPhonetic(METAPHONE, "DGY"));
            Assert.AreEqual("SX", Phonetics.LongPhonetic(METAPHONE, "SCH"));
            Assert.AreEqual("X", Phonetics.LongPhonetic(METAPHONE, "TIA"));
            Assert.AreEqual("X", Phonetics.LongPhonetic(METAPHONE, "TCH"));
            Assert.AreEqual("X", Phonetics.LongPhonetic(METAPHONE, "TIO"));
            Assert.AreEqual("EH", Phonetics.LongPhonetic(METAPHONE, "EHA"));

        }

        [TestMethod]
        public void MetaphoneStart_Pair()
        {
            Assert.AreEqual("E", Phonetics.LongPhonetic(METAPHONE, "AE"));
            Assert.AreEqual("S", Phonetics.LongPhonetic(METAPHONE, "CI"));
            Assert.AreEqual("S", Phonetics.LongPhonetic(METAPHONE, "CE"));
            Assert.AreEqual("S", Phonetics.LongPhonetic(METAPHONE, "CY"));
            Assert.AreEqual("N", Phonetics.LongPhonetic(METAPHONE, "GN"));
            Assert.AreEqual("N", Phonetics.LongPhonetic(METAPHONE, "KN"));
            Assert.AreEqual("F", Phonetics.LongPhonetic(METAPHONE, "PH"));
            Assert.AreEqual("N", Phonetics.LongPhonetic(METAPHONE, "PN"));
            Assert.AreEqual("X", Phonetics.LongPhonetic(METAPHONE, "SH"));
            Assert.AreEqual("0", Phonetics.LongPhonetic(METAPHONE, "TH"));
            Assert.AreEqual("R", Phonetics.LongPhonetic(METAPHONE, "WR"));
        }

        [TestMethod]
        public void MetaphoneStart_Y()
        {
            Assert.AreEqual("K", Phonetics.LongPhonetic(METAPHONE, "YC"));
            Assert.AreEqual("T", Phonetics.LongPhonetic(METAPHONE, "YD"));
            Assert.AreEqual("K", Phonetics.LongPhonetic(METAPHONE, "YG"));
            Assert.AreEqual("", Phonetics.LongPhonetic(METAPHONE, "YH"));
            Assert.AreEqual("K", Phonetics.LongPhonetic(METAPHONE, "YQ"));
            Assert.AreEqual("F", Phonetics.LongPhonetic(METAPHONE, "YV"));
            Assert.AreEqual("", Phonetics.LongPhonetic(METAPHONE, "YW"));
            Assert.AreEqual("S", Phonetics.LongPhonetic(METAPHONE, "YX"));
            Assert.AreEqual("S", Phonetics.LongPhonetic(METAPHONE, "YZ"));

        }
        public void MetaphoneLetter_Y()
        {
            Assert.AreEqual("SNK", Phonetics.LongPhonetic(METAPHONE, "SYNC"));
            Assert.AreEqual("SY", Phonetics.LongPhonetic(METAPHONE, "SOYA"));

        }

        [TestMethod]
        public void MetaphoneStart_SameSingle()
        {
            Assert.AreEqual("A", Phonetics.LongPhonetic(METAPHONE, "A"));
            Assert.AreEqual("B", Phonetics.LongPhonetic(METAPHONE, "B"));
            Assert.AreEqual("E", Phonetics.LongPhonetic(METAPHONE, "E"));
            Assert.AreEqual("F", Phonetics.LongPhonetic(METAPHONE, "F"));
            Assert.AreEqual("H", Phonetics.LongPhonetic(METAPHONE, "H"));
            Assert.AreEqual("I", Phonetics.LongPhonetic(METAPHONE, "I"));
            Assert.AreEqual("J", Phonetics.LongPhonetic(METAPHONE, "J"));
            Assert.AreEqual("K", Phonetics.LongPhonetic(METAPHONE, "K"));
            Assert.AreEqual("L", Phonetics.LongPhonetic(METAPHONE, "L"));
            Assert.AreEqual("M", Phonetics.LongPhonetic(METAPHONE, "M"));
            Assert.AreEqual("N", Phonetics.LongPhonetic(METAPHONE, "N"));
            Assert.AreEqual("O", Phonetics.LongPhonetic(METAPHONE, "O"));
            Assert.AreEqual("P", Phonetics.LongPhonetic(METAPHONE, "P"));
            Assert.AreEqual("R", Phonetics.LongPhonetic(METAPHONE, "R"));
            Assert.AreEqual("S", Phonetics.LongPhonetic(METAPHONE, "S"));
            Assert.AreEqual("T", Phonetics.LongPhonetic(METAPHONE, "T"));
            Assert.AreEqual("U", Phonetics.LongPhonetic(METAPHONE, "U"));
            Assert.AreEqual("W", Phonetics.LongPhonetic(METAPHONE, "W"));
            Assert.AreEqual("Y", Phonetics.LongPhonetic(METAPHONE, "Y"));
        }

        [TestMethod]
        public void MetaphoneStart_SubstituteSingle()
        {
            Assert.AreEqual("K", Phonetics.LongPhonetic(METAPHONE, "C"));
            Assert.AreEqual("T", Phonetics.LongPhonetic(METAPHONE, "D"));
            Assert.AreEqual("K", Phonetics.LongPhonetic(METAPHONE, "G"));
            Assert.AreEqual("K", Phonetics.LongPhonetic(METAPHONE, "Q"));
            Assert.AreEqual("F", Phonetics.LongPhonetic(METAPHONE, "V"));
            Assert.AreEqual("S", Phonetics.LongPhonetic(METAPHONE, "X"));
            Assert.AreEqual("S", Phonetics.LongPhonetic(METAPHONE, "Z"));

        }

        [TestMethod]
        public void Metaphone_letter_H()
        {
            Assert.AreEqual("AH", Phonetics.LongPhonetic(METAPHONE, "AHOY"));
            Assert.AreEqual("SF", Phonetics.LongPhonetic(METAPHONE, "SIGH"));
            Assert.AreEqual("S", Phonetics.LongPhonetic(METAPHONE, "SAH"));
            Assert.AreEqual("KST", Phonetics.LongPhonetic(METAPHONE, "GHOST"));
        }

        [TestMethod]
        public void Metaphone_SampleWords()
        {
            Assert.AreEqual("AB", Phonetics.LongPhonetic(METAPHONE, "ABBEY"));
        }

        [TestMethod]
        public void Metaphone_Contains_GN()
        {
            Assert.AreEqual("NSTK", Phonetics.LongPhonetic(METAPHONE, "Gnostic"));
            Assert.AreEqual("SNT", Phonetics.LongPhonetic(METAPHONE, "Signed"));
            Assert.AreEqual("SN", Phonetics.LongPhonetic(METAPHONE, "Sign"));

        }
        [TestMethod]
        public void Metaphone_Starts_With_Vowel()
        {
            Assert.AreEqual("ARMR", Phonetics.LongPhonetic(METAPHONE, "Armour"));
            Assert.AreEqual("EFR", Phonetics.LongPhonetic(METAPHONE, "Ever"));
            Assert.AreEqual("INTJR", Phonetics.LongPhonetic(METAPHONE, "Integer"));
            Assert.AreEqual("ONRS", Phonetics.LongPhonetic(METAPHONE, "ONEROUS"));
            Assert.AreEqual("UNT", Phonetics.LongPhonetic(METAPHONE, "UNDO"));
        }
        [TestMethod]
        public void Metaphone_letter_X()
        {
            Assert.AreEqual("SKS", Phonetics.LongPhonetic(METAPHONE, "Six"));
            Assert.AreEqual("SKS", Phonetics.LongPhonetic(METAPHONE, "Sixes"));
            Assert.AreEqual("S", Phonetics.LongPhonetic(METAPHONE, "Xis"));
        }
        [TestMethod]
        public void Metaphone_double_letter_()
        {
            Assert.AreEqual("AKSPT", Phonetics.LongPhonetic(METAPHONE, "Accepted"));
            Assert.AreEqual("ATR", Phonetics.LongPhonetic(METAPHONE, "Adder"));
            Assert.AreEqual("AKRKXN", Phonetics.LongPhonetic(METAPHONE, "Aggreggation"));
        }
    }
}
