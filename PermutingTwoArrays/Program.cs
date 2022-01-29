using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermutingTwoArrays
{
    internal class Program
    {
        private class Result
        {
            /*
             * Complete the 'twoArrays' function below.
             *
             * The function is expected to return a STRING.
             * The function accepts following parameters:
             *  1. INTEGER k
             *  2. INTEGER_ARRAY A
             *  3. INTEGER_ARRAY B
             */

            public static string twoArrays(int k, List<int> A, List<int> B)
            {
                var permut = "YES";
                var min = new List<int>();

                for (int i = 0; i <= A.Count - 1; i++)
                {
                    if (A[i] < k)
                    {
                        min.Add(k - A[i]);
                    }
                }

                foreach (var item in min)
                {
                    var howmany = min.FindAll(x => x == item);
                    if (howmany.Count > 0)
                    {
                        var exist = B.FindAll(x => x >= item);
                        if (howmany.Count > exist.Count)
                        {
                            permut = "NO";
                        }
                    }
                }
                return permut;
            }
        }

        private class Solution
        {
            public static void Main(string[] args)
            {
                int q = Convert.ToInt32(Console.ReadLine().Trim());

                for (int qItr = 0; qItr < q; qItr++)
                {
                    string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

                    int n = Convert.ToInt32(firstMultipleInput[0]);

                    int k = Convert.ToInt32(firstMultipleInput[1]);

                    List<int> A = Console.ReadLine().TrimEnd().Split(' ').ToList()
                        .Select(ATemp => Convert.ToInt32(ATemp)).ToList();

                    List<int> B = Console.ReadLine().TrimEnd().Split(' ').ToList()
                        .Select(BTemp => Convert.ToInt32(BTemp)).ToList();

                    string result = Result.twoArrays(k, A, B);

                    Console.WriteLine(result);
                }
            }
        }
    }
}