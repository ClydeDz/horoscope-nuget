using System;

namespace Horoscope.TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Today.Month);

            var symbol = Zodiac.ConvertDateToZodiacSign(new DateTime(1966, 2, 12));
            Console.WriteLine(symbol.ZodiacName +" "+ symbol.ZodiacDuration);

            symbol = Zodiac.GetZodiacSymbolDetails(ZodiacSymbols.Aquarius);
            Console.WriteLine(symbol.ZodiacDuration);

            var allSymbols = Zodiac.GetAllZodiacSymbolDetails();
            foreach (var sym in allSymbols)
            {
                Console.WriteLine(sym.ZodiacName);
            }
            Console.Read();
        }
    }
}
