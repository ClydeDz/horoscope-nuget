using System;
using Xunit;

namespace Horoscope.Tests
{
    public class DateTimeExtensionsTest
    {
        [Theory]
        [InlineData(2, 12, "Aquarius")]
        [InlineData(3, 3, "Pisces")]
        [InlineData(2, 28, "Pisces")]
        [InlineData(10, 23, "Scorpio")]
        public void GetZodiacSign_Test(int month, int day, string zodiacSign)
        {
            var date = new DateTime(1950, month, day);
            var symbol = date.GetZodiacSign();

            Assert.Equal(zodiacSign, symbol.ZodiacName);
        }

        [Theory]
        [InlineData(2018, "Dog")]
        [InlineData(1952, "Dragon")]
        [InlineData(1969, "Rooster")]
        [InlineData(1903, "Rabbit")]
        public void GetChineseZodiacSign_Test(int year, string zodiacSign)
        {
            var date = new DateTime(year, 4, 1);
            var symbol = date.GetChineseZodiacSign();

            Assert.Equal(zodiacSign, symbol.ZodiacEnglishTranslation);
        }
    }
}
