using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Simple_Pig_Latin
{
    internal class Program
    {
        public static string PigIt(string str)
        {
            str = Regex.Replace(str, @"[^\w\s]", "");

            var words = Regex.Split(str, @"\W");

            try
            {
                for (int i = 0; i < words.Length; i++)
                {
                    var word = words[i];
                    words[i] = String.Join("", word.Skip(1)) + word[0] + "ay";
                }
            }
            catch (Exception e)
            {
                return "Ty jebana kurwo";
            }

            return String.Join(" ", words);
        }

        public static void Main(string[] args)
        {
            Console.WriteLine(PigIt("Hello world!"));
        }
    }
}