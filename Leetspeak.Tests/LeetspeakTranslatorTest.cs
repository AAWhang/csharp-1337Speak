using Microsoft.VisualStudio.TestTools.UnitTesting;
using Leetspeak.Models;

namespace Leetspeak.Tests
{
    [TestClass]
    public class LeetspeakTranslatorTest
    {
        [TestMethod]
        public void Translate_TurnLowercaseEInto3_3gg()
        {
            LeetspeakTranslator translator = new LeetspeakTranslator();
            Assert.AreEqual("3gg", translator.Translate("egg"));
        }
        [TestMethod]
        public void Translate_TurnUppercaseEInto3_3gg()
        {
            LeetspeakTranslator translator = new LeetspeakTranslator();
            Assert.AreEqual("3gg", translator.Translate("Egg"));
        }
    }
}