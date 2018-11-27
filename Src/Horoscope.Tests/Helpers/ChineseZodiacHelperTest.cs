using Horoscope.Helpers;
using Xunit;

namespace Horoscope.Tests.Helpers
{
    public class ChineseZodiacHelperTest
    {
        [Theory]
        [InlineData(2012, ChineseZodiacSigns.Dragon)]
        [InlineData(1984, ChineseZodiacSigns.Rat)]
        [InlineData(1900, ChineseZodiacSigns.Rat)]
        [InlineData(1920, ChineseZodiacSigns.Monkey)]
        [InlineData(2018, ChineseZodiacSigns.Dog)]
        [InlineData(1854, ChineseZodiacSigns.Tiger)]
        [InlineData(1735, ChineseZodiacSigns.Rabbit)]
        [InlineData(2033, ChineseZodiacSigns.Ox)]
        [InlineData(2, ChineseZodiacSigns.Tiger)]
        [InlineData(3, ChineseZodiacSigns.Ox)]
        [InlineData(0, ChineseZodiacSigns.Dragon)]
        [InlineData(-2, ChineseZodiacSigns.Tiger)]
        public void ConvertYearToChineseZodiacSign_Test(int year, ChineseZodiacSigns zodiacSign)
        {
            var symbol = ChineseZodiacHelper.ConvertYearToChineseZodiacSign(year);
            Assert.Equal(zodiacSign, symbol);
        }

        [Fact]
        public void InitializeAndGetAllZodiacSigns_Count_Test()
        {
            var symbol = ChineseZodiacHelper.InitializeAndGetAllZodiacSigns();
            Assert.Equal(12, symbol.Count);
        }

        [Fact]
        public void InitializeAndGetAllZodiacSigns_ZodiacEnglishTranslation_Test()
        {
            ChineseZodiacHelper.InitializeAndGetAllZodiacSigns().TryGetValue(ChineseZodiacSigns.Goat, out Model.ChineseZodiacModel zodiacModel);
            Assert.Equal(ChineseZodiacSigns.Goat.ToString(), zodiacModel.ZodiacEnglishTranslation);
        }
    }
}
