using Horoscope.Helpers;
using Horoscope.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Horoscope
{
    /// <summary>
    /// List of all Zodiac signs
    /// </summary>
    public enum ZodiacSigns
    {
        Pisces,
        Aquarius,
        Virgo,
        Taurus,
        Scorpio,
        Sagittarius,
        Libra,
        Leo,
        Gemini,
        Capricorn,
        Cancer,
        Aries
    }
    
    /// <summary>
    /// Contains all methods pertaining to Zodiac signs.
    /// </summary>
    public class Zodiac
    {        
        /// <summary>
        /// Gets the Zodiac sign for the date supplied.
        /// </summary>
        /// <param name="requestedDateTime">The date for which you want the Zodiac sign.</param>
        /// <returns>A Zodiac sign object.</returns>
        public static ZodiacModel GetZodiacSignForDate(DateTime requestedDateTime)
        {
            var zodiacSymbol = ZodiacHelper.InitializeAndGetAllZodiacSigns().Values
                .Where(d => 
                    (d.ZodiacStartDate.Month == requestedDateTime.Month && requestedDateTime.Day >= d.ZodiacStartDate.Date) 
                    || (d.ZodiacEndDate.Month == requestedDateTime.Month && requestedDateTime.Day <= d.ZodiacEndDate.Date))                
                .Select(s => s)
                .FirstOrDefault();
            return zodiacSymbol;
        }

        /// <summary>
        /// Get details of the Zodiac sign supplied.
        /// </summary>
        /// <param name="requestedZodiacSign">The Zodiac sign that you want more details about.</param>
        /// <returns>A Zodiac sign object.</returns>
        public static ZodiacModel GetZodiacSign(ZodiacSigns requestedZodiacSign)
        {
            ZodiacHelper.InitializeAndGetAllZodiacSigns().TryGetValue(requestedZodiacSign, out ZodiacModel zodiacSign);
            return zodiacSign;
        }

        /// <summary>
        /// Gets all Zodiac signs and details for each sign.
        /// </summary>
        /// <returns>List of Zodiac signs each as a Zodiac sign object.</returns>
        public static List<ZodiacModel> GetAllZodiacSigns()
        {
            return ZodiacHelper.InitializeAndGetAllZodiacSigns().Values.ToList();
        }
    }
}
