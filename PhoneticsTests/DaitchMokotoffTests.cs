using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PhoneticsTests
{
    [TestClass]
    public class DaitchMokotoffSoundex
    {
        [TestMethod]
        public void DM_ZeroStart()
        {
            Assert.AreEqual("0", Phonetics.LongPhonetic(3, "AI"));
            Assert.AreEqual("0", Phonetics.LongPhonetic(3, "AJ"));
            Assert.AreEqual("0", Phonetics.LongPhonetic(3, "AU"));
            Assert.AreEqual("0", Phonetics.LongPhonetic(3, "AY"));
            Assert.AreEqual("0", Phonetics.LongPhonetic(3, "EI"));
            Assert.AreEqual("0", Phonetics.LongPhonetic(3, "EJ"));
            Assert.AreEqual("0", Phonetics.LongPhonetic(3, "EY"));
            Assert.AreEqual("0", Phonetics.LongPhonetic(3, "OI"));
            Assert.AreEqual("0", Phonetics.LongPhonetic(3, "OJ"));
            Assert.AreEqual("0", Phonetics.LongPhonetic(3, "OY"));
            Assert.AreEqual("0", Phonetics.LongPhonetic(3, "UE"));
            Assert.AreEqual("0", Phonetics.LongPhonetic(3, "UI"));
            Assert.AreEqual("0", Phonetics.LongPhonetic(3, "UJ"));
            Assert.AreEqual("0", Phonetics.LongPhonetic(3, "UY"));
            Assert.AreEqual("0", Phonetics.LongPhonetic(3, "A"));
            Assert.AreEqual("0", Phonetics.LongPhonetic(3, "E"));
            Assert.AreEqual("0", Phonetics.LongPhonetic(3, "I"));
            Assert.AreEqual("0", Phonetics.LongPhonetic(3, "O"));
            Assert.AreEqual("0", Phonetics.LongPhonetic(3, "U"));
            Assert.AreEqual("0", Phonetics.LongPhonetic(3, "Y"));
        }
        [TestMethod]
        public void DM_OneStart()
        {
            Assert.AreEqual("1", Phonetics.LongPhonetic(3, "IA"));
            Assert.AreEqual("1", Phonetics.LongPhonetic(3, "IE"));
            Assert.AreEqual("1", Phonetics.LongPhonetic(3, "IO"));
            Assert.AreEqual("1", Phonetics.LongPhonetic(3, "IU"));
            Assert.AreEqual("1", Phonetics.LongPhonetic(3, "EU"));
            Assert.AreEqual("1", Phonetics.LongPhonetic(3, "J"));
        }
        [TestMethod]
        public void DM_TwoStart()
        {
            Assert.AreEqual("2", Phonetics.LongPhonetic(3, "SCHTSCH"));
            Assert.AreEqual("2", Phonetics.LongPhonetic(3, "SCHTSH"));
            Assert.AreEqual("2", Phonetics.LongPhonetic(3, "SCHTSH"));
            Assert.AreEqual("2", Phonetics.LongPhonetic(3, "SCTCH"));
            Assert.AreEqual("2", Phonetics.LongPhonetic(3, "STSCH"));
            Assert.AreEqual("2", Phonetics.LongPhonetic(3, "SHTSH"));
            Assert.AreEqual("2", Phonetics.LongPhonetic(3, "SHCH"));
            Assert.AreEqual("2", Phonetics.LongPhonetic(3, "STCH"));
            Assert.AreEqual("2", Phonetics.LongPhonetic(3, "STRZ"));
            Assert.AreEqual("2", Phonetics.LongPhonetic(3, "STRS"));
            Assert.AreEqual("2", Phonetics.LongPhonetic(3, "STSH"));
            Assert.AreEqual("2", Phonetics.LongPhonetic(3, "SZCZ"));
            Assert.AreEqual("2", Phonetics.LongPhonetic(3, "SZCS"));
            Assert.AreEqual("2", Phonetics.LongPhonetic(3, "SCHD"));
            Assert.AreEqual("2", Phonetics.LongPhonetic(3, "SCHT"));
            Assert.AreEqual("2", Phonetics.LongPhonetic(3, "SHT"));
            Assert.AreEqual("2", Phonetics.LongPhonetic(3, "SHD"));
            Assert.AreEqual("2", Phonetics.LongPhonetic(3, "SZD"));
            Assert.AreEqual("2", Phonetics.LongPhonetic(3, "SZT"));
            Assert.AreEqual("2", Phonetics.LongPhonetic(3, "ST"));
            Assert.AreEqual("2", Phonetics.LongPhonetic(3, "SC"));
        }
        [TestMethod]
        public void DM_ThreeStart()
        {
            Assert.AreEqual("3", Phonetics.LongPhonetic(3, "DT"));
            Assert.AreEqual("3", Phonetics.LongPhonetic(3, "TH"));
            Assert.AreEqual("3", Phonetics.LongPhonetic(3, "T"));
            Assert.AreEqual("3", Phonetics.LongPhonetic(3, "D"));
        }
        [TestMethod]
        public void DM_SixStart()
        {
            Assert.AreEqual("6", Phonetics.LongPhonetic(3, "M"));
            Assert.AreEqual("6", Phonetics.LongPhonetic(3, "N"));
        }
        [TestMethod]
        public void DM_SevenStart()
        {
            Assert.AreEqual("7", Phonetics.LongPhonetic(3, "FB"));
            Assert.AreEqual("7", Phonetics.LongPhonetic(3, "PH"));
            Assert.AreEqual("7", Phonetics.LongPhonetic(3, "PF"));
            Assert.AreEqual("7", Phonetics.LongPhonetic(3, "B"));
            Assert.AreEqual("7", Phonetics.LongPhonetic(3, "F"));
            Assert.AreEqual("7", Phonetics.LongPhonetic(3, "P"));
            Assert.AreEqual("7", Phonetics.LongPhonetic(3, "V"));
            Assert.AreEqual("7", Phonetics.LongPhonetic(3, "W"));
        }
        [TestMethod]
        public void DM_EightStart()
        {
            Assert.AreEqual("8", Phonetics.LongPhonetic(3, "L"));
        }
        [TestMethod]
        public void DM_NineStart()
        {
            Assert.AreEqual("9", Phonetics.LongPhonetic(3, "R"));
        }
    }
}
