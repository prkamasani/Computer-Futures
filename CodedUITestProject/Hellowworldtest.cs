using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using EvalServiceLibrary;

namespace CodedUITestProject
{
    [TestClass]
    public class Hellowworldtest
    {
        [TestMethod]
        public void Test_Hellowworld()
        {
            EvalService service = new EvalService();
            string stw = service.Hellowworld();
            Assert.AreEqual("Hellowworld", stw);
                }

    }
}
