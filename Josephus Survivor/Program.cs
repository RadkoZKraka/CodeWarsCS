namespace Josephus_Survivor
{
    internal class Program
    {
        //https://www.codewars.com/kata/555624b601231dc7a400017a
        //nie mój pomysł 
        public static int JosSurvivor(int n, int k) 
        {
            if (n == 1)
                return 1;
            else
                return (JosSurvivor(n - 1, k) + k-1) % n + 1;
        }  
        public static void Main(string[] args)
        {
        }
    }
}