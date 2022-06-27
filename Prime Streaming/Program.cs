using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Prime_Streaming
{
    public class Program
    {
        // https://www.codewars.com/kata/5519a584a73e70fa570005f5/train/csharp
        public static void Main(string[] args)
        {
            var time = new Stopwatch();
            time.Start();
            var res = GeneratePrimes(1_000_000_000);
            Console.WriteLine(res.Count);
            time.Stop();
            Console.WriteLine(time.ElapsedMilliseconds);
        }
        
        public static IEnumerable<int> Stream()
        {
            List<int> primes = new List<int>();
            primes.Add(2);
            int nextPrime = 3;
            var n = 1000000;
            while (primes.Count < n)
            {
                int sqrt = (int)Math.Sqrt(nextPrime);
                bool isPrime = true;
                for (int i = 0; (int)primes[i] <= sqrt; i++)
                {
                    if (nextPrime % primes[i] != 0) continue;
                    isPrime = false;
                    break;
                }
                if (isPrime)
                {
                    primes.Add(nextPrime);
                }
                nextPrime += 2;
            }
            return primes;
        }
        public static List<int> GeneratePrimes(int n) {
            var r = from i in Enumerable.Range(2, n - 1).AsParallel()
                where Enumerable.Range(1, (int)Math.Sqrt(i)).All(j => j == 1 || i % j != 0)
                select i;
            var res = r.ToArray();
            Array.Sort(res);
            return res.ToList();
        }
    }
}