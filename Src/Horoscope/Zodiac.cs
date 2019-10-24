using Horoscope.Helpers;
using Horoscope.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Horoscope
{
    /// <summary>
    /// Contains all public methods pertaining to zodiac signs.
    /// </summary>
    public class Zodiac
    {
        /// <summary>
        /// Gets the zodiac sign for the date supplied.
        /// </summary>
        /// <param name="requestedDateTime">The date for which you want the zodiac sign.</param>
        /// <returns>A zodiac sign object.</returns>
        public static ZodiacModel GetZodiacSignForDate(DateTime requestedDateTime)
        {
            var zodiacSymbol = ZodiacHelper.InitializeAndGetAllZodiacSigns().Values
                .FirstOrDefault(z => 
                    (z.ZodiacStartDate.Month == requestedDateTime.Month && requestedDateTime.Day >= z.ZodiacStartDate.Date) 
                    || (z.ZodiacEndDate.Month == requestedDateTime.Month && requestedDateTime.Day <= z.ZodiacEndDate.Date));
            return zodiacSymbol;
        }

        /// <summary>
        /// Get details of the zodiac sign supplied.
        /// </summary>
        /// <param name="requestedZodiacSign">The zodiac sign that you want more details about.</param>
        /// <returns>A zodiac sign object.</returns>
        public static ZodiacModel GetZodiacSign(ZodiacSigns requestedZodiacSign)
        {
            ZodiacHelper.InitializeAndGetAllZodiacSigns().TryGetValue(requestedZodiacSign, out ZodiacModel zodiacSign);
            return zodiacSign;
        }

        /// <summary>
        /// Gets all zodiac signs and details for each sign.
        /// </summary>
        /// <returns>List of zodiac signs each as a zodiac sign object.</returns>
        public static List<ZodiacModel> GetAllZodiacSigns()
        {
            return ZodiacHelper.InitializeAndGetAllZodiacSigns().Values.ToList();
        }
    }
}
