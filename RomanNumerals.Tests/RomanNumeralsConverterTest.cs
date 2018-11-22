using Xunit;

namespace RomanNumerals.Tests
{
	public class RomanNumeralsConverterTest
	{
        [Theory]
        [InlineData(1, "I")]
        [InlineData(2, "II")]
        [InlineData(3, "III")]
        [InlineData(4, "IV")]
        [InlineData(5, "V")]
        [InlineData(6, "VI")]
        [InlineData(7, "VII")]
        [InlineData(8, "VIII")]
        [InlineData(9, "IX")]
        [InlineData(10, "X")]
        [InlineData(39, "XXXIX")]
        [InlineData(50, "L")]
        [InlineData(100, "C")]
        [InlineData(207, "CCVII")]
        [InlineData(246, "CCXLVI")]
        [InlineData(1066, "MLXVI")]
        [InlineData(1776, "MDCCLXXVI")]
        [InlineData(1954, "MCMLIV")]
        [InlineData(1990, "MCMXC")]
        [InlineData(2014, "MMXIV")]
        [InlineData(2018, "MMXVIII")]
        public void WhenConvertingNumber_ShouldReturnRomanNumeral(int number, string expected)
		{
            var actual = RomanNumeralsConverter.Convert(number);
			Assert.Equal(expected, actual);
		}
	}
}
