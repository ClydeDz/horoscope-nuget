using System;

namespace Horoscope.TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            // Horoscope.Zodiac
            Console.WriteLine("\n####################\n### Horoscope.Zodiac\n####################");
            ZodiacExamples.ShowZodiacBasicExamples();

            // Horoscope.ChineseZodiac
            Console.WriteLine("\n###########################\n### Horoscope.ChineseZodiac\n###########################");
            ChineseZodiacExamples.ShowZodiacBasicExamples();
            
            Console.WriteLine("\nPress any key to exit");
            Console.ReadLine();
        }
    }
}
