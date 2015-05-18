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
                value = Int32.Parse(str);
            }

            return value;
        }
    }
}
