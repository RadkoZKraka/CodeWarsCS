using System;
using System.Linq;

namespace Create_Phone_Number
{
    internal class Program
    {
        //https://www.codewars.com/kata/525f50e3b73515a6db000b83
        public static void Main(string[] args)
        {
            int[] num = new int[]{1,3,3,2,5,2,1,4,7,6};
            string wynik = CreatePhoneNumber(num);
            Console.WriteLine(wynik);
        }

        public static string CreatePhoneNumber(int[] phone)
        {
            string phoneNumber = "(" + String.Join("", phone.Select( x => x.ToString()).ToArray(), 0, 3) + ") " + String.Join("",  phone.Select( y => y.ToString()).ToArray(), 3, 3) + "-" +
                                 String.Join("",  phone.Select( z => z.ToString()).ToArray(), 6, 4);
            return phoneNumber;
        }
    }
}