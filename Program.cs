using System;
using System.Collections.Generic;

namespace Kordamine
{
    class Program
    {
        static void Main()
        {
            //Variant 5 Ü1
            var vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };
            int vows = 0;

            Console.WriteLine("Enter a Sentence");
            string sentence = Console.ReadLine().ToLower();
            int len = sentence.Length;

            for (int i = 0; i < sentence.Length; i++)
            {
                if (vowels.Contains(sentence[i]))
                {
                    vows++;
                }
            }
            float total = ((float)((decimal)vows / len * 100));
            
            Console.WriteLine("Your total percentage of vowels is: {0}", total);

        }
    }
}
