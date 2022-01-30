using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingBook
{
    internal class Program
    {
        private class Result
        {
            /*
             * Complete the 'pageCount' function below.
             *
             * The function is expected to return an INTEGER.
             * The function accepts following parameters:
             *  1. INTEGER n
             *  2. INTEGER p
             */

            public static int pageCount(int n, int p)
            {
                var minpage = 0;
                if (n % 2 == 0)
                {
                    minpage = Math.Min((p / 2), (n - p + 1) / 2);
                }
                else
                {
                    minpage = Math.Min((p / 2), (n - p) / 2);
                }

                return minpage;
            }
        }

        private class Solution
        {
            public static void Main(string[] args)
            {
                int n = Convert.ToInt32(Console.ReadLine().Trim());

                int p = Convert.ToInt32(Console.ReadLine().Trim());

                int result = Result.pageCount(n, p);

                Console.WriteLine(result);
            }
        }
    }
}