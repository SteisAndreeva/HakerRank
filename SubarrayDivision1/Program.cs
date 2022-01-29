using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubarrayDivision1
{
    internal class Program
    {
        private class Result

        {
            /*
             * Complete the 'birthday' function below.
             *
             * The function is expected to return an INTEGER.
             * The function accepts following parameters:
             *  1. INTEGER_ARRAY s
             *  2. INTEGER d
             *  3. INTEGER m
             */

            public static int birthday(List<int> s, int d, int m)
            {
                var ways = 0;
                for (int i = 0; i <= s.Count - m; i++)
                {
                    var sum = 0;
                    for (int j = i; j <= i + m - 1; j++)
                    {
                        sum += s[j];
                    }

                    Console.WriteLine(sum);
                    if (sum == d)
                    {
                        ways += 1;
                    }
                }
                return ways;
            }
        }

        private class Solution
        {
            public static void Main(string[] args)
            {
                int n = Convert.ToInt32(Console.ReadLine().Trim());

                List<int> s = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(sTemp => Convert.ToInt32(sTemp)).ToList();

                string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

                int d = Convert.ToInt32(firstMultipleInput[0]);

                int m = Convert.ToInt32(firstMultipleInput[1]);

                int result = Result.birthday(s, d, m);

                Console.WriteLine(result);
            }
        }
    }
}