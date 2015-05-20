using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace KataStringCalculator
{
    class StringCalculator
    {
        public static int Add(String str)
        {
            int value = 0;

            if (!String.IsNullOrEmpty(str))
            {
                List<string> delimiters = ExtractDelimiters(ref str);

                var strs = str.Split(delimiters.ToArray(), StringSplitOptions.RemoveEmptyEntries);

                var ints = strs.Select(x => Int32.Parse(x)).Where(x => x < 1001);

                CheckForNegatives(ints);

                value = ints.Sum();
            }

            return value;
        }

        private static List<string> ExtractDelimiters(ref String str)
        {
            List<string> delimiters = new List<string>();
            delimiters.Add(",");
            delimiters.Add("\n");

            if (str.StartsWith("//"))
            {
                Regex reg = new Regex(@"\[(?<x>.+?)\]+?");
                var matches = reg.Matches(str);
                if (matches.Count > 0)
                {
                    foreach (Match match in matches)
                    {
                        if (match.Success)
                        {
                            delimiters.Add(match.Groups["x"].Value);
                        }
                    }
                }
                else
                {
                    delimiters.Add(str[2].ToString());
                }

                var index = str.IndexOf("\n");
                str = str.Substring(index, str.Length - index);
            }
            return delimiters;
        }

        private static void CheckForNegatives(IEnumerable<int> ints)
        {
            var negatives = ints.Where(x => x < 0);
            if (negatives.Count() > 0)
            {
                throw new InvalidOperationException("negatives not allowed " + string.Join(",", negatives));
            }
        }
    }
}
