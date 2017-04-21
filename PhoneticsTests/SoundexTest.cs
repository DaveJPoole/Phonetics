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
    public class SoundexTests
    {
        const int SOUNDEX = 0;
        const int REFINED_SOUNDEX = 1;
        const int DEFAULT_PHONETIC = 99;

        public SoundexTests()
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
        public void StartUpTest()
        {
            Assert.AreEqual("D", Phonetics.LongPhonetic(SOUNDEX, "D"));
            Assert.AreEqual("D", Phonetics.LongPhonetic(REFINED_SOUNDEX, "D"));
            Assert.AreEqual("D", Phonetics.LongPhonetic(DEFAULT_PHONETIC, "D"));
        }
       [TestMethod]
        public void SoundexCharTest()
        {
            Assert.AreEqual("D1", Phonetics.LongPhonetic(SOUNDEX, "Dave"));
            Assert.AreEqual("D2", Phonetics.LongPhonetic(REFINED_SOUNDEX, "Dave"));
            Assert.AreEqual("D1", Phonetics.LongPhonetic(DEFAULT_PHONETIC, "Dave"));
        }
        [TestMethod]
        public void LetterOneNotAlphaTest()
        {
            Assert.AreEqual("D1", Phonetics.LongPhonetic(SOUNDEX, "12Dave"));
            Assert.AreEqual("D2", Phonetics.LongPhonetic(REFINED_SOUNDEX, "12Dave"));
            Assert.AreEqual("D1", Phonetics.LongPhonetic(DEFAULT_PHONETIC, "12Dave"));
        }
        [TestMethod]
        public void TwoWordTest()
        {
            Assert.AreEqual("D1 P4", Phonetics.LongPhonetic(SOUNDEX, "Dave Poole"));
            Assert.AreEqual("D2 P7", Phonetics.LongPhonetic(REFINED_SOUNDEX, "Dave Poole"));
            Assert.AreEqual("D1 P4", Phonetics.LongPhonetic(SOUNDEX, "Dave Poole"));
        }
        [TestMethod]
        public void LlangollenTest()
        {
            Assert.AreEqual("L5245", Phonetics.LongPhonetic(SOUNDEX, "llangollen"));
            Assert.AreEqual("L8478", Phonetics.LongPhonetic(REFINED_SOUNDEX, "llangollen"));
            Assert.AreEqual("L5245", Phonetics.LongPhonetic(DEFAULT_PHONETIC, "llangollen"));
        }
        [TestMethod]
        public void LlangollenHeritageRailwayTest()
        {
            Assert.AreEqual("L5245 H632 R4", Phonetics.LongPhonetic(SOUNDEX, "llangollen heritage railway"));
            Assert.AreEqual("L8478 H964 R7", Phonetics.LongPhonetic(REFINED_SOUNDEX, "llangollen heritage railway"));
            Assert.AreEqual("L5245 H632 R4", Phonetics.LongPhonetic(DEFAULT_PHONETIC, "llangollen heritage railway"));
        }
        [TestMethod]
        public void AllAlphabeticsTest()
        {
            int TotalLength = 0;
            for (int i = Convert.ToInt32('A'); i <= Convert.ToInt32('Z'); i++)
            {
                TotalLength += Phonetics.LongPhonetic(SOUNDEX, "A" + Convert.ToChar(i)).ToString().Length;
            }
            Assert.AreEqual(44, TotalLength);
        }
#endregion

    }
}
