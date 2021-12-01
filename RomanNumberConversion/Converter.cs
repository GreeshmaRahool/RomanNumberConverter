using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RomanNumberConversion
{
    public static class Converter
    {
      public static string arabicToRoman(int arabic)
        {
            if (arabic < 1 || arabic > 3999)
            {
                return String.Empty;
            }

            string roman = "";
            int[] numerals = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            string[] symbols = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
            int i = 0;
            while (arabic > 0)
            {
                while (arabic >= numerals[i])
                {
                    arabic -= numerals[i];
                    roman += symbols[i];
                }
                i++;
            }
            return roman;
        }

        public static int romanToArabic(string roman)
        {

            int arabic = 0;
            int[] numerals = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            string[] symbols = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
            int i = 0;
            while (roman.Length > 0)
            {
                while (roman.StartsWith(symbols[i]))
                {
                    roman = roman.Substring(symbols[i].Length);
                    arabic += numerals[i];
                }
                i++;
            }

            return arabic;
        }

        }
    }


