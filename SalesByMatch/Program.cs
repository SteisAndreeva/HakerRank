using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesByMatch
{
    internal class Program
    {
        private class Result
        {
            /*
             * Complete the 'sockMerchant' function below.
             *
             * The function is expected to return an INTEGER.
             * The function accepts following parameters:
             *  1. INTEGER n
             *  2. INTEGER_ARRAY ar
             */

            public static int sockMerchant(int n, List<int> ar)
            {
                var colors = new Dictionary<int, int>();
                int pairs = 0;

                foreach (var num in ar)
                {
                    if (!colors.ContainsKey(num))
                    {
                        colors[num] = ar.FindAll(x => x == num).Count;
                        Console.WriteLine(colors[num]);
                        pairs += colors[num] / 2;
                    }
                }
                return pairs;
            }
        }

        internal class Solution
        {
            public static void Main(string[] args)
            {
                int n = Convert.ToInt32(Console.ReadLine().Trim());

                List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();

                int result = Result.sockMerchant(n, ar);

                Console.WriteLine(result); ;
            }
        }
    }
}