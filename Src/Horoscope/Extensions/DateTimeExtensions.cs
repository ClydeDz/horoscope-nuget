using Horoscope.Model;
using System;

namespace Horoscope.Extensions
{
    public static class DateTimeExtensions
    {
        /// <summary>
        /// Gets the zodiac sign for the date supplied.
        /// </summary>
        /// <param name="dateTime">The date for which you want the zodiac sign.</param>
        /// <returns>A zodiac sign object.</returns>
        public static ZodiacModel GetZodiacSign(this DateTime dateTime) => Zodiac.GetZodiacSignForDate(dateTime);

        /// <summary>
        /// Get the Chinese zodiac sign for the supplied date.
        /// </summary>
        /// <param name="dateTime">The date you want to query.</param>
        /// <returns>Returns a Chinese zodiac sign object.</returns>
        public static ChineseZodiacModel GetChineseZodiacSign(this DateTime dateTime) => ChineseZodiac.GetZodiacSignForDate(dateTime);
    }
}
