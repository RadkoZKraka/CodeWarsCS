using System;
using System.Collections.Generic;
using System.Linq;

namespace Mexican_Wave
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            wave("hello");
        }
        public static List<string> wave(string str)
        {
            if (String.IsNullOrEmpty(str))
            {
                return new List<string>();
            }
            var res = new List<string>();
            var arr = str.ToArray();
            for (int i = 0; i < arr.Length; i++)
            {
                if (Char.IsWhiteSpace(arr[i]))
                {
                    continue;
                }
                arr[i] = Char.ToUpper(arr[i]);
                res.Add(String.Join("",arr));
                arr[i] = Char.ToLower(arr[i]);
            }
            return res;
        }
    }
}