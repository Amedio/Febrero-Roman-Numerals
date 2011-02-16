using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Febrero_Roman_Numerals;

namespace TestRomanNumbers
{
    [TestFixture()]
    public class UnitTest
    {
        [Test]
        public void TestConvertToRoman()
        {

            string input = "1";
            string expected = "I";
            string result = RomanNumerals.ConvertToRoman(input);
            Assert.AreEqual(expected, result);

            Console.WriteLine(String.Format("Test correct, input: {0}; result: {1}; expected: {2};", input, result, expected));

            input = "3";
            expected = "III";
            result = RomanNumerals.ConvertToRoman(input);
            Assert.AreEqual(expected, result);

            Console.WriteLine(String.Format("Test correct, input: {0}; result: {1}; expected: {2};", input, result, expected));

            input = "4";
            expected = "IV";
            result = RomanNumerals.ConvertToRoman(input);
            Assert.AreEqual(expected, result);

            Console.WriteLine(String.Format("Test correct, input: {0}; result: {1}; expected: {2};", input, result, expected));

            input = "5";
            expected = "V";
            result = RomanNumerals.ConvertToRoman(input);
            Assert.AreEqual(expected, result);

            Console.WriteLine(String.Format("Test correct, input: {0}; result: {1}; expected: {2};", input, result, expected));

            input = "7";
            expected = "VII";
            result = RomanNumerals.ConvertToRoman(input);
            Assert.AreEqual(expected, result);

            Console.WriteLine(String.Format("Test correct, input: {0}; result: {1}; expected: {2};", input, result, expected));

            input = "9";
            expected = "IX";
            result = RomanNumerals.ConvertToRoman(input);
            Assert.AreEqual(expected, result);

            Console.WriteLine(String.Format("Test correct, input: {0}; result: {1}; expected: {2};", input, result, expected));

            input = "10";
            expected = "X";
            result = RomanNumerals.ConvertToRoman(input);
            Assert.AreEqual(expected, result);

            Console.WriteLine(String.Format("Test correct, input: {0}; result: {1}; expected: {2};", input, result, expected));

            input = "15";
            expected = "XV";
            result = RomanNumerals.ConvertToRoman(input);
            Assert.AreEqual(expected, result);

            Console.WriteLine(String.Format("Test correct, input: {0}; result: {1}; expected: {2};", input, result, expected));


            input = "19";
            expected = "XIX";
            result = RomanNumerals.ConvertToRoman(input);
            Assert.AreEqual(expected, result);

            Console.WriteLine(String.Format("Test correct, input: {0}; result: {1}; expected: {2};", input, result, expected));

            input = "40";
            expected = "XL";
            result = RomanNumerals.ConvertToRoman(input);
            Assert.AreEqual(expected, result);

            Console.WriteLine(String.Format("Test correct, input: {0}; result: {1}; expected: {2};", input, result, expected));

            input = "99";
            expected = "XCIX";
            result = RomanNumerals.ConvertToRoman(input);
            Assert.AreEqual(expected, result);

            Console.WriteLine(String.Format("Test correct, input: {0}; result: {1}; expected: {2};", input, result, expected));

            input = "500";
            expected = "D";
            result = RomanNumerals.ConvertToRoman(input);
            Assert.AreEqual(expected, result);

            Console.WriteLine(String.Format("Test correct, input: {0}; result: {1}; expected: {2};", input, result, expected));

            input = "505";
            expected = "DV";
            result = RomanNumerals.ConvertToRoman(input);
            Assert.AreEqual(expected, result);

            Console.WriteLine(String.Format("Test correct, input: {0}; result: {1}; expected: {2};", input, result, expected));

            input = "999";
            expected = "CMXCIX";
            result = RomanNumerals.ConvertToRoman(input);
            Assert.AreEqual(expected, result);

            Console.WriteLine(String.Format("Test correct, input: {0}; result: {1}; expected: {2};", input, result, expected));
        }
    }
}
