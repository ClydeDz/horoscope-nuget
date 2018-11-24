using System;

namespace Horoscope.TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Today.Month);

            var symbol = Zodiac.GetZodiacSignForDate(new DateTime(1966, 2, 12));
            Console.WriteLine(symbol.ZodiacName +" "+ symbol.ZodiacDuration);

            symbol = Zodiac.GetZodiacSign(ZodiacSigns.Aquarius);
            Console.WriteLine(symbol.ZodiacDuration);

            var allSymbols = Zodiac.GetAllZodiacSigns();
            foreach (var sym in allSymbols)
            {
                Console.WriteLine(sym.ZodiacName);
            }
            Console.Read();
        }
    }
}
