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
        [TestMethod]
        public void Base_FindArrayWithinArray()
        {
            char[] arrayToFind = { 'M', 'A', 'C', 'D' };
            GeneralPhonetics gp = new GeneralPhonetics("Macdonald Smack");
            Assert.AreEqual(4, gp.ArrayMatchFromPosition(0, arrayToFind));
            Assert.AreEqual(3, gp.ArrayMatchFromPosition(11, arrayToFind));
            Assert.AreEqual(0, gp.ArrayMatchFromPosition(12, arrayToFind));

            gp.Dispose();

        }
        [TestMethod]
        public void Base_InvalidInputFindWordEnd()
        {
            GeneralPhonetics gp = new GeneralPhonetics("Macdonald Smack");
            gp.GetWordEnd(-1);
            Assert.AreEqual(8, gp.WordEndPosition);
            gp.Dispose();


            gp = new GeneralPhonetics("Macdonald Smack");
            gp.GetWordEnd(int.MaxValue);
            Assert.AreEqual(14, gp.WordEndPosition);
            gp.Dispose();

        }
        [TestMethod]
        public void Base_FirstFindWordEnd()
        {
            GeneralPhonetics gp = new GeneralPhonetics("Macdonald Smack");
            gp.GetWordEnd(0);
            Assert.AreEqual(8, gp.WordEndPosition);
            gp.Dispose();


            gp = new GeneralPhonetics("Macdonald Smack"); 
            gp.GetWordEnd(2);
            Assert.AreEqual(8, gp.WordEndPosition);
            gp.Dispose();

        }
        [TestMethod]
        public void Base_LastFindWordEnd()
        {
            GeneralPhonetics gp = new GeneralPhonetics("Macdonald Smack");
            gp.GetWordEnd(10);
            Assert.AreEqual(14, gp.WordEndPosition);
            gp.Dispose();

        }

        [TestMethod]
        public void Base_BeyondLastWordFindWordEnd()
        {
            GeneralPhonetics gp = new GeneralPhonetics("Macdonald Smack 1234567890");
            gp.GetWordEnd(20);
            Assert.AreEqual(14, gp.WordEndPosition);
            gp.Dispose();

        }
        [TestMethod]
        public void Base_NoWordFindWordEnd()
        {
            GeneralPhonetics gp = new GeneralPhonetics("----");
            gp.GetWordEnd(2);
            Assert.AreEqual(0, gp.WordEndPosition);
            gp.Dispose();

        }
        [TestMethod]
        public void Base_SpaceWordFindWordEnd()
        {
            GeneralPhonetics gp = new GeneralPhonetics("Macdonald Smack");
            gp.GetWordEnd(9);
            Assert.AreEqual(8, gp.WordEndPosition);
            gp.Dispose();

        }
        #endregion

    }
}