using System;
using System.Collections.Generic;
using System.Linq;

namespace Playground
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(NbYear(1500, 5, 100, 5000));
        }

        private static int NbYear(int p0, double percent, int aug, int p)
        {
            double result;
            var years = 0;
            do
            {
                result = p0 * (1 + percent/100);
                result += aug;
                if (result >= p)
                {
                    return 0;
                }

                years += 1;
            } while (result <= p);
            return years;
        }

        private static int[] DeleteNth(int[] arr, int x)
        {
            var intList = new List<int>();
            foreach (var i in arr)
            {
                if (intList.Count(y => y == i) >= x)
                {
                    continue;
                }
                intList.Add(i);
            }

            return intList.ToArray();
        }
        public static string AreYouPlayingBanjo(string name)
        {
            if (Char.ToLower(name[0]) == 'r')
            {
                return name + " plays banjo";
            }

            return name + " does not play banjo";
        }
        public static string AbbrevName(string name)
        {
            return Char.ToUpper(name.Split()[0][0]) + "." + Char.ToUpper(name.Split()[1][0]);
        }
        public static string Longest (string s1, string s2)
        {
            return String.Join("",s1.Union(s2).ToArray().OrderBy(x => x));
        }
        public static int find_it(int[] seq)
        {
            foreach (var i in seq)
            {
                if (seq.Count(x => x == i) % 2 != 0)
                {
                    return i;
                }
            }

            return -1;
        }
        public static bool Solution(string str, string ending)
        {
            if (String.IsNullOrEmpty(str))
            {
                return false;
            }
            if (str.EndsWith(ending)) return true;
            return false;
        }
        public static string OddOrEven(int[] array)
        {
            var l = array.Sum();

            return l % 2 == 0 ? "even" : "odd";
        }

        public static int SumTwoSmallestNumbers(int[] numbers)
        {
            var min = numbers.Min();
            numbers = numbers.Where(x => x != min).ToArray();
            var min2 = numbers.Min();
            return min + min2;
        }

        public static int FindSmallestInt(int[] args) => args.Min();
        

        public static string GetMiddle(string s)
        {
            var length = s.Length;
            if (length % 2 == 0)
            {
                return String.Join("", s[length / 2 - 1], s[length / 2]);
            }

            return s[length / 2].ToString();
        }

        public static int PositiveSum(int[] arr)
        {
            return arr.Where(t => t >= 0).Sum();
        }

        //https://www.codewars.com/kata/5583090cbe83f4fd8c000051
        public static long[] Digitize(long n)
        {
            var res = new long[n.ToString().Length];
            var arr = n.ToString().Select(Convert.ToInt64).ToArray();
            for (int i = 0; i < arr.Length; i++)
            {
                res[i] = Convert.ToInt64(arr[i]);
            }

            return res.Reverse().ToArray();
        }


        public static bool Xo(string input)
        {
            var z = input.Where(x => x == 'x' || x == 'X');
            var p = input.Where(x => x == 'o' || x == 'O');
            if (z.Count() != p.Count())
            {
                return false;
            }

            return true;
        }
        public static bool IsSquare(int n)
        {
            var res = Math.Sqrt(n);
            if (Math.Abs(Math.Ceiling(res) - Math.Floor(res)) < 0.1)
            {
                return true;
            }

            return false;
            //Your code goes here!
        }
        public static int StringToNumber(String str) => Convert.ToInt32(str);
        
        public static bool ValidatePin(string pin)
        {
            return true;
        }
        
        public static int СenturyFromYear(int year)
        {
            int mil = year / 100;
            if (year%mil == 0)
            {
                return mil;
            }
            return mil+1;
        }

        public static string BoolToWord(bool word) => word ? "Yes" : "No";

        public int GetSum(int a, int b) => a == b ? a : a + b;
        
        public static string FindNeedle(object[] haystack) => "found the needle at position " + Array.IndexOf(haystack, "needle");
        
        public static string Solution(string str) => String.Join("",str.ToArray().Reverse());
        
        //https://www.codewars.com/kata/54e6533c92449cc251001667/train/csharp
        public static string UniqueInOrder<T>(IEnumerable<T> iterable)
        {
            var enumerable = iterable as T[] ?? iterable.ToArray();
            if (!enumerable.Any()) return "";
            
            
            var first = (char)(object)enumerable.ToArray()[0];
            List<char> res = new List<char> {first};

            foreach (var item in enumerable.Skip(1))
            {
                if (item.Equals(first)) continue;
                first = (char)(object)item;
                res.Add(first);
            }

            return String.Join("",res);
        }
        
        public static int SquareSum(int[] n)
        {
            var sum = 0;
            if (n.Length == 0)
            {
                return 0;
            }
            foreach (var i in n)
            {
                sum = sum + i * i;
            }

            return sum;
        }
        public static int Paperwork(int n, int m)
        {
            if (n < 0 || m < 0)
            {
                return 0;
            }

            return n * m;
            //#Happy Coding! ^_^
        }
        public static int SumMix(object[] x)
        {
            if (x.Length == 0)
            {
                return 0;
            }
            var sum = 0;
            foreach (var i in x)
            {
                sum += Convert.ToInt32(i);
            }

            return sum;
        }
        public static string ReverseWords(string str)
        {
            if (String.IsNullOrEmpty(str))
            {
                return "";
            }

            var words = str.Split();
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = String.Join("",words[i].Reverse());
            }

            return String.Join(" ", words);
        }
        public static string AddBinary(int a, int b)
        {
            // if (a == 0 || b == 0)
            // {
            //     return "";
            // }
            return Convert.ToString(a + b, 2);
        }
        public static string RepeatStr(int n, string s)
        {
            string result = "";
            for (int i = 0; i < n; i++)
            {
                result += s;
            }
            return result;
        }
        public static object FirstNonConsecutive(int[] arr)
        {
            for (int j = 0; j < arr.Length; j++)
            {
                if (arr[j] != arr[j - 1])
                {
                    return arr[j];
                }
            }
            return null;
        }
        public static int Sum(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            Array.Sort(numbers);
            var result = numbers.Skip(1).Take(numbers.Length - 1);
            return result.Sum();
        }
        public static bool is_divide_by(int number, int a, int b)
        {
            if (number%a == 0 && number%b == 0)
            {
                return true;
            }

            return false;
        }
        public static string[] StringToArray(string str)
        {
            // code code code
            if(String.IsNullOrEmpty(str))
            {
                return string.Empty.Split();
            }
            return str.Split();
        }
        public static string NoSpace(string input)
        {
            //Code it!
            return String.Join("",input.Split());
        }  
        public static int CountSmileys(string[] smileys)
        {
            var num = 0;
            for (int i = 0; i < smileys.Length; i++)
            {
                var sm = String.Join("",smileys[i].Skip(i).Take(3));
                if (sm[0] == ';' || sm[0] == ':' && sm[1] == '-' || sm[1] == '~' && sm[2] == ')' || sm[2] == 'D')
                {
                    num += 1;
                }
            }

            return num;
        }
        public static string ExpandedForm(long num)
        {
            var number = num.ToString();
            string[] numbers = new string[number.Length];
            for (int i = 0; i < number.Length; i++)
            {
                numbers[i] = number[i] + new string('0', number.Length - i - 1);
            }
            
            return String.Join(" + ", numbers.Where(x => !x.StartsWith("0")));
        }
        public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
        {
            return listOfItems.Where(x => x is Int32).Cast<int>();
        }
        public static int FindEvenIndex(int[] arr)
        {
            if (arr.Length == 0 || arr[0] == 0)
            {
                return 0;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (Convert.ToInt32(arr.Sum()) == 0)
                {
                    return 0;
                }

                if (i == 0) continue;
                var first = arr.Take(i).Sum();
                var second = arr.Skip(i + 1).Sum();
                if (first == second)
                {
                    return i;
                }
            }

            return -1;
        }
        //https://www.codewars.com/kata/5502c9e7b3216ec63c0001aa/train/csharp
        public static IEnumerable<string> OpenOrSenior(int[][] data)
        {
            var result = new string[data.Length];
            for (int i = 0; i < data.Length; i++)
            {
                var first = data[i][0];
                var second = data[i][1];
                if (first >= 55 && second > 7)
                {
                    result[i] = "Senior";
                    continue;
                }

                result[i] = "Open";
            }

            return result;
        }
    }
}