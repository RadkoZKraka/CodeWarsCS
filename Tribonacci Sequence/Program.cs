using System;

namespace Tribonacci_Sequence
{
    internal class Program
    {
        public static double[]  Tribonacci(double[] signature, int n)
        {
            // hackonacci me
            double[] results = new double[n];
            if (n < 3)
            {
                if (n == 0)
                {
                    Array.Clear(signature, 0, n);
                }
                else
                {
                    for (int i = 0; i < n; i++)
                    {
                        results[i] = signature[i];
                    }
                }
                return results;
            }
    
            results[0] = signature[0];
            results[1] = signature[1];
            results[2] = signature[2];

            
            
            
            for (int i = 0; i < n - 3; i++)
            {
                results[i + 3] = results[i] + results[i + 1] + results[i + 2];
            }

            return results;
        }

        public static void Main()
        {
            Console.WriteLine("Podaj rozmiar tablicy: ");
            
            int n = Convert.ToInt32(Console.ReadLine());
            double[] tablica = new double[n];
            
            Console.WriteLine("Podaj trzy pierwsze liczby: ");
            
            tablica[0] = Convert.ToInt32(Console.ReadLine());
            tablica[1] = Convert.ToInt32(Console.ReadLine());
            tablica[2] = Convert.ToInt32(Console.ReadLine());

            double[] wynik = Tribonacci(tablica, n);

            for (int i = 0; i < n; i++)
            {
                Console.Write(wynik[i] + " ");
            }
        }
    }
}