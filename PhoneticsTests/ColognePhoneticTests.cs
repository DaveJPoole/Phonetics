using System;
using System.Data;
using System.Xml;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PhoneticsTests
{
    /// <summary>
    /// Summary description for SoundexTests
    /// </summary>
    [TestClass]
    public class ColognePhoneticTests
    {
        const int COLOGNE_PHONETIC = 6;

        public ColognePhoneticTests()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        #region LongPhonetic() tests
        [TestMethod]
        public void COLOGNE_Brown()
        {
            Assert.AreEqual("2 44 1736", Phonetics.LongPhonetic(COLOGNE_PHONETIC, "The Quick Brown"));
        }
        [TestMethod]
        public void COLOGNE_Vowel()
        {
            Assert.AreEqual("0", Phonetics.LongPhonetic(COLOGNE_PHONETIC, "A"));
            Assert.AreEqual("0", Phonetics.LongPhonetic(COLOGNE_PHONETIC, "E"));
            Assert.AreEqual("0", Phonetics.LongPhonetic(COLOGNE_PHONETIC, "I"));
            Assert.AreEqual("0", Phonetics.LongPhonetic(COLOGNE_PHONETIC, "O"));
            Assert.AreEqual("0", Phonetics.LongPhonetic(COLOGNE_PHONETIC, "U"));
        }
        [TestMethod]
        public void COLOGNE_Letter_A()
        {
            Assert.AreEqual("0767", Phonetics.LongPhonetic(COLOGNE_PHONETIC, "ARMOUR"));
        }
        [TestMethod]
        public void COLOGNE_Letter_B()
        {
            Assert.AreEqual("1", Phonetics.LongPhonetic(COLOGNE_PHONETIC, "B"));
        }
        [TestMethod]
        public void COLOGNE_Letter_C()
        {
            Assert.AreEqual("8", Phonetics.LongPhonetic(COLOGNE_PHONETIC, "C"));
            Assert.AreEqual("4", Phonetics.LongPhonetic(COLOGNE_PHONETIC, "CA"));
            Assert.AreEqual("4", Phonetics.LongPhonetic(COLOGNE_PHONETIC, "CH"));
            Assert.AreEqual("4", Phonetics.LongPhonetic(COLOGNE_PHONETIC, "CK"));
            Assert.AreEqual("4", Phonetics.LongPhonetic(COLOGNE_PHONETIC, "CO"));
            Assert.AreEqual("4", Phonetics.LongPhonetic(COLOGNE_PHONETIC, "CQ"));
            Assert.AreEqual("4", Phonetics.LongPhonetic(COLOGNE_PHONETIC, "CU"));
            Assert.AreEqual("4", Phonetics.LongPhonetic(COLOGNE_PHONETIC, "CX"));
        }
        [TestMethod]
        public void COLOGNE_Letter_D()
        {
            Assert.AreEqual("8", Phonetics.LongPhonetic(COLOGNE_PHONETIC, "DC"));
            Assert.AreEqual("8", Phonetics.LongPhonetic(COLOGNE_PHONETIC, "DS"));
            Assert.AreEqual("8", Phonetics.LongPhonetic(COLOGNE_PHONETIC, "DZ"));
            Assert.AreEqual("2", Phonetics.LongPhonetic(COLOGNE_PHONETIC, "D"));
        }
        [TestMethod]
        public void COLOGNE_Letter_F()
        {
            Assert.AreEqual("3", Phonetics.LongPhonetic(COLOGNE_PHONETIC, "F"));
        }
        [TestMethod]
        public void COLOGNE_Letter_G()
        {
            Assert.AreEqual("4", Phonetics.LongPhonetic(COLOGNE_PHONETIC, "G"));
        }
        [TestMethod]
        public void COLOGNE_Letter_H()
        {
            Assert.AreEqual("127", Phonetics.LongPhonetic(COLOGNE_PHONETIC, "BOTHER"));
            Assert.AreEqual("", Phonetics.LongPhonetic(COLOGNE_PHONETIC, "H"));
            Assert.AreEqual("02", Phonetics.LongPhonetic(COLOGNE_PHONETIC, "HAT"));
        }
        [TestMethod]
        public void COLOGNE_Letter_J()
        {
            Assert.AreEqual("0", Phonetics.LongPhonetic(COLOGNE_PHONETIC, "J"));
        }
        [TestMethod]
        public void COLOGNE_Letter_K()
        {
            Assert.AreEqual("4", Phonetics.LongPhonetic(COLOGNE_PHONETIC, "K"));
        }
        [TestMethod]
        public void COLOGNE_Letter_L()
        {
            Assert.AreEqual("5", Phonetics.LongPhonetic(COLOGNE_PHONETIC, "L"));
        }
        [TestMethod]
        public void COLOGNE_Letter_M()
        {
            Assert.AreEqual("6", Phonetics.LongPhonetic(COLOGNE_PHONETIC, "M"));
        }
        [TestMethod]
        public void COLOGNE_Letter_N()
        {
            Assert.AreEqual("6", Phonetics.LongPhonetic(COLOGNE_PHONETIC, "N"));
        }
        [TestMethod]
        public void COLOGNE_Letter_P()
        {
            Assert.AreEqual("3", Phonetics.LongPhonetic(COLOGNE_PHONETIC, "PH"));
            Assert.AreEqual("1", Phonetics.LongPhonetic(COLOGNE_PHONETIC, "P"));
        }
        [TestMethod]
        public void COLOGNE_Letter_Q()
        {
            Assert.AreEqual("4", Phonetics.LongPhonetic(COLOGNE_PHONETIC, "Q"));
        }
        [TestMethod]
        public void COLOGNE_Letter_R()
        {
            Assert.AreEqual("7", Phonetics.LongPhonetic(COLOGNE_PHONETIC, "R"));
        }
        [TestMethod]
        public void COLOGNE_Letter_S()
        {
            Assert.AreEqual("8", Phonetics.LongPhonetic(COLOGNE_PHONETIC, "S"));
            Assert.AreEqual("8", Phonetics.LongPhonetic(COLOGNE_PHONETIC, "SC"));
        }
        [TestMethod]
        public void COLOGNE_Letter_T()
        {
            Assert.AreEqual("8", Phonetics.LongPhonetic(COLOGNE_PHONETIC, "TC"));
            Assert.AreEqual("8", Phonetics.LongPhonetic(COLOGNE_PHONETIC, "TS"));
            Assert.AreEqual("8", Phonetics.LongPhonetic(COLOGNE_PHONETIC, "TZ"));
            Assert.AreEqual("2", Phonetics.LongPhonetic(COLOGNE_PHONETIC, "T"));
        }
        [TestMethod]
        public void COLOGNE_Letter_V()
        {
            Assert.AreEqual("3", Phonetics.LongPhonetic(COLOGNE_PHONETIC, "V"));
        }
        [TestMethod]
        public void COLOGNE_Letter_W()
        {
            Assert.AreEqual("3", Phonetics.LongPhonetic(COLOGNE_PHONETIC, "W"));
        }
        [TestMethod]
        public void COLOGNE_Letter_X()
        {
            Assert.AreEqual("48", Phonetics.LongPhonetic(COLOGNE_PHONETIC, "X"));
        }
        [TestMethod]
        public void COLOGNE_Letter_Y()
        {
            Assert.AreEqual("0", Phonetics.LongPhonetic(COLOGNE_PHONETIC, "Y"));
        }
        [TestMethod]
        public void COLOGNE_Letter_Z()
        {
            Assert.AreEqual("8", Phonetics.LongPhonetic(COLOGNE_PHONETIC, "Z"));
            Assert.AreEqual("8", Phonetics.LongPhonetic(COLOGNE_PHONETIC, "ZC"));
        }

        #endregion

    }
}
