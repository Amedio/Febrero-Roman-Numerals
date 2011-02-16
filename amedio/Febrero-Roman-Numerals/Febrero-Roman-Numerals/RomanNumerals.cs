using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Febrero_Roman_Numerals
{
    public class RomanNumerals
    {
        private struct DecToRomanFormat
        {
            public char number;
            public int position;
            public string romanConversion;
        }

        private const char oneRoman = 'I';
        private const char fiveRoman = 'V';
        private const char tenRoman = 'X';
        private const char fiftyRoman = 'L';
        private const char oneHundredRoman = 'C';
        private const char fiveHundredRoman = 'D';
        private const char oneThousandRoman = 'M';
        private const char fiveThousandRoman = 'P';

        public static string ConvertToRoman(string decimalNumber)
        {
            return ConvertToRomanRec(decimalNumber, decimalNumber.Length);
        }

        private static string ConvertToRomanRec(string decimalNumber, int p)
        {
            if (p != 0)
            {
                char[] strNumber = decimalNumber.ToArray();

                char padding = '-';
                char fivePadding = '-';
                switch (p)
                {
                    case 1:
                        padding = oneRoman;
                        fivePadding = fiveRoman;
                        break;
                    case 2:
                        padding = tenRoman;
                        fivePadding = fiftyRoman;
                        break;
                    case 3:
                        padding = oneHundredRoman;
                        fivePadding = fiveHundredRoman;
                        break;
                    case 4:
                        padding = oneThousandRoman;
                        fivePadding = fiveThousandRoman;
                        break;
                }

                string aux = "";

                string nbr = strNumber[0].ToString();

                if (Convert.ToInt32(nbr) == 4)
                    aux = padding.ToString() + fivePadding.ToString();
                else if (Convert.ToInt32(nbr) == 9)
                    aux = padding.ToString() + ConvertToRoman("1".PadRight(p + 1, '0'));
                else if (Convert.ToInt32(nbr) == 5)
                    aux = fivePadding.ToString();
                else if (9 > Convert.ToInt32(nbr) && Convert.ToInt32(nbr) > 5)
                    aux = fivePadding.ToString() + ConvertToRoman((Convert.ToInt32(nbr) - 5).ToString().PadRight(p, '0'));
                else if (4 > Convert.ToInt32(nbr) && Convert.ToInt32(nbr) >= 1)
                    aux = "".PadRight(Convert.ToInt32(nbr), padding);

                aux += ConvertToRomanRec(decimalNumber.Remove(0, 1), p - 1);

                return aux;
            }
            else
            {
                return "";
            }
        }
    }
}
