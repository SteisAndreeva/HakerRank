using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeConversion
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string s = Console.ReadLine();

            string result = Result.timeConversion(s);

            Console.WriteLine(result);
        }

        private class Result
        {
            /*
             * Complete the 'timeConversion' function below.
             *
             * The function is expected to return a STRING.
             * The function accepts STRING s as parameter.
             */

            public static string timeConversion(string s)
            {
                DateTime d = DateTime.Parse(s);
                var res = d.ToString("HH:mm:ss");
                return (res);
            }
        }
    }
}