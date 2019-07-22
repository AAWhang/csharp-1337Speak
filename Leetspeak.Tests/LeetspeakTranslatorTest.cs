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
        [TestMethod]
        public void Translate_SwapsManyChars_7hequickbr0wn()
        {
            LeetspeakTranslator translator = new LeetspeakTranslator();
            Assert.AreEqual("7h3 sw337 br0wn f0x jumpz 0v3r 7h3 l4zy d0g", translator.Translate("The sweet brown fox jumps over the lazy dog"));
        }        
        [TestMethod]
        public void Translate_UppercaseLto1_1azy()
        {
            LeetspeakTranslator translator = new LeetspeakTranslator();
            Assert.AreEqual("14zy", translator.Translate("Lazy"));
        }
        
    }
}