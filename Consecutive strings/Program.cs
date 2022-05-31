using System;
using System.Collections.Generic;
using System.Linq;

namespace Consecutive_strings
{
    internal class Program
    {
        //https://www.codewars.com/kata/56a5d994ac971f1ac500003e/train/csharp
        public static void Main(string[] args)
        {
            var words = new []{"zone", "abigail", "theta", "form", "libe", "zas", "theta", "abigail"};
            LongestConsec(words, 2);
        }
        public static string LongestConsec(string[] strarr, int k)
        {
                if (strarr == null || strarr.Length == 0  || strarr.Length < k)
                {
                    return "";
                }
            var num = 0;
            var prev = 0;
            IEnumerable<string> res = new []{""};

            for (int i = 0; i < strarr.Length; i++)
            {
                var slice = strarr.Skip(i).Take(k);
                foreach (var s in slice)
                {
                     num += s.Length;
                }

                if (prev < num)
                {
                    prev = num;
                    res = slice;
                }

                num = 0;
            }
            return String.Join("",res.ToArray());
        }
    }
}