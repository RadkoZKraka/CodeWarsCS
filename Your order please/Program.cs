using System;
using System.Linq;

namespace Your_order_please
{
    internal class Program
    {
        //https://www.codewars.com/kata/55c45be3b2079eccff00010f
        public static string Order(string sentence)
        {
            string[] words = sentence.Split(' ');
            string wynik = "";
            for (int i = 0; i < words.Length + 1; i++)
            {
                foreach (var word in words)
                {
                    if (word.Contains("" + i))
                    { 
                        wynik = wynik + word + " ";
                    }
                }
            }
            //dzi4n do2b ask3 sik1
            return wynik.TrimEnd(' ');
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("podaj stringa");
            string s = Console.ReadLine();
            string wynik = Order(s);
            Console.WriteLine(wynik);
        }
    }
}