using System;
using System.Linq;
using System.Text;

namespace CeasarCipher
{
    internal class Program
    {
        private class Result
        {
            /*
             * Complete the 'caesarCipher' function below.
             *
             * The function is expected to return a STRING.
             * The function accepts following parameters:
             *  1. STRING s
             *  2. INTEGER k
             */

            public static string caesarCipher(string s, int k)
            {
                var alfabet = "abcdefghijklmnopqrstuvwxyz";
                var shiftSring = new StringBuilder();
                foreach (var ch in s)
                {
                    if (alfabet.Contains(char.ToLower(ch)))
                    {
                        var index = alfabet.IndexOf(char.ToLower(ch));
                        shiftSring.Append(alfabet.ElementAt((index + k) % 26));
                    }
                    else
                    {
                        shiftSring.Append(ch);
                    }

                    if (Char.IsUpper(ch))
                    {
                        var upperChar = char.ToUpper(shiftSring[shiftSring.Length - 1]);
                        shiftSring.Remove(shiftSring.Length - 1, 1);
                        shiftSring.Append(upperChar);
                    }
                }
                return shiftSring.ToString();
            }
        }

        private class Solution
        {
            public static void Main(string[] args)
            {
                int n = Convert.ToInt32(Console.ReadLine().Trim());

                string s = Console.ReadLine();

                int k = Convert.ToInt32(Console.ReadLine().Trim());

                string result = Result.caesarCipher(s, k);

                Console.WriteLine(result);
            }
        }
    }
}