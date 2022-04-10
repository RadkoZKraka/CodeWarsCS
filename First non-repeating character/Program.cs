using System;

namespace First_non_repeating_character
{
    internal class Program
    {
        //https://www.codewars.com/kata/52bc74d4ac05d0945d00054e/train/csharp
        
        //to nie jest zrobione
        public static string FirstNonRepeatingLetter(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                foreach (var j in s)
                {
                
                }
            }
            
            
            return s.Substring(0, 1);
        }
        
        public static void Main(string[] args)
        {
            Console.WriteLine("Podaj stringa: ");
            var input = Console.ReadLine();
            Console.WriteLine("Pierwsza nie powtarzająca się litera to: " + FirstNonRepeatingLetter(input));
        }
    }
}