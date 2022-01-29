using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace CountingSort1
{
    internal class Program
    {
        private class Result
        {
            /*
             * Complete the 'countingSort' function below.
             *
             * The function is expected to return an INTEGER_ARRAY.
             * The function accepts INTEGER_ARRAY arr as parameter.
             */

            public static List<int> countingSort(List<int> arr)
            {
                var res = new List<int>();
                var elements = arr.Count;

                for (int i = 0; i < 100; i++)
                {
                    var count = 0;
                    if (arr.Contains(i))
                    {
                        arr.RemoveAll(x => x == i);
                        count = elements - arr.Count;
                        elements = arr.Count;
                    }
                    res.Add(count);
                }

                return res;
            }
        }

        private class Solution
        {
            public static void Main(string[] args)
            {
                int n = Convert.ToInt32(Console.ReadLine().Trim());

                List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

                List<int> result = Result.countingSort(arr);

                Console.WriteLine(String.Join(" ", result));
            }
        }
    }
}