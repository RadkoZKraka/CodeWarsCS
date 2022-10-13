using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Playground
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(High("aa b"));
        }
        
        public static int Litres(double time)
        {
            int t = (int)Decimal.Divide(Convert.ToDecimal(time), 0.5M);
            return t;
        }
        
        public static string RemoveExclamationMarks(string s)
        {
            return s.Replace("!", "");
        }
        
        public static int[] Capitals(string word)
        {
            var capList = new List<int>();
            for (int i = 0; i < word.Length; i++)
            {
                if (Char.IsUpper(word[i]))
                {
                    capList.Add(i);
                }
            }

            return capList.ToArray();
        }
        
        public static int StrCount(string str, string letter)
        {
            return str.Count(x => x == letter[0]);
        }

        public static string High(string s)
        {
            var res = s.Split().Select(x => x.ToCharArray().Select(y => (int) y - 96).Sum()).ToArray();

            return s.Split()[Array.IndexOf(res, res.Max())];
        }

        public static bool IsPangram(string str)
        {
            var alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToLower().ToCharArray();
            foreach (var c in alphabet)
            {
                if (!str.ToLower().Contains(c))
                {
                    return false;
                }
            }

            return true;
        }

        public static string FakeBin(string x)
        {
            var sb = new StringBuilder();
            foreach (var c in x)
            {
                if (Convert.ToInt32(x) < 5)
                {
                    sb.Append(0);
                }

                sb.Append(1);
            }

            return sb.ToString();
        }

        public static string Correct(string text)
        {
            var correction = text;
            correction = correction.Replace("5", "S");
            correction = correction.Replace("0", "O");
            correction = correction.Replace("1", "I");
            return correction;
        }

        public static string Likes(string[] name)
        {
            switch (name.Length)
            {
                case 0:
                    return "no one likes this";
                case 1:
                    return $"{name[0]} likes this";
                case 2:
                    return $"{name[0]} and {name[1]} like this";
                case 3:
                    return $"{name[0]}, {name[1]} and {name[2]} like this";
                default:
                    return $"{name[0]}, {name[1]} and {name.Length - 2} others like this";
            }
        }

        public static string HowMuchILoveYou(int nb_petals)
        {
            var response = new[] {"I love you", "a little", "a lot", "passionately", "madly", "not at all"};
            var i = 0;
            for (int j = 0; j < nb_petals; j++)
            {
                if (i > 5)
                {
                    i = 0;
                }

                i++;
            }

            // your code
            return response[i];
        }

        public static string PrinterError(String s)
        {
            var charTable = Enumerable.Range(110, 14).Select(x => (char) x);
            var diff = s.Where(x => charTable.Contains(x));

            return $"{diff.Count()}/{s.Length}";
        }

        public static List<string> Number(List<string> lines)
        {
            for (int i = 0; i < lines.Count; i++)
            {
                lines[i] = lines[i].Insert(0, $"{i + 1}: ");
            }

            //your code goes here
            return lines;
        }

        public static int[] TwoSum(int[] numbers, int target)
        {
            return new int[0];
        }

        public static int GetUnique(IEnumerable<int> numbers)
        {
            var resultD = new Dictionary<int, int>();
            foreach (var i in numbers)
            {
                if (resultD.ContainsKey(i))
                {
                    resultD[i]++;
                    continue;
                }

                resultD.Add(i, 0);
            }

            return resultD.First(x => x.Value == 1).Value;
        }

        public static List<int> RemoveSmallest(List<int> numbers)
        {
            if (!numbers.Any()) return new List<int>();
            var arr = numbers.ToArray();
            var pos = Array.IndexOf(arr, numbers.Min());
            return numbers.Where((x, y) => y != pos).ToList();
        }

        public static object[] RemoveEveryOther(object[] arr)
        {
            return arr.Where((x, i) => i % 2 == 0).ToArray();
        }

        public static string[] TowerBuilder(int nFloors)
        {
            if (nFloors == 1) return new[] {"*"};
            var arr = new string[nFloors];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i - 1] = new string(' ', nFloors - i) + new string('*', UnEven(i + 1)) +
                             new string(' ', nFloors - i);
            }

            return arr;
        }

        public static int UnEven(int n)
        {
            return n * 2 - 1;
        }

        public static bool BetterThanAverage(int[] ClassPoints, int YourPoints)
        {
            var avg = (ClassPoints.Sum() + YourPoints) / (ClassPoints.Length + 1);
            return YourPoints > avg;
        }

        public static string DuplicateEncode(string word)
        {
            if (string.IsNullOrEmpty(word)) return "";
            var result = "";
            foreach (var c in word.ToLower())
            {
                if (word.ToLower().Count(x => x == c) > 1)
                {
                    result += ")";
                }

                result += "(";
            }

            return result;
        }

        public static Dictionary<char, int> Count(string str)
        {
            if (String.IsNullOrEmpty(str))
            {
                return new Dictionary<char, int>();
            }

            var result = new Dictionary<char, int>();
            foreach (var c in str)
            {
                if (result.ContainsKey(c))
                {
                    result[c] += 1;
                    continue;
                }

                result.Add(c, 1);
            }

            return result;
        }

        public static bool Feast(string beast, string dish)
        {
            return beast[0] == dish[0] && beast.Last() == dish.Last();
        }

        public static int OtherAngle(int a, int b)
        {
            return 180 - a - b;
        }

        public static ulong[] productFib(ulong prod)
        {
            ulong x = 0, y = 1, z = 0;
            while (x * y < prod)
            {
                ulong temp = 0;
                temp = x + y;
                x = y;
                y = temp;

                if (x * y == prod)
                {
                    return new ulong[] {x, y, 1};
                }

                z++;
            }

            return new ulong[] {x, y, 0};
        }

        public static double SumArray(double[] array)
        {
            if (array == Array.Empty<double>()) return 0;
            return array.Sum();
        }

        public static int Grow(int[] x)
        {
            var result = 1;
            foreach (var i in x)
            {
                result *= i;
            }

            int prod = x.Aggregate(1, (a, b) => a * b);

            return result;
        }

        public static int binaryArrayToNumber(int[] BinaryArray)
        {
            return Convert.ToInt32(String.Join("", BinaryArray), 2);
        }

        public static string seriesSum(int n)
        {
            var result = 1d;
            if (n == 1) return "1.00";
            if (n == 0) return "0.00";
            for (int i = 4; i - 4 < n; i += 3)
            {
                result += 1 / Convert.ToDouble(i);
            }

            return (Math.Truncate(result * 100) / 100).ToString();
        }

        public static bool IsValidWalk(string[] walk)
        {
            if (walk.Count() != 10) return false;
            if (walk.Count(x => x == "w") == walk.Count(x => x == "e") &&
                walk.Count(x => x == "n") == walk.Count(x => x == "s"))
            {
                return true;
            }

            return false;
        }

        public string dnaToRna(string dna)
        {
            return dna.ToUpper().Replace('T', 'U');
        }

        public static int DescendingOrder(int num)
        {
            return Convert.ToInt32(string.Join("", num.ToString().OrderByDescending(x => x)));
        }

        public static int[] CountPositivesSumNegatives(int[] input)
        {
            if (input == null || input == Array.Empty<int>() || input.Length == 0) return new int[] { };
            var positivesSum = input.Count(x => x > 0);

            var negativesSum = input.Where(x => x < 0).Sum();

            return new[] {positivesSum, negativesSum}; //return an array with count of positives and sum of negatives
        }

        public static long findNb(long m)
        {
            long output = 1l;
            long check = 0l;
            while (check <= m)
            {
                check += (long) Math.Pow(output, 3);
                if (check == m) return output;
                output++;
            }

            return -1;
        }

        public static int bouncingBall(double h, double bounce, double window)
        {
            if (h < 0) return -1;
            if (bounce < 0 || bounce > 1) return -1;
            if (window > h) return -1;
            double ballBounce = h;
            var timesBallBounced = 0;
            while (ballBounce > window)
            {
                timesBallBounced++;
                ballBounce *= bounce;
                if (ballBounce < window) break;
                timesBallBounced++;
            }

            return timesBallBounced;
        }

        private static int NbYear(int p0, double percent, int aug, int p)
        {
            double result;
            var years = 0;
            do
            {
                result = p0 * (1 + percent / 100);
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

        public static string Longest(string s1, string s2)
        {
            return String.Join("", s1.Union(s2).ToArray().OrderBy(x => x));
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
            if (year % mil == 0)
            {
                return mil;
            }

            return mil + 1;
        }

        public static string BoolToWord(bool word) => word ? "Yes" : "No";

        public int GetSum(int a, int b) => a == b ? a : a + b;

        public static string FindNeedle(object[] haystack) =>
            "found the needle at position " + Array.IndexOf(haystack, "needle");

        public static string Solution(string str) => String.Join("", str.ToArray().Reverse());

        //https://www.codewars.com/kata/54e6533c92449cc251001667/train/csharp
        public static string UniqueInOrder<T>(IEnumerable<T> iterable)
        {
            var enumerable = iterable as T[] ?? iterable.ToArray();
            if (!enumerable.Any()) return "";


            var first = (char) (object) enumerable.ToArray()[0];
            List<char> res = new List<char> {first};

            foreach (var item in enumerable.Skip(1))
            {
                if (item.Equals(first)) continue;
                first = (char) (object) item;
                res.Add(first);
            }

            return String.Join("", res);
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
                words[i] = String.Join("", words[i].Reverse());
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
            if (number % a == 0 && number % b == 0)
            {
                return true;
            }

            return false;
        }

        public static string[] StringToArray(string str)
        {
            // code code code
            if (String.IsNullOrEmpty(str))
            {
                return string.Empty.Split();
            }

            return str.Split();
        }

        public static string NoSpace(string input)
        {
            //Code it!
            return String.Join("", input.Split());
        }

        public static int CountSmileys(string[] smileys)
        {
            var num = 0;
            for (int i = 0; i < smileys.Length; i++)
            {
                var sm = String.Join("", smileys[i].Skip(i).Take(3));
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