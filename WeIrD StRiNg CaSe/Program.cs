using System;
using System.Linq;

namespace WeIrD_StRiNg_CaSe
{
    internal class Program
    {
        public static string ToWeirdCase(string s)
        {
            var words = s.Split(' ');
            var slowo = "";

            foreach (var word in words)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        slowo += word[i].ToString().ToUpper();
                    }
                    else
                    {
                        slowo += word[i].ToString().ToLower();
                    }
                }

                words[Array.IndexOf(words, word)] = slowo;
                slowo = "";
            }

            return String.Join(" ", words);
        }
        
        public static void Main(string[] args)
        {
            Console.Write("Podaj zdanie: ");
            var input = Console.ReadLine();
            Console.WriteLine(ToWeirdCase(input));
        }
    }
}