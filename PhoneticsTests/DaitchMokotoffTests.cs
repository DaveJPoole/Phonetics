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
        public void DM_FourStart()
        {
            Assert.AreEqual("4", Phonetics.LongPhonetic(3, "TTSCH"));
            Assert.AreEqual("4", Phonetics.LongPhonetic(3, "CSZ"));
            Assert.AreEqual("4", Phonetics.LongPhonetic(3, "CZS"));
            Assert.AreEqual("4", Phonetics.LongPhonetic(3, "CS"));
            Assert.AreEqual("4", Phonetics.LongPhonetic(3, "CZ"));
            Assert.AreEqual("4", Phonetics.LongPhonetic(3, "DRZ"));
            Assert.AreEqual("4", Phonetics.LongPhonetic(3, "DRS"));
            Assert.AreEqual("4", Phonetics.LongPhonetic(3, "DSH"));
            Assert.AreEqual("4", Phonetics.LongPhonetic(3, "DZH"));
            Assert.AreEqual("4", Phonetics.LongPhonetic(3, "DZS"));
            Assert.AreEqual("4", Phonetics.LongPhonetic(3, "DS"));
            Assert.AreEqual("4", Phonetics.LongPhonetic(3, "DZ"));
            Assert.AreEqual("4", Phonetics.LongPhonetic(3, "S"));
            Assert.AreEqual("4", Phonetics.LongPhonetic(3, "Z"));
            Assert.AreEqual("4", Phonetics.LongPhonetic(3, "TRZ"));
            Assert.AreEqual("4", Phonetics.LongPhonetic(3, "TRS"));
            Assert.AreEqual("4", Phonetics.LongPhonetic(3, "TRCH"));
            Assert.AreEqual("4", Phonetics.LongPhonetic(3, "TSH"));
            Assert.AreEqual("4", Phonetics.LongPhonetic(3, "SCH"));
            Assert.AreEqual("4", Phonetics.LongPhonetic(3, "SH"));
            Assert.AreEqual("4", Phonetics.LongPhonetic(3, "TTSZ"));
            Assert.AreEqual("4", Phonetics.LongPhonetic(3, "TTZ"));
            Assert.AreEqual("4", Phonetics.LongPhonetic(3, "TTS"));
            Assert.AreEqual("4", Phonetics.LongPhonetic(3, "TZS"));
            Assert.AreEqual("4", Phonetics.LongPhonetic(3, "TC"));
            Assert.AreEqual("4", Phonetics.LongPhonetic(3, "TS"));
            Assert.AreEqual("4", Phonetics.LongPhonetic(3, "TZ"));
            Assert.AreEqual("4", Phonetics.LongPhonetic(3, "TSZ"));
            Assert.AreEqual("4", Phonetics.LongPhonetic(3, "ZH"));
            Assert.AreEqual("4", Phonetics.LongPhonetic(3, "ZS"));
            Assert.AreEqual("4", Phonetics.LongPhonetic(3, "ZSCH"));
            Assert.AreEqual("4", Phonetics.LongPhonetic(3, "ZHSH"));
        }
        [TestMethod]
        public void DM_FiveStart()
        {
            Assert.AreEqual("5", Phonetics.LongPhonetic(3, "CHS"));
            Assert.AreEqual("5", Phonetics.LongPhonetic(3, "CH"));
            Assert.AreEqual("5", Phonetics.LongPhonetic(3, "CK"));
            Assert.AreEqual("5", Phonetics.LongPhonetic(3, "KH"));
            Assert.AreEqual("5", Phonetics.LongPhonetic(3, "KS"));
            Assert.AreEqual("5", Phonetics.LongPhonetic(3, "C"));
            Assert.AreEqual("5", Phonetics.LongPhonetic(3, "G"));
            Assert.AreEqual("5", Phonetics.LongPhonetic(3, "K"));
            Assert.AreEqual("5", Phonetics.LongPhonetic(3, "Q"));
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
        [TestMethod]
        public void DM_START_AllAlphabeticsTest()
        {
            String testString="";
            
            for (int i = Convert.ToInt32('A'); i <= Convert.ToInt32('Z'); i++)
            {
                testString = Convert.ToString(Phonetics.LongPhonetic(3, Convert.ToChar(i).ToString()));

                if (!Char.IsDigit(testString,0)){

                    Assert.Fail("Incomplete list of substitutions for starting characters "+testString);

                }
            }
        }

    }
}
