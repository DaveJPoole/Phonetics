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
            Assert.AreEqual("D", Phonetics.LongPhonetic(0, "D"));
            Assert.AreEqual("D", Phonetics.LongPhonetic(1, "D"));
            Assert.AreEqual("D", Phonetics.LongPhonetic(99, "D"));
        }
       [TestMethod]
        public void SoundexCharTest()
        {
            Assert.AreEqual("D1", Phonetics.LongPhonetic(0, "Dave"));
            Assert.AreEqual("D2", Phonetics.LongPhonetic(1, "Dave"));
            Assert.AreEqual("D1", Phonetics.LongPhonetic(99, "Dave"));
        }
        [TestMethod]
        public void LetterOneNotAlphaTest()
        {
            Assert.AreEqual("D1", Phonetics.LongPhonetic(0, "12Dave"));
            Assert.AreEqual("D2", Phonetics.LongPhonetic(1, "12Dave"));
            Assert.AreEqual("D1", Phonetics.LongPhonetic(99, "12Dave"));
        }
        [TestMethod]
        public void TwoWordTest()
        {
            Assert.AreEqual("D1 P4", Phonetics.LongPhonetic(0, "Dave Poole"));
            Assert.AreEqual("D2 P7", Phonetics.LongPhonetic(1, "Dave Poole"));
            Assert.AreEqual("D1 P4", Phonetics.LongPhonetic(0, "Dave Poole"));
        }
        [TestMethod]
        public void LlangollenTest()
        {
            Assert.AreEqual("L5245", Phonetics.LongPhonetic(0, "llangollen"));
            Assert.AreEqual("L8478", Phonetics.LongPhonetic(1, "llangollen"));
            Assert.AreEqual("L5245", Phonetics.LongPhonetic(99, "llangollen"));
        }
        [TestMethod]
        public void LlangollenHeritageRailwayTest()
        {
            Assert.AreEqual("L5245 H632 R4", Phonetics.LongPhonetic(0, "llangollen heritage railway"));
            Assert.AreEqual("L8478 H964 R7", Phonetics.LongPhonetic(1, "llangollen heritage railway"));
            Assert.AreEqual("L5245 H632 R4", Phonetics.LongPhonetic(99, "llangollen heritage railway"));
        }
        [TestMethod]
        public void AllAlphabeticsTest()
        {
            int TotalLength = 0;
            for (int i = Convert.ToInt32('A'); i <= Convert.ToInt32('Z'); i++)
            {
                TotalLength += Phonetics.LongPhonetic(0, "A" + Convert.ToChar(i)).ToString().Length;
            }
            Assert.AreEqual(44, TotalLength);
        }
#endregion

    }
}
