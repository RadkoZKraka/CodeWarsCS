using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace Directions_Reduction
{
    internal class Program
    {
        //https://www.codewars.com/kata/550f22f4d758534c1100025a/train/csharp
        public static string[] dirReduc(string[] arr) 
        {
            var pairVer = new string[]{"NORTH","SOUTH"};
            var pairHor = new string[]{"WEST","EAST"};
            var result = new string [] {};
            for (int i = 0; i < arr.Length; i++)
            {
                if ((arr[i] == pairHor[0] && arr[i + 1] == pairHor[1]) || (arr[i] == pairHor[1] && arr[i + 1] == pairHor[0]) || (arr[i] == pairVer[0] && arr[i + 1] == pairVer[1]) || (arr[i] == pairVer[1] && arr[i + 1] == pairVer[0]))
                {
                    arr = arr.Where(x => x == arr[i] && x == arr[i + 1]).ToArray();
                }
            }

            return arr;
        }
        public static void Main(string[] args)
        {
            var res = dirReduc(new[] {"NORTH", "SOUTH", "SOUTH", "EAST", "WEST", "NORTH", "WEST"});
            Console.WriteLine(res);
        }
    }
}