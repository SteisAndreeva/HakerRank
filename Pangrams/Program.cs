using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pangrams
{
    internal class Program
    {
        private class Result
        {
            /*
             * Complete the 'pangrams' function below.
             *
             * The function is expected to return a STRING.
             * The function accepts STRING s as parameter.
             */

            public static string pangrams(string s)
            {
                string alpha = "abcdefghijklmnopqrstuvwxyz";
                var res = "pangram";
                s = s.ToLower();
                foreach (var item in alpha)
                {
                    if (!s.Contains(item))
                    {
                        res = "not pangram";
                        break;
                    }
                }

                return res;
            }
        }

        private class Solution
        {
            public static void Main(string[] args)
            {
                string s = Console.ReadLine();

                string result = Result.pangrams(s);

                Console.WriteLine(result);
            }
        }
    }
}