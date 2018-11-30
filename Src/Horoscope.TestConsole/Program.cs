using System;

namespace Horoscope.TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            // Horoscope.Zodiac
            ZodiacExamples.ShowZodiacBasicExamples();

            // Horoscope.ChineseZodiac
            ChineseZodiacExamples.ShowZodiacBasicExamples();
            
            Console.WriteLine("\nPress any key to exit");
            Console.ReadLine();
        }
    }
}
