using System.Collections.Generic;

namespace Playing_with_digits
{
    internal class Program
    {
        public static void Main(string[] args)
        {
        }

        public static int digPow(int n, int p)
        {
            List<int> dig = new List<int>();
            int l = n.ToString().Length - 1;
            for (int i = 0; i < l; i++)
            {
                dig.Add(n/l);
                
            }
            // dig.Add();
            return 0;
        }
    }
}