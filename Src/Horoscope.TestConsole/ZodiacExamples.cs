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
            Console.WriteLine($"\nZodiac details for {new DateTime(1966, 2, 12).ToShortDateString()}");
            Console.WriteLine($"Name: {zodiacSign.ZodiacName} English name: {zodiacSign.ZodiacEnglishTranslation} Duration: {zodiacSign.ZodiacDuration}");

            // Another option would be:
            var givenDate = new DateTime(1995, 8, 26);
            var anotherZodiacSign = givenDate.GetZodiacSign();
            Console.WriteLine($"\nZodiac details for {givenDate.ToShortDateString()}");
            Console.WriteLine($"Name: {anotherZodiacSign.ZodiacName} English name: {anotherZodiacSign.ZodiacEnglishTranslation} Duration: {anotherZodiacSign.ZodiacDuration}");

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
