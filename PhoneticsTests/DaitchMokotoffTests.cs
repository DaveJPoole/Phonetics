using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PhoneticsTests
{
    
    [TestClass]
    public class DaitchMokotoffSoundex
    {
        const int DAITCHMOKOTOFF = 3;
        #region Single Test
        [TestMethod]
        public void DM_ActiveSingleTest()
        {
            Assert.AreEqual("05 05", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "-AH--AH"));
        }
        #endregion

        #region Word Start Tests
        [TestMethod]
        public void DM_ZeroStart()
        {
            Assert.AreEqual("0", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "AI"));
            Assert.AreEqual("0", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "AJ"));
            Assert.AreEqual("0", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "AU"));
            Assert.AreEqual("0", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "AY"));
            Assert.AreEqual("0", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "EI"));
            Assert.AreEqual("0", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "EJ"));
            Assert.AreEqual("0", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "EY"));
            Assert.AreEqual("0", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "OI"));
            Assert.AreEqual("0", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "OJ"));
            Assert.AreEqual("0", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "OY"));
            Assert.AreEqual("0", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "UE"));
            Assert.AreEqual("0", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "UI"));
            Assert.AreEqual("0", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "UJ"));
            Assert.AreEqual("0", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "UY"));
            Assert.AreEqual("0", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "A"));
            Assert.AreEqual("0", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "E"));
            Assert.AreEqual("0", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "I"));
            Assert.AreEqual("0", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "O"));
            Assert.AreEqual("0", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "U"));
            Assert.AreEqual("0", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "Y"));
        }
        [TestMethod]
        public void DM_Start_1()
        {
            Assert.AreEqual("1", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "IA"));
            Assert.AreEqual("1", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "IE"));
            Assert.AreEqual("1", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "IO"));
            Assert.AreEqual("1", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "IU"));
            Assert.AreEqual("1", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "EU"));
            Assert.AreEqual("1", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "J"));
        }
        [TestMethod]
        public void DM_Start_2()
        {
            Assert.AreEqual("2", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "SCHTSCH"));
            Assert.AreEqual("2", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "SCHTSH"));
            Assert.AreEqual("2", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "SCHTSH"));
            Assert.AreEqual("2", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "STSCH"));
            Assert.AreEqual("2", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "SHTSH"));
            Assert.AreEqual("2", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "SHCH"));
            Assert.AreEqual("2", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "STCH"));
            Assert.AreEqual("2", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "STRZ"));
            Assert.AreEqual("2", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "STRS"));
            Assert.AreEqual("2", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "STSH"));
            Assert.AreEqual("2", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "SZCZ"));
            Assert.AreEqual("2", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "SZCS"));
            Assert.AreEqual("2", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "SCHD"));
            Assert.AreEqual("2", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "SCHT"));
            Assert.AreEqual("2", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "SHT"));
            Assert.AreEqual("2", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "SHD"));
            Assert.AreEqual("2", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "SZD"));
            Assert.AreEqual("2", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "SZT"));
            Assert.AreEqual("2", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "ST"));
            Assert.AreEqual("2", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "SC"));
        }
        [TestMethod]
        public void DM_Start_3()
        {
            Assert.AreEqual("3", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "DT"));
            Assert.AreEqual("3", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "TH"));
            Assert.AreEqual("3", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "T"));
            Assert.AreEqual("3", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "D"));
        }
        [TestMethod]
        public void DM_Start_4()
        {
            Assert.AreEqual("4", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "TTSCH"));
            Assert.AreEqual("4", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "CSZ"));
            Assert.AreEqual("4", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "CZS"));
            Assert.AreEqual("4", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "CS"));
            Assert.AreEqual("4", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "CZ"));
            Assert.AreEqual("4", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "DRZ"));
            Assert.AreEqual("4", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "DRS"));
            Assert.AreEqual("4", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "DSH"));
            Assert.AreEqual("4", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "DZH"));
            Assert.AreEqual("4", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "DZS"));
            Assert.AreEqual("4", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "DS"));
            Assert.AreEqual("4", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "DZ"));
            Assert.AreEqual("4", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "S"));
            Assert.AreEqual("4", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "Z"));
            Assert.AreEqual("4", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "TRZ"));
            Assert.AreEqual("4", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "TRS"));
            Assert.AreEqual("4", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "TRCH"));
            Assert.AreEqual("4", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "TSH"));
            Assert.AreEqual("4", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "SCH"));
            Assert.AreEqual("4", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "SH"));
            Assert.AreEqual("4", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "TTSZ"));
            Assert.AreEqual("4", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "TTZ"));
            Assert.AreEqual("4", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "TTS"));
            Assert.AreEqual("4", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "TZS"));
            Assert.AreEqual("4", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "TC"));
            Assert.AreEqual("4", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "TS"));
            Assert.AreEqual("4", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "TZ"));
            Assert.AreEqual("4", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "TSZ"));
            Assert.AreEqual("4", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "ZH"));
            Assert.AreEqual("4", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "ZS"));
            Assert.AreEqual("4", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "ZSCH"));
            Assert.AreEqual("4", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "ZHSH"));
        }
        [TestMethod]
        public void DM_Start_5()
        {
            Assert.AreEqual("5", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "CHS"));
            Assert.AreEqual("5", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "CH"));
            Assert.AreEqual("5", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "CK"));
            Assert.AreEqual("5", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "KH"));
            Assert.AreEqual("5", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "KS"));
            Assert.AreEqual("5", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "C"));
            Assert.AreEqual("5", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "G"));
            Assert.AreEqual("5", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "K"));
            Assert.AreEqual("5", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "Q"));
        }
        [TestMethod]
        public void DM_Start_6()
        {
            Assert.AreEqual("6", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "M"));
            Assert.AreEqual("6", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "N"));
        }
        [TestMethod]
        public void DM_Start_7()
        {
            Assert.AreEqual("7", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "FB"));
            Assert.AreEqual("7", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "PH"));
            Assert.AreEqual("7", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "PF"));
            Assert.AreEqual("7", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "B"));
            Assert.AreEqual("7", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "F"));
            Assert.AreEqual("7", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "P"));
            Assert.AreEqual("7", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "V"));
            Assert.AreEqual("7", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "W"));
        }
        [TestMethod]
        public void DM_Start_8()
        {
            Assert.AreEqual("8", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "L"));
        }
        [TestMethod]
        public void DM_Start_9()
        {
            Assert.AreEqual("9", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "R"));
        }
        [TestMethod]
        public void DM_START_AllAlphabeticsTest()
        {
            String testString="";
            
            for (int i = Convert.ToInt32('A'); i <= Convert.ToInt32('Z'); i++)
            {
                testString = Convert.ToString(Phonetics.LongPhonetic(DAITCHMOKOTOFF, Convert.ToChar(i).ToString()));

                if (!Char.IsDigit(testString,0)){

                    Assert.Fail("Incomplete list of substitutions for starting characters "+testString);

                }
            }
        }
#endregion
        #region After Vowel Tests
        [TestMethod]
        public void DM_AfterVowel_Discard()
        {
            Assert.AreEqual("0", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "UIA"));
            Assert.AreEqual("0", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "UIE"));
            Assert.AreEqual("0", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "UIO"));
            Assert.AreEqual("0", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "UIU"));
            Assert.AreEqual("0", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "UUE"));
            Assert.AreEqual("0", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "AA"));
            Assert.AreEqual("0", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "EE"));
            Assert.AreEqual("0", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "II"));
            Assert.AreEqual("0", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "OO"));
            Assert.AreEqual("0", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "UU"));
            Assert.AreEqual("0", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "IY"));
        }

        [TestMethod]
        public void DM_AfterVowel_1()
        {
            Assert.AreEqual("01", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "AAI"));
            Assert.AreEqual("01", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "AAJ"));
            Assert.AreEqual("01", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "AAY"));
            Assert.AreEqual("01", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "AEI"));
            Assert.AreEqual("01", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "AEJ"));
            Assert.AreEqual("01", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "AEU"));
            Assert.AreEqual("01", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "AEY"));
            Assert.AreEqual("01", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "AOI"));
            Assert.AreEqual("01", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "AOJ"));
            Assert.AreEqual("01", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "AOY"));
            Assert.AreEqual("01", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "UUI"));
            Assert.AreEqual("01", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "UUJ"));
            Assert.AreEqual("01", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "UUY"));


        }
        [TestMethod]
        public void DM_AfterVowel_3()
        {
            Assert.AreEqual("03", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "ADT"));
            Assert.AreEqual("03", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "ATH"));
            Assert.AreEqual("03", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "AD"));
            Assert.AreEqual("03", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "AT"));
        }



        [TestMethod]
        public void DM_AfterVowel_4()
        {
            Assert.AreEqual("043", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "ASCHD"));
            Assert.AreEqual("043", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "ASCHT"));
            Assert.AreEqual("043", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "ASHT"));
            Assert.AreEqual("043", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "ASHD"));
            Assert.AreEqual("043", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "ASZD"));
            Assert.AreEqual("043", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "ASZT"));
            Assert.AreEqual("043", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "AST"));

            Assert.AreEqual("04", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "ASC"));
            Assert.AreEqual("04", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "AS"));
            Assert.AreEqual("04", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "AZ"));

            Assert.AreEqual("04", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "ASCHTSCH"));
            Assert.AreEqual("04", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "ASCHTSH"));
            Assert.AreEqual("04", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "ASCHTSH"));
            Assert.AreEqual("04", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "ASTSCH"));
            Assert.AreEqual("04", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "ASHTSH"));
            Assert.AreEqual("04", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "ASHCH"));
            Assert.AreEqual("04", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "ASTCH"));
            Assert.AreEqual("04", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "ASTRS"));
            Assert.AreEqual("04", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "ASTRZ"));
            Assert.AreEqual("04", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "ASTSH"));
            Assert.AreEqual("04", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "ASZCZ"));
            Assert.AreEqual("04", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "ASZCS"));
        }
        
        [TestMethod]
        public void DM_AfterVowel_5()
        {
            Assert.AreEqual("05", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "AH"));
            Assert.AreEqual("05", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "ACH"));
            Assert.AreEqual("05", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "ACK"));
            Assert.AreEqual("05", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "AH"));
            Assert.AreEqual("05", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "AC"));
            Assert.AreEqual("05", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "AG"));
            Assert.AreEqual("05", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "AK"));
            Assert.AreEqual("05", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "AQ"));
            Assert.AreEqual("054", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "AX"));
            Assert.AreEqual("054", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "AKS"));
            Assert.AreEqual("054", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "ACHS"));
        }
        [TestMethod]
        public void DM_AfterVowel_6()
        {
            Assert.AreEqual("06", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "AM"));
            Assert.AreEqual("06", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "AN"));
            Assert.AreEqual("066", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "AMN"));
            Assert.AreEqual("066", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "ANM"));
        }
        [TestMethod]
        public void DM_AfterVowel_7()
        {
            Assert.AreEqual("07", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "AAU"));
            Assert.AreEqual("07", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "AFB"));
            Assert.AreEqual("07", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "APH"));
            Assert.AreEqual("07", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "APF"));
            Assert.AreEqual("07", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "AB"));
            Assert.AreEqual("07", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "AF"));
            Assert.AreEqual("07", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "AP"));
            Assert.AreEqual("07", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "AV"));
            Assert.AreEqual("07", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "AW"));
        }
        [TestMethod]
        public void DM_AfterVowel_8()
        {
            Assert.AreEqual("08", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "AL"));
        }
        [TestMethod]
        public void DM_AfterVowel_9()
        {
            Assert.AreEqual("09", Phonetics.LongPhonetic(DAITCHMOKOTOFF, "AR"));
        }
        #endregion

    }
}
