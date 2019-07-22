using System;

namespace Leetspeak.Models
{
    public class LeetspeakTranslator
    {
        public string Translate(string word)
        {
            return word.Replace('E', 'e').Replace ('e', '3');
        }
    }
}