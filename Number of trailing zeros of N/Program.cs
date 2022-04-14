namespace Number_of_trailing_zeros_of_N
{
    internal class Program
    {
        //https://www.codewars.com/kata/52f787eb172a8b4ae1000a34
        public static int TrailingZeros(int n)
        {
            if (n < 0)
                return -1;

            int count = 0;
            for (int i = 5; (n / i) > 0; i = i * 5)
            {
                count = count + n / i;
            }

            return count;
        }

        public static void Main(string[] args)
        {
        }
    }
}