using Horoscope.Helpers;
using Horoscope.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Horoscope
{
    /// <summary>
    /// List of all Chinese zodiac signs.
    /// </summary>
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

    /// <summary>
    /// List of all Chinese zodiac elements.
    /// </summary>
    public enum ChineseZodiacElements
    {
        Wood,
        Fire,
        Earth,
        Metal,
        Water
    }

    /// <summary>
    /// Contains all methods pertaining to Chinese zodiac signs.
    /// </summary>
    public class ChineseZodiac
    {
        /// <summary>
        /// Get the Chinese zodiac sign for the supplied date.
        /// </summary>
        /// <param name="requestedDateTime">The date you want to query.</param>
        /// <returns>Returns a Chinese zodiac sign object.</returns>
        public static ChineseZodiacModel GetZodiacSignForDate(DateTime requestedDateTime)
        {
            ChineseZodiacSigns chineseZodiacSign = ChineseZodiacHelper.ConvertYearToChineseZodiacSign(requestedDateTime.Year);
            ChineseZodiacHelper.InitializeAndGetAllZodiacSigns().TryGetValue(chineseZodiacSign, out ChineseZodiacModel chineseZodiacModel);
            return chineseZodiacModel;
        }

        /// <summary>
        /// Get details of the zodiac sign supplied.
        /// </summary>
        /// <param name="requestedZodiacSign">The zodiac sign that you want more details about.</param>
        /// <returns>A Chinese zodiac sign object.</returns>
        public static ChineseZodiacModel GetZodiacSign(ChineseZodiacSigns requestedZodiacSign)
        {
            ChineseZodiacHelper.InitializeAndGetAllZodiacSigns().TryGetValue(requestedZodiacSign, out ChineseZodiacModel zodiacSign);
            return zodiacSign;
        }

        /// <summary>
        /// Gets all zodiac signs and details for each sign.
        /// </summary>
        /// <returns>List of zodiac signs each as a Zodiac sign object.</returns>
        public static List<ChineseZodiacModel> GetAllZodiacSigns()
        {
            return ChineseZodiacHelper.InitializeAndGetAllZodiacSigns().Values.ToList();
        }

        /// <summary>
        /// Gets all zodiac signs that are associated with the zodiac element supplied.
        /// This is a fixed element-to-zodiac-sign association.
        /// </summary>
        /// <param name="chineseZodiacElements">The zodiac element that you want to query.</param>
        /// <returns>Returns a list of Chinese zodiac signs that are associated with the supplied zodiac element.</returns>
        public static List<ChineseZodiacModel> GetAllZodiacSignsForAnElement(ChineseZodiacElements chineseZodiacElements)
        {
            return ChineseZodiacHelper.InitializeAndGetAllZodiacSigns().Values
                    .Where(z => z.ZodiacFixedElement == chineseZodiacElements)
                    .Select(c => c)
                    .ToList();
        }

        /// <summary>
        /// Gets the Chinese zodiac element based on the year. 
        /// This is different from the fixed element which is
        /// strongly associated with one or more zodiac sign.
        /// </summary>
        /// <param name="year">The year you want the zodiac element for.</param>
        /// <returns>The Chinese zodiac element for the supplied year.</returns>
        public static ChineseZodiacElements GetChineseZodiacElementBasedOnYear(int year)
        {
            int lastDigitOfYear = ChineseZodiacHelper.GetRightMostDigitOfYear(year);
            if (lastDigitOfYear == 0 || lastDigitOfYear == 1)
            {
                return ChineseZodiacElements.Metal;
            }
            else if (lastDigitOfYear == 2 || lastDigitOfYear == 3)
            {
                return ChineseZodiacElements.Water;
            }
            else if (lastDigitOfYear == 4 || lastDigitOfYear == 5)
            {
                return ChineseZodiacElements.Wood;
            }
            else if (lastDigitOfYear == 6 || lastDigitOfYear == 7)
            {
                return ChineseZodiacElements.Fire;
            }
            else
            {
                return ChineseZodiacElements.Earth;
            }
        }
    }
}
