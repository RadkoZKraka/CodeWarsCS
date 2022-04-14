using System;

namespace Basic_Mathematical_Operations
{
    internal class Program
    {
        public static double basicOp(char operation, double value1, double value2)
        {
            var result = 0d;
            if (operation == '+')
            {
                result = value1 + value2;
            }
            if (operation == '-')
            {
                result = value1 - value2;
            }
            if (operation == '/')
            {
                result = value1 / value2;
            }

            if (operation == '*')
            {
                result = value1 * value2;
            }
           
            return result;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine(basicOp('+',3,4));
        }
    }
}