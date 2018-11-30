using System;

namespace Horoscope.TestConsole
{
    /// <summary>
    /// Contains example usage scenarios of Horoscope.Zodiac
    /// </summary>
    class ZodiacExamples
    {
        /// <summary>
        /// Contains basic example usage scenarios.
        /// </summary>
        public static void ShowZodiacBasicExamples()
        {
            var zodiacSign = Zodiac.GetZodiacSignForDate(new DateTime(1966, 2, 12));
            Console.WriteLine($"Zodiac details for {new DateTime(1966, 2, 12).ToShortDateString()}");
            Console.WriteLine($"Name: {zodiacSign.ZodiacName} English name: {zodiacSign.ZodiacEnglishTranslation} Duration: {zodiacSign.ZodiacDuration}");

            var capriconZodiacSign = Zodiac.GetZodiacSign(ZodiacSigns.Capricorn);
            Console.WriteLine($"\nZodiac duration for {ZodiacSigns.Capricorn}");
            Console.WriteLine(capriconZodiacSign.ZodiacDuration);

            var allZodiacSigns = Zodiac.GetAllZodiacSigns();
            Console.WriteLine($"\nGet a list of all zodiac signs");
            foreach (var currentZodiacSign in allZodiacSigns)
            {
                Console.WriteLine($"-\t{currentZodiacSign.ZodiacName}");
            }
        }
    }
}
