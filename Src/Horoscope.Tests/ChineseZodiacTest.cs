using System;
using Xunit;

namespace Horoscope.Tests
{
    public class ChineseZodiacTest
    {
        [Theory]
        [InlineData(2018, "Dog")]
        [InlineData(1952, "Dragon")]
        [InlineData(1969, "Rooster")]
        [InlineData(1903, "Rabbit")]
        public void GetChineseZodiacAnimal_Test(int year, string zodiacSign)
        {
            var symbol = ChineseZodiac.GetChineseZodiacAnimal(new DateTime(year, 4, 1));
            Assert.Equal(zodiacSign, symbol.ZodiacEnglishTranslation);
        }

        [Fact]
        public void GetAllZodiacSigns_Test()
        {
            var symbols = ChineseZodiac.GetAllZodiacSigns();
            Assert.Equal(12, symbols.Count);
        }

        [Fact]
        public void GetZodiacSign_Dog_Test()
        {
            var symbols = ChineseZodiac.GetZodiacSign(ChineseZodiacSigns.Dog);
            Assert.Equal("xū", symbols.ZodiacName);
            Assert.Equal("Dog", symbols.ZodiacEnglishTranslation);
            Assert.Equal("Dog people are loyal & can always keep a secret. Sometimes they worry too much.", symbols.ZodiacPersonality);
        }

        [Fact]
        public void GetZodiacSign_Capricorn_Test()
        {
            var symbols = ChineseZodiac.GetZodiacSign(ChineseZodiacSigns.Monkey);
            Assert.Equal("shēn", symbols.ZodiacName);
            Assert.Equal("Monkey", symbols.ZodiacEnglishTranslation);
            Assert.Equal("Monkey people are very funny. They can always make others laugh & are good problem solvers.", symbols.ZodiacPersonality);
        }
    }
}
