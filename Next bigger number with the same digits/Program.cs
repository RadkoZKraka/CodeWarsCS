using System;
using System.Linq;

namespace Next_bigger_number_with_the_same_digits
{
    internal class Program
    {
        //https://www.codewars.com/kata/55983863da40caa2c900004e
        public static long NextBiggerNumber(long n)
        {
            long[] arr = n.ToString().ToArray().Select(Convert.ToInt64).ToArray();
            return arr.First();
        }
        public static void Main(string[] args)
        {
        }
    }
}