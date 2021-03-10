using System;
using System.Collections.Generic;

namespace File
{
    public class Calculator
    {
        public static List<char> delimiters = new List<char>() { ',', '\n' };
        public static double Add(string str)
        {
            if (str == "") return 0;
            var sum = 0;
            ParseStr(ParseForDelimi(str)).ForEach(s => sum += s);
            return sum;
            
        }

        private static List<int> ParseStr(string str)
        {
            var values = new List<int>();
            Array.ForEach(str.Split(delimiters.ToArray()),
                s => {
                    var number = int.Parse(s);
                    if (number < 0) throw new Exception("Negative Value"); 
                    values.Add(int.Parse(s));
                });
            return values;
        }
        private static string ParseForDelimi(string str)
        {
            if (str.StartsWith("//"))
            {
                delimiters.Add(str[2]);
                str = str.Substring(4);
            }
            return str;
        }

    }
}
