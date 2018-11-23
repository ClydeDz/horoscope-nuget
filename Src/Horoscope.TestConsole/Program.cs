using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Horoscope;

namespace Horoscope.TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Today.Month);

            var symbol = Zodiac.ConvertDateToZodiacSign(new DateTime(1994, 3, 3));
            Console.WriteLine(symbol.ZodiacDuration);

            symbol = Zodiac.GetZodiacSymbolDetails(ZodiacSymbols.Aquarius);
            Console.WriteLine(symbol.ZodiacDuration);

            var allSymbols = Zodiac.GetAllZodiacSymbolDetails();
            foreach(var sym in allSymbols)
            {
                Console.WriteLine(sym.ZodiacName);
            }
            Console.Read();
        }
    }
}
