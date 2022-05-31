using System;
using System.Globalization;

namespace Jaden_Casing_Strings
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            
        }
        public static string ToJadenCase(this string phrase)
        {
            if (String.IsNullOrEmpty(phrase))
            {
                return "";
            }
            var words = phrase.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                var word = words[i];
                words[i] = char.ToUpper(word[0]) + word.Substring(1);
            }
            return string.Join(" ", words);
        }
    }
}