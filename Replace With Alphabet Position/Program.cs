using System;

namespace Replace_With_Alphabet_Position
{
    internal class Program
    {
        //https://www.codewars.com/kata/546f922b54af40e1e90001da
        public static string AlphabetPosition(string text)
        {
            string results = "";
            foreach (var letter in text)
            {
                if (char.IsLetter(letter))
                {
                    results = results + (char.ToUpper(letter) - 64) + " ";
                }
            }
            return results.TrimEnd(' ');
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Podaj zdanie: ");
            string s = Console.ReadLine();
            string wynik = AlphabetPosition(s);
            Console.WriteLine(wynik);
        }
    }
}