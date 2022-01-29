using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMaxSum
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<Int64> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt64(arrTemp)).ToList();

            Result.miniMaxSum(arr);
        }
    }

    internal class Result
    {
        /*
         * Complete the 'miniMaxSum' function below.
         *
         * The function accepts INTEGER_ARRAY arr as parameter.
         */

        public static void miniMaxSum(List<Int64> arr)
        {
            var indexMin = arr.IndexOf(arr.Min());
            var indexMax = arr.IndexOf(arr.Max());

            Console.Write($"{arr.Sum() - arr[indexMax]} {(arr.Sum() - arr[indexMin])}");
        }
    }
}