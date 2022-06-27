using System;
using System.Collections.Generic;
using System.Linq;

namespace Simple_Fun_159_Middle_Permutation
{
    internal class Program
    {
        //https://www.codewars.com/kata/58ad317d1541651a740000c5/train/csharp
        public static void Main(string[] args)
        {
            MiddlePermutation("siemanero");
            
        }
        public static void MiddlePermutation(string s)
        {
            var sArr = s.ToArray();
            Permutation(sArr);
            Console.WriteLine(sArr);
            


            return ;
        }

        public static void Permutation(char[] list)
        {
            var maxDepth = list.Length - 1;
            Permutation(list,0,maxDepth);
        }
        public static void Permutation(char[] list, int recursionDepth, int maxDepth)
        {
            if (recursionDepth == maxDepth)
            {
                return;
            }
            for (int i = recursionDepth; i <= maxDepth; i++)
            {
                Swap(ref list[recursionDepth], ref list[i]);
                Permutation(list,recursionDepth+1,maxDepth);
                Swap(ref list[recursionDepth], ref list[i]);
            }

        }

        public static void Swap(ref char a, ref char b)
        {
            (a, b) = (b, a);
        }
    }
}