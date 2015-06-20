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

        [TestMethod]
        public void Base_FindArrayWithinArrayBadPosition()
        {
            char[] arrayToFind = { 'M', 'A', 'C', 'D' };
            GeneralPhonetics gp = new GeneralPhonetics("Macdonald Smack");
            Assert.AreEqual(0, gp.ArrayMatchFromPosition(-1, arrayToFind));
            gp.Dispose();
        }
        [TestMethod]
        public void Base_FindArrayWithinArrayNullArguments()
        {
            char[] arrayToFind = { 'M', 'A', 'C', 'D' };
            GeneralPhonetics gp = new GeneralPhonetics("Macdonald Smack");
            Assert.AreEqual(0, gp.ArrayMatchFromPosition(0, null));
            gp.Dispose();
            gp = new GeneralPhonetics(null);
            Assert.AreEqual(0, gp.ArrayMatchFromPosition(0, arrayToFind));
            gp.Dispose();
        }
        public void Base_FindArrayWithinArray()
        {
            char[] arrayToFind = { 'M', 'A', 'C', 'D' };
            GeneralPhonetics gp = new GeneralPhonetics("Macdonald Smack");
            Assert.AreEqual(4, gp.ArrayMatchFromPosition(0, arrayToFind));
            Assert.AreEqual(3, gp.ArrayMatchFromPosition(11, arrayToFind));
            Assert.AreEqual(0, gp.ArrayMatchFromPosition(12, arrayToFind));

            gp.Dispose();

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