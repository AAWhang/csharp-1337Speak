using Microsoft.VisualStudio.TestTools.UnitTesting;
using Leetspeak.Models;

namespace Leetspeak.Tests
{
    [TestClass]
    public class LeetspeakTranslatorTest
    {
        [TestMethod]
        public void MethodName_Spec_ExpectedOutput()
        {
            LeetspeakTranslator instanceName = new LeetspeakTranslator();
            Assert.AreEqual(ExpectedOutput, instanceName.MethodName(inputHere));
        }
    }
}