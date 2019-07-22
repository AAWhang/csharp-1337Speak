using System;
using Leetspeak.Models;

namespace Leetspeak
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("3n73r w0rdz n00b");
            string userinput = Console.ReadLine();
            LeetspeakTranslator Leetspeak = new LeetspeakTranslator();
            Console.WriteLine(Leetspeak.Translate(userinput));

        }
    }
}