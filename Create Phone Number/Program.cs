using System;
using System.Linq;

namespace Create_Phone_Number
{
    internal class Program
    {
        //Write a function that accepts an array of 10 integers (between 0 and 9), that returns a string of those numbers in the form of a phone number.
        public static void Main(string[] args)
        {
            int[] num = new int[]{1,3,3,2,5,2,1,4,7,6};
            string wynik = CreatePhoneNumber(num);
            Console.WriteLine(wynik);
        }

        public static string CreatePhoneNumber(int[] phone)
        {
            // var result = string.Join(",", ints.Select(x => x.ToString()).ToArray());
            // string phoneNumber = phone.Length.ToString();
            string phoneNumber = "(" + String.Join("", phone.Select( x => x.ToString()).ToArray(), 0, 3) + ") " + String.Join("",  phone.Select( y => y.ToString()).ToArray(), 3, 3) + "-" +
                                 String.Join("",  phone.Select( z => z.ToString()).ToArray(), 6, 4);
            return phoneNumber;
        }
    }
}