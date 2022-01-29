using System.Text;
using System;
using System.Security.Cryptography.X509Certificates;
using Console = System.Console;

internal class Result
{
    /*
     * Complete the 'flippingBits' function below.
     *
     * The function is expected to return a LONG_INTEGER.
     * The function accepts LONG_INTEGER n as parameter.
     */

    public static long flippingBits(long n)
    {
        var binary = Convert.ToString(n, 2);
        var flipedBinary = new StringBuilder();
        foreach (var item in binary)
        {
            if (item == '0')
            {
                flipedBinary.Append(1);
            }
            else
            {
                flipedBinary.Append(0);
            }
        }

        var flippedStr = flipedBinary.ToString().PadLeft(32, '1');
        var res = Convert.ToInt64(flippedStr, 2);

        return res;
    }
}

internal class Solution
{
    public static void Main(string[] args)
    {
        int q = Convert.ToInt32(Console.ReadLine().Trim());

        for (int qItr = 0; qItr < q; qItr++)
        {
            long n = Convert.ToInt64(Console.ReadLine().Trim());

            long result = Result.flippingBits(n);

            Console.WriteLine(result);
        }
    }
}