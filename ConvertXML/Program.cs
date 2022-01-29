using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertXML
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int q = Convert.ToInt32(Console.ReadLine().Trim());
            int n = Convert.ToInt32(Console.ReadLine().Trim());
            var arr = new List<List<int>>();

            for (int qItr = 0; qItr < q; qItr++)
            {
                for (int i = 0; i < 2 * n; i++)
                {
                    List<int> element = Console.ReadLine().TrimEnd().Split(' ').ToList()
                        .Select(ATemp => Convert.ToInt32(ATemp)).ToList();
                    arr.Add(element);
                }
            }

            int result = Matrix(arr);

            Console.WriteLine(result);
        }

        public static int Matrix(List<List<int>> arr)
        {
            var n = arr.Count() / 2;
            var sum = 0;

            for (int i = 0; i <= n - 1; i++)
            {
                var sumFirstNum = 0;
                var sumLastNum = 0;

                for (int j = 0; j < n - 1; j++)
                {
                    sumFirstNum += arr[i][j];
                    sumLastNum += arr[i][arr.Count - 1 - j];
                }

                if (sumFirstNum < sumLastNum)
                {
                    arr[i].Reverse();
                }
            }

            foreach (var a in arr)
            {
                Console.WriteLine(string.Join(" ", a));
            }

            return sum;
        }
    }
}