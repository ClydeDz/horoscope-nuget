using Horoscope.Model;
using System;
using System.Collections.Generic;

namespace Horoscope.Helpers
{
    internal class ChineseZodiacHelper
    {
        /// <summary>
        /// Given a year, calculates the Chinese zodiac animal.
        /// </summary>
        /// <param name="year">Year.</param>
        /// <returns>Returns the Chinese zodiac animal.</returns>
        /// <remarks>
        /// Math credits: https://stackoverflow.com/a/22047886
        /// </remarks>
        internal static ChineseZodiacSigns ConvertYearToChineseZodiacSign(int year)
        {
            int a = (Math.Abs(year) - 4);
            int b = (a / 12) * 12;
            return (ChineseZodiacSigns)(Math.Abs(a - b));
        }
        
        /// <summary>
        /// Gets the right-most digit of the year supplied.
        /// </summary>
        /// <param name="year">The year you want the right-most digit for.</param>
        /// <returns>Returns the right-most digit of the year supplied.</returns>
        internal static int GetRightMostDigitOfYear(int year)
        {
            return Convert.ToInt32(year.ToString().Substring(year.ToString().Length - 1));
        }

        /// <summary>
        /// Loads all zodiac signs and returns a complete object.
        /// </summary>
        /// <returns>Dictionary collection of zodiac signs.</returns>
        internal static Dictionary<ChineseZodiacSigns, ChineseZodiacModel> InitializeAndGetAllZodiacSigns()
        {
            Dictionary<ChineseZodiacSigns, ChineseZodiacModel> zodiacSigns = new Dictionary<ChineseZodiacSigns, ChineseZodiacModel>
            {
                { ChineseZodiacSigns.Rat, RatChineseZodiacModel.GetRatModel() },
                { ChineseZodiacSigns.Ox, OxChineseZodiacModel.GetOxModel() },
                { ChineseZodiacSigns.Tiger, TigerChineseZodiacModel.GetTigerModel() },
                { ChineseZodiacSigns.Rabbit, RabbitChineseZodiacModel.GetRabbitModel() },
                { ChineseZodiacSigns.Dragon, DragonChineseZodiacModel.GetDragonModel() },
                { ChineseZodiacSigns.Snake, SnakeChineseZodiacModel.GetSnakeModel() },
                { ChineseZodiacSigns.Horse, HorseChineseZodiacModel.GetHorseModel() },
                { ChineseZodiacSigns.Goat, GoatChineseZodiacModel.GetGoatModel() },
                { ChineseZodiacSigns.Monkey, MonkeyChineseZodiacModel.GetMonkeyModel() },
                { ChineseZodiacSigns.Rooster, RoosterChineseZodiacModel.GetRoosterModel() },
                { ChineseZodiacSigns.Dog, DogChineseZodiacModel.GetDogModel() },
                { ChineseZodiacSigns.Pig, PigChineseZodiacModel.GetPigModel() }
            };
            return zodiacSigns;
        }
    }
}
