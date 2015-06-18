using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace PhoneticsTests
{
    [TestClass]
    public class BaseTests
    {
        [TestMethod]
        public void Base_InputEqualOutputTest()
        {
            BasePhonetics bp = new BasePhonetics("Dave Poole");
            bp.Iterate();
            Assert.AreEqual("DAVE POOLE", bp.ReadOutput());
            bp.Dispose();
        }

        [TestMethod]
        public void Base_CaseSensitiveTest()
        {
            BasePhonetics bp = new BasePhonetics("Dave Poole", false);
            bp.Iterate();
            Assert.AreEqual("DAVE POOLE", bp.ReadOutput());
            Assert.AreNotEqual("Dave Poole", bp.ReadOutput());
            bp.Dispose();
        }
        [TestMethod]
        public void ZeroLengthStringTest()
        {
            BasePhonetics bp = new BasePhonetics("", false);
            bp.Iterate();
            Assert.AreEqual("", bp.ReadOutput());
            bp.Dispose();
        }
        [TestMethod]
        public void NullStringTest()
        {
            BasePhonetics bp = new BasePhonetics(null, false);
            bp.Iterate();
            Assert.AreEqual("", bp.ReadOutput());
            bp.Dispose();
        }
 
        #region Supporting utility function tests
        [TestMethod]
        public void TestDoubleReplacements()
        {
            char[] a = new char[] { 'C', 'J', 'X' };
            GeneralPhonetics bp = new GeneralPhonetics("Jedox");
            bp.TwoCharacterReplacements = a;
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