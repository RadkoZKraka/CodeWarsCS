using System;

namespace Split_Springs
{
    internal class Program
    {
        // zrobione
        public static void Main(string[] args)
        {
            string input;
            Console.WriteLine("Podaj stringa:");
            input = Console.ReadLine();
            string[] output = Splitter(input);

            for (int i = 0; i < output.Length; i++)
            {
                Console.WriteLine(output[i]);
            }
        }

        public static string[] Splitter(string inp)
        {
            var l = 0;
            if (inp.Length % 2 == 0)
            {
                l = inp.Length;
            }
            else
            {
                l = inp.Length + 1;
                inp = inp + "_";
            }
            string[] Split = new string[l/2];
            int k = 0;
            for (int i = 0; i < l; i = i + 2)
            {
                Split[k] = inp.Substring(0,2);
                inp = inp.Remove(0, 2);
                k++;
            }
            return Split;
        }
    }
}