using System;

namespace Maximum_subarray_sum
{
    internal class Program
    {
        //https://www.codewars.com/kata/54521e9ec8e60bc4de000d6c
        public static int MaxSequence(int[] arr)
        {
            var max = 0;
            var current = 0;
            for (int j = 0; j < arr.Length; j++)
            {
                current += arr[j];
                if (current < 0)
                {
                    current = 0;
                }
                else if(current > max)
                {
                    max = current;
                }
            }
            return max;
        }
        public static void Main(string[] args)
        {
            var input = new int[0] ;
            Console.WriteLine(MaxSequence(input));
        }
    }
}