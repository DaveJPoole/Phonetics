using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PhoneticsTests
{
    
    [TestClass]
    public class DaitchMokotoffSoundex
    {
#region Word Start Tests
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
        public void DM_Start_1()
        {
            Assert.AreEqual("1", Phonetics.LongPhonetic(3, "IA"));
            Assert.AreEqual("1", Phonetics.LongPhonetic(3, "IE"));
            Assert.AreEqual("1", Phonetics.LongPhonetic(3, "IO"));
            Assert.AreEqual("1", Phonetics.LongPhonetic(3, "IU"));
            Assert.AreEqual("1", Phonetics.LongPhonetic(3, "EU"));
            Assert.AreEqual("1", Phonetics.LongPhonetic(3, "J"));
        }
        [TestMethod]
        public void DM_Start_2()
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
        public void DM_Start_3()
        {
            Assert.AreEqual("3", Phonetics.LongPhonetic(3, "DT"));
            Assert.AreEqual("3", Phonetics.LongPhonetic(3, "TH"));
            Assert.AreEqual("3", Phonetics.LongPhonetic(3, "T"));
            Assert.AreEqual("3", Phonetics.LongPhonetic(3, "D"));
        }
        [TestMethod]
        public void DM_Start_4()
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
        public void DM_Start_5()
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
        public void DM_Start_6()
        {
            Assert.AreEqual("6", Phonetics.LongPhonetic(3, "M"));
            Assert.AreEqual("6", Phonetics.LongPhonetic(3, "N"));
        }
        [TestMethod]
        public void DM_Start_7()
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
        public void DM_Start_8()
        {
            Assert.AreEqual("8", Phonetics.LongPhonetic(3, "L"));
        }
        [TestMethod]
        public void DM_Start_9()
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
#endregion
        #region After Vowel Tests
        [TestMethod]
        public void DM_ActiveSingleTest()
        {
            Assert.AreEqual("0505", Phonetics.LongPhonetic(3, "-AH-AH"));
        }
        [TestMethod]
        public void DM_AfterVowel_Discard()
        {
            Assert.AreEqual("0", Phonetics.LongPhonetic(3, "UIA"));
            Assert.AreEqual("0", Phonetics.LongPhonetic(3, "UIE"));
            Assert.AreEqual("0", Phonetics.LongPhonetic(3, "UIO"));
            Assert.AreEqual("0", Phonetics.LongPhonetic(3, "UIU"));
            Assert.AreEqual("0", Phonetics.LongPhonetic(3, "UUE"));
            Assert.AreEqual("0", Phonetics.LongPhonetic(3, "AA"));
            Assert.AreEqual("0", Phonetics.LongPhonetic(3, "EE"));
            Assert.AreEqual("0", Phonetics.LongPhonetic(3, "II"));
            Assert.AreEqual("0", Phonetics.LongPhonetic(3, "OO"));
            Assert.AreEqual("0", Phonetics.LongPhonetic(3, "UU"));
            Assert.AreEqual("0", Phonetics.LongPhonetic(3, "IY"));
        }

        [TestMethod]
        public void DM_AfterVowel_1()
        {
            Assert.AreEqual("01", Phonetics.LongPhonetic(3, "AAI"));
            Assert.AreEqual("01", Phonetics.LongPhonetic(3, "AAJ"));
            Assert.AreEqual("01", Phonetics.LongPhonetic(3, "AAY"));
            Assert.AreEqual("01", Phonetics.LongPhonetic(3, "AEI"));
            Assert.AreEqual("01", Phonetics.LongPhonetic(3, "AEJ"));
            Assert.AreEqual("01", Phonetics.LongPhonetic(3, "AEU"));
            Assert.AreEqual("01", Phonetics.LongPhonetic(3, "AEY"));
            Assert.AreEqual("01", Phonetics.LongPhonetic(3, "AOI"));
            Assert.AreEqual("01", Phonetics.LongPhonetic(3, "AOJ"));
            Assert.AreEqual("01", Phonetics.LongPhonetic(3, "AOY"));
            Assert.AreEqual("01", Phonetics.LongPhonetic(3, "UUI"));
            Assert.AreEqual("01", Phonetics.LongPhonetic(3, "UUJ"));
            Assert.AreEqual("01", Phonetics.LongPhonetic(3, "UUY"));


        }
        [TestMethod]
        public void DM_AfterVowel_3()
        {
            Assert.AreEqual("03", Phonetics.LongPhonetic(3, "ADT"));
            Assert.AreEqual("03", Phonetics.LongPhonetic(3, "ATH"));
            Assert.AreEqual("03", Phonetics.LongPhonetic(3, "AD"));
            Assert.AreEqual("03", Phonetics.LongPhonetic(3, "AT"));
        }



        [TestMethod]
        public void DM_AfterVowel_4()
        {
            Assert.AreEqual("043", Phonetics.LongPhonetic(3, "ASCHD"));
            Assert.AreEqual("043", Phonetics.LongPhonetic(3, "ASCHT"));
            Assert.AreEqual("043", Phonetics.LongPhonetic(3, "ASHT"));
            Assert.AreEqual("043", Phonetics.LongPhonetic(3, "ASHD"));
            Assert.AreEqual("043", Phonetics.LongPhonetic(3, "ASZD"));
            Assert.AreEqual("043", Phonetics.LongPhonetic(3, "ASZT"));
            Assert.AreEqual("043", Phonetics.LongPhonetic(3, "AST"));

            Assert.AreEqual("04", Phonetics.LongPhonetic(3, "ASC"));
            Assert.AreEqual("04", Phonetics.LongPhonetic(3, "AS"));
            Assert.AreEqual("04", Phonetics.LongPhonetic(3, "AZ"));

            Assert.AreEqual("04", Phonetics.LongPhonetic(3, "ASCHTSCH"));
            Assert.AreEqual("04", Phonetics.LongPhonetic(3, "ASCHTSH"));
            Assert.AreEqual("04", Phonetics.LongPhonetic(3, "ASCHTSH"));
            Assert.AreEqual("04", Phonetics.LongPhonetic(3, "ASCTCH"));
            Assert.AreEqual("04", Phonetics.LongPhonetic(3, "ASTSCH"));
            Assert.AreEqual("04", Phonetics.LongPhonetic(3, "ASHTSH"));
            Assert.AreEqual("04", Phonetics.LongPhonetic(3, "ASHCH"));
            Assert.AreEqual("04", Phonetics.LongPhonetic(3, "ASTCH"));
            Assert.AreEqual("04", Phonetics.LongPhonetic(3, "ASTRS"));
            Assert.AreEqual("04", Phonetics.LongPhonetic(3, "ASTRZ"));
            Assert.AreEqual("04", Phonetics.LongPhonetic(3, "ASTSH"));
            Assert.AreEqual("04", Phonetics.LongPhonetic(3, "ASZCZ"));
            Assert.AreEqual("04", Phonetics.LongPhonetic(3, "ASZCS"));
        }
        
        [TestMethod]
        public void DM_AfterVowel_5()
        {
            Assert.AreEqual("05", Phonetics.LongPhonetic(3, "AH"));
            Assert.AreEqual("05", Phonetics.LongPhonetic(3, "ACH"));
            Assert.AreEqual("05", Phonetics.LongPhonetic(3, "ACK"));
            Assert.AreEqual("05", Phonetics.LongPhonetic(3, "AH"));
            Assert.AreEqual("05", Phonetics.LongPhonetic(3, "AC"));
            Assert.AreEqual("05", Phonetics.LongPhonetic(3, "AG"));
            Assert.AreEqual("05", Phonetics.LongPhonetic(3, "AK"));
            Assert.AreEqual("05", Phonetics.LongPhonetic(3, "AQ"));
            Assert.AreEqual("054", Phonetics.LongPhonetic(3, "AX"));
            Assert.AreEqual("054", Phonetics.LongPhonetic(3, "AKS"));
            Assert.AreEqual("054", Phonetics.LongPhonetic(3, "ACHS"));
        }
        [TestMethod]
        public void DM_AfterVowel_6()
        {
            Assert.AreEqual("06", Phonetics.LongPhonetic(3, "AM"));
            Assert.AreEqual("06", Phonetics.LongPhonetic(3, "AN"));
            Assert.AreEqual("066", Phonetics.LongPhonetic(3, "AMN"));
            Assert.AreEqual("066", Phonetics.LongPhonetic(3, "ANM"));
        }
        [TestMethod]
        public void DM_AfterVowel_7()
        {
            Assert.AreEqual("07", Phonetics.LongPhonetic(3, "AAU"));
            Assert.AreEqual("07", Phonetics.LongPhonetic(3, "AFB"));
            Assert.AreEqual("07", Phonetics.LongPhonetic(3, "APH"));
            Assert.AreEqual("07", Phonetics.LongPhonetic(3, "APF"));
            Assert.AreEqual("07", Phonetics.LongPhonetic(3, "AB"));
            Assert.AreEqual("07", Phonetics.LongPhonetic(3, "AF"));
            Assert.AreEqual("07", Phonetics.LongPhonetic(3, "AP"));
            Assert.AreEqual("07", Phonetics.LongPhonetic(3, "AV"));
            Assert.AreEqual("07", Phonetics.LongPhonetic(3, "AW"));
        }
        [TestMethod]
        public void DM_AfterVowel_8()
        {
            Assert.AreEqual("08", Phonetics.LongPhonetic(3, "AL"));
        }
        [TestMethod]
        public void DM_AfterVowel_9()
        {
            Assert.AreEqual("09", Phonetics.LongPhonetic(3, "AR"));
        }
        #endregion

    }
}
