using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlippingMatrix
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
            int sum = 0;
            var maxindex = arr.Count - 1;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    var a = Math.Max(arr[i][j], arr[maxindex - i][j]);
                    var b = Math.Max(arr[i][maxindex - j], arr[maxindex - i][maxindex - j]);
                    sum += Math.Max(a, b);
                }
            }

            return sum;
        }
    }
}