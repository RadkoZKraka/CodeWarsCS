using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Array.diff
{
    internal class Program
    {
        //https://www.codewars.com/kata/523f5d21c841566fde000009
        public static int[] ArrayDiff(int[] a, int[] b)
        {
            for (int i = 0; i < b.Length; i++)
            {
                a = a.Where(x => x != b[i]).ToArray();
                if (b.Length == 1) break;
            }

            return a;
        }
        
        public static void Main(string[] args)
        {
            var wynik = ArrayDiff(new int[] {1, 2, 2}, new int[] {1});
            Console.WriteLine(wynik.ToString());
        }
    }
}