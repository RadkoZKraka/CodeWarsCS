using System;
using System.Linq;

namespace Sum_Strings_as_Numbers
{
    internal class Program
    {
        //https://www.codewars.com/kata/5324945e2ece5e1f32000370
        public static string sumStrings(string a, string b)
        {
            var carry = false;
            var result = String.Empty;

            if(a.Length != b.Length)
            {
                var diff = Math.Abs(a.Length - b.Length);

                if(a.Length < b.Length)
                {
                    a = String.Join("", Enumerable.Repeat("0", diff)) + a;
                }
                else
                {
                    b = String.Join("", Enumerable.Repeat("0", diff)) + b;
                }
            }


            for(int i = a.Length-1;i >= 0; i--)
            {
                var augend = Convert.ToInt32(a.Substring(i,1));
                var addend = Convert.ToInt32(b.Substring(i,1));
                var sum = augend + addend;
                sum += (carry ? 1 : 0);
                carry = false;
                if(sum > 9)
                {
                    carry = true;
                    sum -= 10;
                }

                result = sum.ToString() + result;
            }

            if(carry)
            {
                result = "1" + result;
            }
            
            return result.TrimStart('0');
        }
        public static void Main(string[] args)
        {
            Console.WriteLine(sumStrings("145234235324523452345234523452345","2343242423523523423423452345"));
        }
    }
}