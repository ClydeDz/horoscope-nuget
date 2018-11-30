using System;

namespace Horoscope.TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            const string packageName = @"
  _   _                                            _   _        ____      _   
 | | | | ___  _ __ ___  ___  ___ ___  _ __   ___  | \ | |_   _ / ___| ___| |_ 
 | |_| |/ _ \| '__/ _ \/ __|/ __/ _ \| '_ \ / _ \ |  \| | | | | |  _ / _ \ __|
 |  _  | (_) | | | (_) \__ \ (_| (_) | |_) |  __/ | |\  | |_| | |_| |  __/ |_ 
 |_| |_|\___/|_|  \___/|___/\___\___/| .__/ \___| |_| \_|\__,_|\____|\___|\__|
                                     |_|                                      
            ";
            const string author = @"
 __                __  /  __                
/   |     _|  _   |  \   (_   _      _   _  
\__ | \/ (_| (-   |__/   __) (_) |_| /_ (_| 
      /                                     
            ";

            // Horoscope NuGet
            Console.WriteLine(packageName);

            // Horoscope.Zodiac
            Console.WriteLine("\n####################\n### Horoscope.Zodiac\n####################");
            ZodiacExamples.ShowZodiacBasicExamples();

            // Horoscope.ChineseZodiac
            Console.WriteLine("\n###########################\n### Horoscope.ChineseZodiac\n###########################");
            ChineseZodiacExamples.ShowZodiacBasicExamples();
            
            // Wrap up
            Console.WriteLine("\nPress any key to exit");
            Console.WriteLine($"\nHoroscope NuGet (c) 2018 Clyde D'Souza \n{author}");
            Console.ReadLine();
        }
    }
}
