using System;
using System.Linq;

namespace Playground
{
    internal class Program
    {
        public static string OddOrEven(int[] array)
        {
            var l = 0;
            for (int i = 0; i < array.Length; i++)
            {
                l += array[i];
            }

            return l % 2 == 0 ? "even" : "odd";
        }

        public static int sumTwoSmallestNumbers(int[] numbers)
        {
            var min = numbers.Min();
            numbers = numbers.Where(x => x != min).ToArray();
            var min2 = numbers.Min();
            return min + min2;
        }

        public static int FindSmallestInt(int[] args)
        {
            return args.Min();
        }

        public static string GetMiddle(string s)
        {
            var length = s.Length;
            if (length % 2 == 0)
            {
                return String.Join("", s[length / 2 - 1], s[length / 2]);
            }

            return s[length / 2].ToString();
        }

        public static int PositiveSum(int[] arr)
        {
            var sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    continue;
                }

                sum += arr[i];
            }

            return sum;
        }

        //https://www.codewars.com/kata/5583090cbe83f4fd8c000051
        public static long[] Digitize(long n)
        {
            var res = new long[n.ToString().Length];
            var arr = n.ToString().Select(Convert.ToInt64).ToArray();
            for (int i = 0; i < arr.Length; i++)
            {
                res[i] = Convert.ToInt64(arr[i]);
            }

            return res.Reverse().ToArray();
        }


        public static bool XO(string input)
        {
            var z = input.Where(x => x == 'x' || x == 'X');
            var p = input.Where(x => x == 'o' || x == 'O');
            if (z.Count() != p.Count())
            {
                return false;
            }

            return true;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine(XO("xoo"));
        }
    }
}