using System;
using System.Collections.Generic;
using System.Linq;

namespace Highest_Rank_Number_in_an_Array
{
    internal class Program
    {
        public static int HighestRank(int[] arr)
        {
            Dictionary<int, int> wynik = new Dictionary<int, int>();
            foreach (var i in arr)
            {
                if (!wynik.ContainsKey(i))
                {
                    wynik.Add(i, arr.Count(ch => ch == i));
                }
            }
            
            
            
            var max = wynik.Aggregate((l , r) => l.Value  > r.Value  ? l : r).Value;
            var list = wynik.Where(x => x.Value == max);
            var max2 = list.Aggregate((l , r) => l.Key  > r.Key  ? l : r).Key;

            return max2;
        }
        
        public static void Main(string[] args)
        {
            var arr = new int[] {6, 9, 10, 8, 11, 10, 7, 7, 10, 3, 6, 3, 3, 3, 7, 10, 5, 11, 11};
            Console.WriteLine(HighestRank(arr)); 
        }
    }
}