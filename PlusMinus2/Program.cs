using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlusMinus2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            Result.plusMinus(arr);
        }
    }

    internal class Result
    {
        /*
         * Complete the 'plusMinus' function below.
         *
         * The function accepts INTEGER_ARRAY arr as parameter.
         */

        public static void plusMinus(List<int> arr)
        {
            double positive = 0;
            double negative = 0;

            foreach (var item in arr)
            {
                if (item > 0)
                {
                    positive++;
                }
                else if (item < 0)
                {
                    negative++;
                }
            }

            Console.WriteLine("{0:F6}", positive / arr.Count);
            Console.WriteLine("{0:F6}", negative / arr.Count);
            Console.WriteLine("{0:F6}", (arr.Count - positive - negative) / arr.Count);
        }
    }
}