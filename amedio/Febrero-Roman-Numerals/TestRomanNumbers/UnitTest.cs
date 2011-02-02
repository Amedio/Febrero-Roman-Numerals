﻿using System;
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
            string input = "10";
            string expected = "X";
            string result = RomanNumerals.ConvertToRoman(input);
            Assert.AreEqual(expected, result);

            Console.WriteLine(String.Format("Test correct, input: {0}; result: {1}; expected: {2};", input, result, expected));

            input = "1";
            expected = "I";
            result = RomanNumerals.ConvertToRoman(input);
            Assert.AreEqual(expected, result);

            Console.WriteLine(String.Format("Test correct, input: {0}; result: {1}; expected: {2};", input, result, expected));

            input = "7";
            expected = "VII";
            result = RomanNumerals.ConvertToRoman(input);
            Assert.AreEqual(expected, result);
        }
    }
}