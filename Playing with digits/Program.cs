using System;
using System.Linq;

namespace Playing_with_digits
{
    internal class Program
    {
        public static long digPow(int n, int p) {
            // your code
            var intArr = n.ToString().ToArray();
            var sum = 0d;
            var pow = p;
            for (int i = 0; i < intArr.Length; i++)
            {
                sum += Math.Pow(intArr[i] - 48, p);
                p++;
            }

            var test = (int)sum / n;
            if ((int)sum % n != 0)
            {
                return -1;
            }

            return (int)sum / n;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine(digPow(46288,3));
        }
    }
}