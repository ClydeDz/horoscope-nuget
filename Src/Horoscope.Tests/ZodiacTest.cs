using Xunit;
using System;

namespace Horoscope.Tests
{
    public class ZodiacTest
    {
        [Theory]
        [InlineData(2, 12, "Aquarius")]
        [InlineData(3, 3, "Pisces")]
        [InlineData(2, 28, "Pisces")]
        [InlineData(10, 23, "Scorpio")]
        public void GetZodiacSignForDate_Test(int month, int day, string zodiacSign)
        {
            var symbol = Zodiac.GetZodiacSignForDate(new DateTime(1950, month, day));
            Assert.Equal(zodiacSign, symbol.ZodiacName);
        }

        [Fact]
        public void GetAllZodiacSigns_Test()
        {
            var symbols = Zodiac.GetAllZodiacSigns();
            Assert.Equal(12, symbols.Count);
        }

        [Fact]
        public void GetZodiacSign_Pisces_Test()
        {
            var symbols = Zodiac.GetZodiacSign(ZodiacSigns.Pisces);
            Assert.Equal("Pisces", symbols.ZodiacName);
            Assert.Equal("The Fish", symbols.ZodiacEnglishTranslation);
            Assert.Equal("February 19 to March 20", symbols.ZodiacDuration);
        }

        [Fact]
        public void GetZodiacSign_Capricorn_Test()
        {
            var symbols = Zodiac.GetZodiacSign(ZodiacSigns.Capricorn);
            Assert.Equal("Capricorn", symbols.ZodiacName);
            Assert.Equal("The Goat", symbols.ZodiacEnglishTranslation);
            Assert.Equal("December 22 to January 19", symbols.ZodiacDuration);
        }
    }
}
