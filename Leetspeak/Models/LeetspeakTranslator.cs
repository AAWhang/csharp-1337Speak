using System;

namespace Leetspeak.Models
{
    public class LeetspeakTranslator
    {
        public string Translate(string word)
        {
            string[] wordArr = word.Split(' ');
            for (int i = 0; i < wordArr.Length; i++)
                {  
                    char[] charArr = wordArr[i].ToCharArray();
                    for (int j = 1; j < charArr.Length; j++)
                    {
                        if (charArr[j] == 's') 
                        {
                            charArr[j] = 'z';
                        }
                    wordArr[i] = string.Join("", charArr);
                    }
                }
            word = string.Join(" ", wordArr);
            return word
                .Replace('E', 'e')
                .Replace ('e', '3')
                .Replace('O','o')
                .Replace('o','0')
                .Replace('T','t')
                .Replace('t','7')
                .Replace('L','1');
            
        }
    }
}