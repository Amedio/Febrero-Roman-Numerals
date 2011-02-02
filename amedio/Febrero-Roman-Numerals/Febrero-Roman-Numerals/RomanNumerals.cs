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
            char[] strNumber = decimalNumber.Reverse().ToArray();
            DecToRomanFormat[] conversor = new DecToRomanFormat[strNumber.Length];

            for (int i = 0; i < strNumber.Length; i++)
            {
                char padding = '-';
                char fivePadding = '-';
                switch (i + 1)
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

                conversor[i].number = strNumber[i];
                conversor[i].position = i + 1;
                int number = Convert.ToInt32(conversor[i].number.ToString());
                string tmpRomanConv = (strNumber[i] != '0') ? "".PadLeft(number, padding) : "";

                if (tmpRomanConv.Length == 5)
                {
                    tmpRomanConv = fivePadding.ToString();
                }
                else if (tmpRomanConv.Length == 4)
                {
                    tmpRomanConv = padding.ToString() + fivePadding.ToString();
                }


                conversor[i].romanConversion = tmpRomanConv;
            }

            StringBuilder sb = new StringBuilder();
            foreach (DecToRomanFormat item in conversor.Reverse())
            {
                sb.Append(item.romanConversion);
            }

            return sb.ToString();
        }
    }
}
