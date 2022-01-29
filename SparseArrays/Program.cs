using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SparseArrays
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int stringsCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<string> strings = new List<string>();

            for (int i = 0; i < stringsCount; i++)
            {
                string stringsItem = Console.ReadLine();
                strings.Add(stringsItem);
            }

            int queriesCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<string> queries = new List<string>();

            for (int i = 0; i < queriesCount; i++)
            {
                string queriesItem = Console.ReadLine();
                queries.Add(queriesItem);
            }

            List<int> res = Result.matchingStrings(strings, queries);

            textWriter.WriteLine(String.Join("\n", res));

            textWriter.Flush();
            textWriter.Close();
        }

        private class Result
        {
            /*
             * Complete the 'matchingStrings' function below.
             *
             * The function is expected to return an INTEGER_ARRAY.
             * The function accepts following parameters:
             *  1. STRING_ARRAY strings
             *  2. STRING_ARRAY queries
             */

            public static List<int> matchingStrings(List<string> strings, List<string> queries)
            {
                var matches = new List<int>();

                foreach (var item in queries)
                {
                    var isElement = false;
                    var element = 0;

                    foreach (var str in strings)
                    {
                        if (str == item)
                        {
                            element++;
                            isElement = true;
                        }
                    }

                    if (isElement)
                    {
                        matches.Add(element);
                    }
                    else
                    {
                        matches.Add(0);
                    }
                }
                return matches;
            }
        }
    }
}