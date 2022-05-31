using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Break_camelCase
{
    internal class Program
    {
        //https://www.codewars.com/kata/5208f99aee097e6552000148/train/csharp
        public static void Main(string[] args)
        {
            Console.WriteLine(BreakCamelCase("siemaNero"));
        }
        public static string BreakCamelCase(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return "";
            }
            string[] split =  Regex.Split(str, @"(?<!^)(?=[A-Z])");

            return String.Join(" ",split);
            // complete the function
        }
    }
}