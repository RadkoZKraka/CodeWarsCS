using System;
using System.Collections.Generic;
using System.Linq;

namespace My_BEDMAS_Approved_Calculator
{
    internal class Program
    {
        public static void Main(string[] args)
        {
        }
        public static double calculate(string s)
        {
            var sParsed = s.Replace(" ", String.Empty);
            var list = new List<string>();
            var parent = sParsed.Count(x => x.ToString() == "(");
            if (parent > 0)
            {
                var location = sParsed.LastIndexOf("(");
                list.Add(sParsed.Substring(location,3));
                //    ((5*4/2)-(2+(5+9))+4)-6
            }
            
            return 0;
        }
    }
}