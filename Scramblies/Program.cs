using System;
using System.Linq;

namespace Scramblies
{
    internal class Program
    {
        //https://www.codewars.com/kata/55c04b4cc56a697bb0000048
        public static bool Scramble(string str1, string str2)
        {
            var input1 = str1.ToArray();
            var input2 = str2.ToArray();
            var result = true;
            
            foreach (var c in input2)
            {
                if (input1.Contains(c))
                {
                    var loc = Array.IndexOf(input1, c);
                    input1 = input1.Where((x, idx) => idx != loc).ToArray();
                }
                else
                {
                    result = false;
                    break;
                }
            }

            return result;
        }
        public static void Main(string[] args)
        {
            Console.Write("Podaj zdanie pierwsze: ");
            var input1 = Console.ReadLine();
            Console.Write("Podaj zdanie drugie: ");
            var input2 = Console.ReadLine();
            Console.WriteLine(Scramble(input1, input2).ToString());
        }
    }
}