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
                var strs = str.Split(',');
                value = strs.Select(x => Int32.Parse(x)).Sum();
            }

            return value;
        }
    }
}
