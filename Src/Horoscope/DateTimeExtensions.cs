using Horoscope.Model;
using System;

namespace Horoscope
{
    /// <summary>
    /// Enable usage of Zodiac and ChineseZodiac methods straight from DateTime instances
    /// </summary>
    public static class DateTimeExtensions
    {
        /// <summary>
        /// Gets the zodiac sign.
        /// </summary>
        /// <param name="dateTime">The date for which you want the zodiac sign.</param>
        /// <returns>A zodiac sign object.</returns>
        public static ZodiacModel GetZodiacSign(this DateTime dateTime) => Zodiac.GetZodiacSignForDate(dateTime);

        /// <summary>
        /// Get the Chinese zodiac sign.
        /// </summary>
        /// <param name="dateTime">The date you want to query.</param>
        /// <returns>Returns a Chinese zodiac sign object.</returns>
        public static ChineseZodiacModel GetChineseZodiacSign(this DateTime dateTime) => ChineseZodiac.GetZodiacSignForDate(dateTime);
    }
}
