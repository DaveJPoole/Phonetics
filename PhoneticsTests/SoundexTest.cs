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
        public void ZeroLengthStringTest()
        {
            Assert.AreEqual("", Phonetics.LongPhonetic(0, ""));
            Assert.AreEqual("", Phonetics.LongPhonetic(1, ""));
            Assert.AreEqual("", Phonetics.LongPhonetic(99, ""));
        }
        [TestMethod]
        public void NullStringTest()
        {
            Assert.AreEqual("", Phonetics.LongPhonetic(0, null));
            Assert.AreEqual("", Phonetics.LongPhonetic(1, null));
            Assert.AreEqual("", Phonetics.LongPhonetic(99, null));
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
#region Supporting utility function tests
        [TestMethod]
        public void TestDoubleReplacements()
        {
            char[] a = new char[] { 'C', 'J', 'X' };
            GeneralPhonetics bp = new GeneralPhonetics("Jedox");
            bp.TwoCharacterReplacements=a;
            bp.Iterate();
            Assert.AreEqual(7, bp.GetOutputLength());
            bp.Dispose();
        }
        //        [TestMethod]
//        public void AllRefinedSoundexAlphabeticsTest()
//        {
//            int TotalLength = 0;
//            for (int i = Convert.ToInt32('A'); i <= Convert.ToInt32('Z'); i++)
//            {
//                TotalLength += Phonetics.LongPhonetic(1, "A" + Convert.ToChar(i)).ToString().Length;
//            }
//            Assert.AreEqual(44, TotalLength);
//        }
//        [TestMethod]
//        public void FindArrayInitialTest()
//        {
//            char[] anArray={'A','B'};
//            Assert.AreEqual(0, Phonetics.ArrayMatchFromPosition(0, null, null));
//            Assert.AreEqual(0, Phonetics.ArrayMatchFromPosition(0, null, anArray));
//            Assert.AreEqual(0, Phonetics.ArrayMatchFromPosition(0, anArray, null));
//            Assert.AreEqual(2, Phonetics.ArrayMatchFromPosition(0, anArray, anArray));
            
//        }
//        [TestMethod]
//        public void FindArrayTest()
//        {
//            char[] inputArray = { 'M', 'A', 'C','D','O','N','A','L','D',' ','S','M','A','C','K' };
//            char[] arrayToFind = { 'M', 'A', 'C','D' };

//            Assert.AreEqual(4, Phonetics.ArrayMatchFromPosition(0, inputArray, arrayToFind));
//            Assert.AreEqual(3, Phonetics.ArrayMatchFromPosition(11, inputArray, arrayToFind));
//            Assert.AreEqual(0, Phonetics.ArrayMatchFromPosition(12, inputArray, arrayToFind));
//        }
//        [TestMethod]
//        public void FindArrayTooLong()
//        {
//            char[] inputArray = { 'M', 'A', 'C', 'D', 'O', 'N', 'A', 'L', 'D', ' ', 'S', 'M', 'A', 'C', 'K' };
//            char[] arrayToFind = { 'K', ' ' };
//            Assert.AreEqual(0, Phonetics.ArrayMatchFromPosition( - 1, inputArray, arrayToFind));
//            Assert.AreEqual(1, Phonetics.ArrayMatchFromPosition(inputArray.Length - 1, inputArray, arrayToFind));
//            Assert.AreEqual(0, Phonetics.ArrayMatchFromPosition(inputArray.Length + 1, inputArray, arrayToFind));

//        }
//        [TestMethod]
//        public void ReplaceArrayInitialTest()
//        {
//            int x=0,y=x;
//            char[] inputArray = { 'A', 'B' };
//            char[] outputArray = { 'A', 'B' };
//            char[] arrayToFind = { 'A' };
//            char[] arrayToReplace = { 'C' };
//            Phonetics.ArrayReplaceFromPosition(ref x, ref y, inputArray, outputArray, null, null);
//            CollectionAssert.AreEqual(inputArray, outputArray);
//            Phonetics.ArrayReplaceFromPosition(ref x, ref y, inputArray, outputArray, null, arrayToReplace);
//            CollectionAssert.AreEqual(inputArray, outputArray);
//            Phonetics.ArrayReplaceFromPosition(ref x, ref y, inputArray, outputArray, arrayToFind, null);
//            CollectionAssert.AreEqual(inputArray, outputArray);
//           Phonetics.ArrayReplaceFromPosition(ref x, ref y, inputArray, outputArray, arrayToFind, arrayToReplace);
//           CollectionAssert.AreEqual(new char[] { 'C', 'B' }, outputArray);
//        }
//        [TestMethod]
//        public void ReplaceArrayTwoLetterTest()
//        {
//            int validCharacterPosition = 0, currentCharacterPosition = validCharacterPosition;
//            char[] inputArray = { 'P', 'H', 'I', 'L', 'I', 'P', ' ', 'R', 'A', 'P', 'H', 'A', 'E', 'L' };
//            char[] testArray = { 'F', 'H', 'I', 'L', 'I', 'P', ' ', 'R', 'A', 'P', 'H', 'A', 'E', 'L' };
//            char[] outputArray = (char[])inputArray.Clone();

//            char[]arrayToFind={'P','H'};
//            char[]arrayToReplace={'F'};
            

//            Phonetics.ArrayReplaceFromPosition(ref validCharacterPosition, ref currentCharacterPosition, inputArray, outputArray, arrayToFind, arrayToReplace);
//            Assert.AreEqual(1, validCharacterPosition);
//            Assert.AreEqual(2, currentCharacterPosition);
//            CollectionAssert.AreEqual(testArray, outputArray);

//            currentCharacterPosition = 9;
//            validCharacterPosition = 9;
//            inputArray = new char[] {'P', 'H', 'I', 'L', 'I', 'P', ' ', 'R', 'A', 'P', 'H', 'A', 'E', 'L' };
//            outputArray = (char[])inputArray.Clone();
//            testArray = new char[]{ 'P', 'H', 'I', 'L', 'I', 'P', ' ', 'R', 'A', 'F', 'H', 'A', 'E', 'L' };
//            Phonetics.ArrayReplaceFromPosition(ref validCharacterPosition, ref currentCharacterPosition, inputArray, outputArray, arrayToFind, arrayToReplace);
//            Assert.AreEqual(10, validCharacterPosition);
//            Assert.AreEqual(11, currentCharacterPosition);
//            CollectionAssert.AreEqual(testArray, outputArray);
//        }
        #endregion

    }
}
