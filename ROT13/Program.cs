using System;
using System.Linq;

namespace ROT13
{
    internal class Program
    {
        public static string Rot13(string input)
        {
            var chars = input.ToArray();
            var n = 0;
            for (int i = 0; i < chars.Length; i++)
            {
                if (!char.IsLetter(chars[i]))
                {
                    continue;
                }

                if (char.IsLower(chars[i]))
                {
                    n = (int) chars[i] + 13;
                    if (n > 122)
                    {
                        n = n - 26;
                        chars[i] = (char) n;
                    }
                    chars[i] = (char) n;

                }

                if (char.IsUpper(chars[i]))
                {
                    n = (int) chars[i] + 13;
                    if (n > 90)
                    {
                        n = n - 26;
                        chars[i] = (char) n;
                    }
                    chars[i] = (char) n;
                }
            }

            return String.Join("", chars);
            }

            public static void Main(string[] args)
            {
                Console.WriteLine(Rot13("EBG13 rknzcyr."));
            }
        }
    }
