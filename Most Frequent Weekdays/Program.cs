using System;

namespace Most_Frequent_Weekdays
{
    internal class Program
    {
        //https://www.codewars.com/kata/56eb16655250549e4b0013f4
        public static string[] MostFrequentDays(int year)
        {
            DateTime timeStart = Convert.ToDateTime(year);
            // var day = time.DayOfWeek;
            // TimeSpan duration = year;
            return new string[0];
        }
        public static void Main(string[] args)
        {
            var s = "";
            DateTime timeStart = DateTime.Parse("01/01/" + 2005);

            DateTime time = DateTime.Now;
            var day = time.DayOfWeek;
            Console.WriteLine(timeStart.DayOfWeek);
        }
    }
}