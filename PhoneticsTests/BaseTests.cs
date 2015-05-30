using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace PhoneticsTests
{
    [TestClass]
    public class BaseTests
    {
        [TestMethod]
        public void Base_Start()
        {
            BasePhonetics bp = new BasePhonetics("Dave Poole", false);
            bp.Iterate();
            Assert.AreEqual("DAVE POOLE", bp.ReadOutput());
            Assert.AreNotEqual("Dave Poole", bp.ReadOutput());
        }
    }
}