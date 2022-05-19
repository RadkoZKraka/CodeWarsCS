using System;
using System.Collections.Generic;
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

        public static int FindSmallestInt(int[] args) => args.Min();
        

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
        public static bool IsSquare(int n)
        {
            var res = Math.Sqrt(n);
            if (Math.Ceiling(res) == Math.Floor(res))
            {
                return true;
            }

            return false;
            //Your code goes here!
        }
        public static int StringToNumber(String str) => Convert.ToInt32(str);
        
        public static bool ValidatePin(string pin)
        {
            return true || false;
        }
        
        public static int СenturyFromYear(int year)
        {
            int mil = year / 100;
            if (year%mil == 0)
            {
                return mil;
            }
            return mil+1;
        }

        public static string boolToWord(bool word) => word ? "Yes" : "No";

        public int GetSum(int a, int b) => a == b ? a : a + b;
        
        public static string FindNeedle(object[] haystack) => "found the needle at position " + Array.IndexOf(haystack, "needle");
        
        public static string Solution(string str) => String.Join("",str.ToArray().Reverse());
        
        //https://www.codewars.com/kata/54e6533c92449cc251001667/train/csharp
        public static string UniqueInOrder<T>(IEnumerable<T> iterable)
        {
            
            if (iterable == null || !iterable.Any()) return "";
            
            
            var first = (char)(object)iterable.ToArray()[0];
            List<char> res = new List<char>();
            res.Add(first);

            foreach (var item in iterable.Skip(1))
            {
                if (item.Equals(first)) continue;
                first = (char)(object)item;
                res.Add(first);
            }

            return String.Join("",res);
        }
        
        public static int SquareSum(int[] n)
        {
            var sum = 0;
            if (n.Length == 0)
            {
                return 0;
            }
            foreach (var i in n)
            {
                sum = sum + i * i;
            }

            return sum;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine(UniqueInOrder("test"));
        }
    }
}