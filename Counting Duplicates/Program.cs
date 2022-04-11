using System;
using System.Linq;

namespace Counting_Duplicates
{
    internal class Program
    {
        //https://www.codewars.com/kata/54bf1c2cd5b56cc47f0007a1
        public static int DuplicateCount(string str)
        {
            var wynik = 0;
            foreach (var c in str)
            {
                var i = str.Count(ch => ch == c);
                if (i>0)
                {
                    wynik = wynik + i;
                }
            }

            return wynik;
        }
        
        public static void Main(string[] args)
        {   
            Console.WriteLine("Podaj stringa: ");
            var input = Console.ReadLine();
            Console.WriteLine("Ilość duplikatów: " + DuplicateCount(input));
        }
    }
}