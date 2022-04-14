using System;

namespace Human_Readable_Time
{
    internal class Program
    {
        public static string GetReadableTime(int seconds)
        {
            if (seconds > 359999 ) seconds = 359999;
            
            var time = TimeSpan.FromSeconds(seconds);
            string godz;
            string min;
            string sek;

            if (time.TotalHours < 10)
            { 
                godz = "0" + (int)time.TotalHours;
                
            }
            else
            {
                godz = ((int)(time.TotalHours)).ToString();
            }
            if (time.Minutes < 10)
            { 
                min = "0" + time.Minutes;
            }
            else
            {
                min = time.Minutes.ToString();
            }
            if (time.Seconds < 10)
            { 
                sek = "0" + time.Seconds;
            }
            else
            {
                sek = time.Seconds.ToString();
            }
            return String.Format("{0}:{1}:{2}", godz, min, sek);
        }
        
        public static void Main(string[] args)
        {
            var result = GetReadableTime(5);
            Console.WriteLine(result);
        }
    }
}