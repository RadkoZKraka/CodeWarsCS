using System;
using System.Runtime.ConstrainedExecution;

namespace Multiples_of_3_or_5
{
    internal class Program
    {
        //https://www.codewars.com/kata/514b92a657cdc65150000006
        public static int Solution(int value)
        {
            var suma = 0;
            // Magic Happens
            if (value<0)
            {
                return 0;
            }

            for ( var i = value - 1; i > 0; i--)
            {
                if (i % 3 == 0)
                {
                    suma = suma + i;
                }
                else if (i % 5 == 0)
                {
                    suma = suma + i;
                }
            }

            return suma;
        }
        
        public static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbe hehe: ");
            var i = Convert.ToInt32(Console.ReadLine());
            var wynik = Solution(i);
            Console.WriteLine(wynik);
        }
    }
}