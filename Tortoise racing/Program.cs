using System;
using System.Collections;

namespace Tortoise_racing
{
    internal class Program
    {
        public static double Race(int v1, int v2, int g) 
        {
            var v3 = v2 - v1;
            double time = ((v3/g)*60)*60;
            
            
            // your code
            return time;
        }
        public static void Main(string[] args)
        {
            //IEquatable<int> test = <(720, 850, 70;
            Console.WriteLine(Race(720, 850, 70));
        }
    }
}