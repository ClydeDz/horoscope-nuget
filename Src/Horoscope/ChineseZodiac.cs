using Horoscope.Helpers;
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

    public enum ChineseZodiacElements
    {
        Wood,
        Fire,
        Earth,
        Metal,
        Water
    }

    public class ChineseZodiac
    {
        public static ChineseZodiacModel GetChineseZodiacAnimal(DateTime requestedDateTime)
        {
            ChineseZodiacSigns chineseZodiacSign = ChineseZodiacHelper.ConvertYearToChineseZodiacSign(requestedDateTime.Year);
            ChineseZodiacHelper.InitializeAndGetAllZodiacSigns().TryGetValue(chineseZodiacSign, out ChineseZodiacModel chineseZodiacModel);
            return chineseZodiacModel;
        }

        /// <summary>
        /// Get details of the Zodiac sign supplied.
        /// </summary>
        /// <param name="requestedZodiacSign">The Zodiac sign that you want more details about.</param>
        /// <returns>A Zodiac sign object.</returns>
        public static ChineseZodiacModel GetZodiacSign(ChineseZodiacSigns requestedZodiacSign)
        {
            ChineseZodiacHelper.InitializeAndGetAllZodiacSigns().TryGetValue(requestedZodiacSign, out ChineseZodiacModel zodiacSign);
            return zodiacSign;
        }

        /// <summary>
        /// Gets all Zodiac signs and details for each sign.
        /// </summary>
        /// <returns>List of Zodiac signs each as a Zodiac sign object.</returns>
        public static List<ChineseZodiacModel> GetAllZodiacSigns()
        {
            return ChineseZodiacHelper.InitializeAndGetAllZodiacSigns().Values.ToList();
        }
    }
}
