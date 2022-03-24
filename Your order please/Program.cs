using System;
using System.Linq;

namespace Your_order_please
{
    internal class Program
    {
        public static string Order(string words)
        {
            string[] order = new string[];
            var punctuation = words.Where(Char.IsPunctuation).Distinct().ToArray();
            var slowa = words.Split().Select(x => x.Trim(punctuation));
            for (int i = 0; i < 9; i++)
            {
                slowa.OrderBy()
            }
        }
        public static void Main(string[] args)
        {
        }
    }
}