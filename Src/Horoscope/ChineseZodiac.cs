using Horoscope.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Horoscope
{
    public enum ChineseZodiacSigns
    {
        Rat,
        Ox,
        Tiger,
        Rabbit,
        Dragon,
        Snake,
        Horse,
        Goat,
        Monkey,
        Rooster,
        Dog,
        Pig
    }

    public class ChineseZodiac
    {
        public static void GetChineseZodiacAnimal(DateTime requestedDateTime)
        {
            ChineseZodiacSigns chineseZodiacSign = Get(requestedDateTime.Year);
        }

        /// <summary>
        /// Gets all Zodiac signs and details for each sign.
        /// </summary>
        /// <returns>List of Zodiac signs each as a Zodiac sign object.</returns>
        public static List<ChineseZodiacModel> GetAllZodiacSigns()
        {
            return InitializeAndGetAllZodiacSigns().Values.ToList();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        /// <remarks>
        /// Math credits: https://stackoverflow.com/a/22047886
        /// </remarks>
        private static ChineseZodiacSigns Get(int year)
        {
            int a = (year - 4);
            int b = (a / 12) * 12;
            return (ChineseZodiacSigns)(a - b);
        }

        /// <summary>
        /// Loads all Zodiac signs and returns a complete object.
        /// </summary>
        /// <returns>Dictionary collection of Zodiac signs.</returns>
        private static Dictionary<ChineseZodiacSigns, ChineseZodiacModel> InitializeAndGetAllZodiacSigns()
        {
            Dictionary<ChineseZodiacSigns, ChineseZodiacModel> zodiacSigns = new Dictionary<ChineseZodiacSigns, ChineseZodiacModel>
            {
                { ChineseZodiacSigns.Rat, RatChineseZodiacModel.GetRatModel() }
            };
            return zodiacSigns;
        }
    }
}
