using System;

namespace Disemvowel_Trolls
{
    internal class Program
    {
        public static string Disemvowel(string str)
        {
            var chars = new string[] {"a","e","i","o","u","A","E","I","O","U"};
            
            foreach (var c in chars)
            {
                str = str.Replace(c, String.Empty);
            }

            return str;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine(Disemvowel("samica"));
        }
    }
}