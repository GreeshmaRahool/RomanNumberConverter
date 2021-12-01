using System;
using Xunit;

namespace RomanNumberConversion.Test
{
    public class ConverterTests
    {
        [Fact]
        public void ArabicToRomanTest()
        {
            Assert.Equal("I", Converter.arabicToRoman(1));
            Assert.Equal("III",Converter.arabicToRoman(3));
            Assert.Equal("IX",Converter.arabicToRoman(9));
            Assert.Equal("XLIX", Converter.arabicToRoman(49));
            Assert.Equal("DCCLXXXIX", Converter.arabicToRoman(789));
            Assert.Equal("MLXVI",Converter.arabicToRoman(1066));
            Assert.Equal("MCMLXXXIX",Converter.arabicToRoman(1989));
            Assert.Equal("XL", Converter.arabicToRoman(40));
            Assert.Equal("XC", Converter.arabicToRoman(90));
            Assert.Equal("CD", Converter.arabicToRoman(400));

        }
        [Fact]
        public void RomanToArabicTest()
        {
            Assert.Equal(1, Converter.romanToArabic("I"));
            Assert.Equal(3, Converter.romanToArabic("III"));
            Assert.Equal(9, Converter.romanToArabic("IX"));
            Assert.Equal(49, Converter.romanToArabic("XLIX"));
            Assert.Equal(789, Converter.romanToArabic("DCCLXXXIX"));
            Assert.Equal(1066, Converter.romanToArabic("MLXVI"));
            Assert.Equal(1989, Converter.romanToArabic("MCMLXXXIX"));
            Assert.Equal(40, Converter.romanToArabic("XL"));
            Assert.Equal(90, Converter.romanToArabic("XC"));
            Assert.Equal(400, Converter.romanToArabic("CD"));
        }

    }
}
