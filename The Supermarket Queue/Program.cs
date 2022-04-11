using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace The_Supermarket_Queue
{
    internal class Program
    {
        //https://www.codewars.com/kata/57b06f90e298a7b53d000a86
        public static long QueueTime(int[] customers, int n)
        {
            List<int> checkouts = new List<int>();

            for (int i = 0; i < n; i++)
            {
                checkouts.Add(0);
            }

            for (int i = 0; i < customers.Length; i++)
            {
                checkouts[checkouts.IndexOf(checkouts.Min())] = checkouts.Min() + customers[i];
            }
            
            return checkouts.Max();
        }
        
        public static void Main(string[] args)
        {
            Console.Write("Podaj ilość kolejek: ");
            var queues = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj ilość klientów: ");
            var clients = Convert.ToInt32(Console.ReadLine());
            int[] queueTest = new int[clients];
            for (int i = 0; i < clients; i++)
            {
                Console.WriteLine($"Wpisz czas czekania w kolejce dla klienta {0}: ", i);
                queueTest[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Podaj zdanie drugie: ");
            Console.WriteLine(QueueTime(queueTest, clients).ToString());
        }
    }
}