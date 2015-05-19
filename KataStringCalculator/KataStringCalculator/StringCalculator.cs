using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KataStringCalculator
{
    class StringCalculator
    {
        public static int Add(String str)
        {
            int value = 0;

            if (!String.IsNullOrEmpty(str))
            {
                var delimiter = ",";
                if (str.StartsWith("//"))
                {
                    delimiter = str[2].ToString();
                    str = str.Substring(2, str.Length - 2);
                }

                var strs = str.Split(new string[] { delimiter, "\n" }, StringSplitOptions.RemoveEmptyEntries);

                var ints = strs.Select(x => Int32.Parse(x)).Where(x => x < 1001);
                var negatives = ints.Where(x => x < 0);

                if (negatives.Count() > 0)
                {
                    throw new InvalidOperationException("negatives not allowed " + string.Join(",", negatives));
                }

                value = ints.Sum();
            }

            return value;
        }
    }
}
