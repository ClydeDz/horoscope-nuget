namespace Horoscope.Model
{
    /// <summary>
    /// Base Zodiac sign object containing information common to all Zodiac signs.
    /// </summary>
    public class BaseZodiacModel
    {
        internal BaseZodiacModel(string zodiacName, string zodiacEnglishTranslation)
        {
            ZodiacName = zodiacName;
            ZodiacEnglishTranslation = zodiacEnglishTranslation;
        }

        /// <summary>
        /// The native zodiac name. 
        /// </summary>
        public string ZodiacName { get; set; }

        /// <summary>
        /// The English translation of the zodiac name.
        /// </summary>
        public string ZodiacEnglishTranslation { get; set; }
    }
}
