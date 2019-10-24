using System;
using System.Linq;
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
        public void GetZodiacSignForDate_Test(int year, string zodiacSign)
        {
            var symbol = ChineseZodiac.GetZodiacSignForDate(new DateTime(year, 4, 1));
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
            Assert.Equal("gòu", symbols.ZodiacName);
            Assert.Equal("Dog", symbols.ZodiacEnglishTranslation);
            Assert.Equal("Dog people are loyal & can always keep a secret. Sometimes they worry too much.", symbols.ZodiacPersonality);
        }

        [Fact]
        public void GetZodiacSign_Monkey_Test()
        {
            var symbols = ChineseZodiac.GetZodiacSign(ChineseZodiacSigns.Monkey);
            Assert.Equal("hóu", symbols.ZodiacName);
            Assert.Equal("Monkey", symbols.ZodiacEnglishTranslation);
            Assert.Equal("Monkey people are very funny. They can always make others laugh & are good problem solvers.", symbols.ZodiacPersonality);
        }

        [Fact]
        public void GetAllZodiacSignsForAnElement_Fire_Test()
        {
            var symbols = ChineseZodiac.GetAllZodiacSignsForAnElement(ChineseZodiacElements.Fire);
            var snakeAnimal = symbols.FirstOrDefault(s => s.ZodiacEnglishTranslation == ChineseZodiacSigns.Snake.ToString());
            var horseAnimal = symbols.FirstOrDefault(s => s.ZodiacEnglishTranslation == ChineseZodiacSigns.Horse.ToString());
            Assert.Equal(2, symbols.Count);
            Assert.NotNull(snakeAnimal);
            Assert.NotNull(horseAnimal);
        }

        [Fact]
        public void GetAllZodiacSignsForAnElement_Earth_Test()
        {
            var symbols = ChineseZodiac.GetAllZodiacSignsForAnElement(ChineseZodiacElements.Earth);
            var oxAnimal = symbols.FirstOrDefault(s => s.ZodiacEnglishTranslation == ChineseZodiacSigns.Ox.ToString());
            var dragonAnimal = symbols.FirstOrDefault(s => s.ZodiacEnglishTranslation == ChineseZodiacSigns.Dragon.ToString());
            var goatAnimal = symbols.FirstOrDefault(s => s.ZodiacEnglishTranslation == ChineseZodiacSigns.Goat.ToString());
            var dogAnimal = symbols.FirstOrDefault(s => s.ZodiacEnglishTranslation == ChineseZodiacSigns.Dog.ToString());
            Assert.Equal(4, symbols.Count);
            Assert.NotNull(oxAnimal);
            Assert.NotNull(dragonAnimal);
            Assert.NotNull(goatAnimal);
            Assert.NotNull(dogAnimal);
        }

        [Theory]
        [InlineData(2018, ChineseZodiacElements.Earth)]
        [InlineData(1952, ChineseZodiacElements.Water)]
        [InlineData(1964, ChineseZodiacElements.Wood)]
        [InlineData(1907, ChineseZodiacElements.Fire)]
        [InlineData(2000, ChineseZodiacElements.Metal)]
        public void GetChineseZodiacElementBasedOnYear_Test(int year, ChineseZodiacElements expectedZodiacElement)
        {
            var actualZodiacElement = ChineseZodiac.GetChineseZodiacElementBasedOnYear(year);
            Assert.Equal(expectedZodiacElement, actualZodiacElement);
        }

        [Theory]
        [InlineData(ChineseZodiacSigns.Rat)]
        [InlineData(ChineseZodiacSigns.Tiger)]
        [InlineData(ChineseZodiacSigns.Dragon)]
        [InlineData(ChineseZodiacSigns.Horse)]
        [InlineData(ChineseZodiacSigns.Monkey)]
        [InlineData(ChineseZodiacSigns.Dog)]
        public void GetZodiacSign_YinYang_Yang_Test(ChineseZodiacSigns chineseZodiacSigns)
        {
            var symbols = ChineseZodiac.GetZodiacSign(chineseZodiacSigns);
            Assert.Equal(YinYang.Yang, symbols.ZodiacYinYang);
        }

        [Theory]
        [InlineData(ChineseZodiacSigns.Ox)]
        [InlineData(ChineseZodiacSigns.Rabbit)]
        [InlineData(ChineseZodiacSigns.Snake)]
        [InlineData(ChineseZodiacSigns.Goat)]
        [InlineData(ChineseZodiacSigns.Rooster)]
        [InlineData(ChineseZodiacSigns.Pig)]
        public void GetZodiacSign_YinYang_Yin_Test(ChineseZodiacSigns chineseZodiacSigns)
        {
            var symbols = ChineseZodiac.GetZodiacSign(chineseZodiacSigns);
            Assert.Equal(YinYang.Yin, symbols.ZodiacYinYang);
        }

        [Fact]
        public void GetAllZodiacSignsForYinYang_Yang_Test()
        {
            var symbols = ChineseZodiac.GetAllZodiacSignsForYinYang(YinYang.Yang);
            var tigerSign = symbols.FirstOrDefault(s => s.ZodiacEnglishTranslation == ChineseZodiacSigns.Tiger.ToString());
            Assert.NotNull(tigerSign);
        }

        [Fact]
        public void GetAllZodiacSignsForYinYang_Yin_Test()
        {
            var symbols = ChineseZodiac.GetAllZodiacSignsForYinYang(YinYang.Yin);
            var snakeSign = symbols.FirstOrDefault(s => s.ZodiacEnglishTranslation == ChineseZodiacSigns.Snake.ToString());
            Assert.NotNull(snakeSign);
        }
    }
}
