using System;
using System.Collections.Generic;
using System.Text;

namespace ParseToRoman
{
    public class RomanParser
    {
        public static string Parse(int number)
        {
            if (number <= 0)
                return "Invalid number";

            StringBuilder output = new StringBuilder();
            Dictionary<int, string> numeralsToRoman = new Dictionary<int, string>();

            numeralsToRoman.Add(1000, "M");
            numeralsToRoman.Add(900, "CM");
            numeralsToRoman.Add(500, "D");
            numeralsToRoman.Add(400, "CD");
            numeralsToRoman.Add(100, "C");
            numeralsToRoman.Add(90, "XC");
            numeralsToRoman.Add(50, "L");
            numeralsToRoman.Add(40, "XL");
            numeralsToRoman.Add(10, "X");
            numeralsToRoman.Add(9, "IX");
            numeralsToRoman.Add(5, "V");
            numeralsToRoman.Add(4, "IV");
            numeralsToRoman.Add(1, "I");
            
            foreach (var item in numeralsToRoman)
            {
                if (number >= item.Key)
                {
                    int quotient = number / item.Key;
                    for (int i = 0; i < quotient; i++)
                        output.Append(item.Value);

                    number = number % item.Key;
                }
            }

            return output.ToString();
        }
    }
}
