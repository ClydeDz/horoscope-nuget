using System;

namespace Horoscope.TestConsole
{
    /// <summary>
    /// Contains example usage scenarios of Horoscope.ChineseZodiac
    /// </summary>
    class ChineseZodiacExamples
    {
        /// <summary>
        /// Contains basic example usage scenarios.
        /// </summary>
        public static void ShowZodiacBasicExamples()
        {
            var allFireChineseSigns = ChineseZodiac.GetAllZodiacSignsForAnElement(ChineseZodiacElements.Fire);
            Console.WriteLine($"\nGet a list of all Chinese zodiac signs that are associated with {ChineseZodiacElements.Fire}");
            foreach (var currentZodiacSign in allFireChineseSigns)
            {
                Console.WriteLine($"-\t{currentZodiacSign.ZodiacEnglishTranslation}");
            }

            var dragonZodiacSign = ChineseZodiac.GetZodiacSign(ChineseZodiacSigns.Dragon);
            Console.WriteLine($"\nPersonality trait for {ChineseZodiacSigns.Dragon} people: {dragonZodiacSign.ZodiacPersonality}");

            var zodiacSignFor2018 = ChineseZodiac.GetChineseZodiacElementBasedOnYear(2018);
            Console.WriteLine($"\nChinese zodiac element for 2018 is {zodiacSignFor2018}");

            var zodiacSignForDate = ChineseZodiac.GetZodiacSignForDate(new DateTime(1966, 2, 12));
            Console.WriteLine($"\nChinese zodiac sign for {new DateTime(1966, 2, 12).ToShortDateString()} is {zodiacSignForDate.ZodiacEnglishTranslation}");

            // Another option would be:
            var givenDate = new DateTime(1995, 8, 26);
            var anotherZodiacSign = givenDate.GetChineseZodiacSign();
            Console.WriteLine($"\nChinese zodiac sign for {givenDate.ToShortDateString()} is {anotherZodiacSign.ZodiacEnglishTranslation}");

            var allChineseZodiacSigns = ChineseZodiac.GetAllZodiacSigns();
            Console.WriteLine($"\nGet a list of all Chinese zodiac signs");
            foreach (var currentZodiacSign in allChineseZodiacSigns)
            {
                Console.WriteLine($"-\t{currentZodiacSign.ZodiacName} - {currentZodiacSign.ZodiacEnglishTranslation}");
            }

            var allChineseZodiacSignsYin = ChineseZodiac.GetAllZodiacSignsForYinYang(YinYang.Yin);
            Console.WriteLine($"\nGet a list of all Chinese zodiac signs associated with {YinYang.Yin}");
            foreach (var currentZodiacSign in allChineseZodiacSignsYin)
            {
                Console.WriteLine($"-\t{currentZodiacSign.ZodiacName} - {currentZodiacSign.ZodiacEnglishTranslation}");
            }
        }
    }
}
