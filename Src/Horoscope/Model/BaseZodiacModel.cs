namespace Horoscope.Model
{
    public class BaseZodiacModel
    {
        internal BaseZodiacModel(string zodiacName, string zodiacEnglishTranslation)
        {
            ZodiacName = zodiacName;
            ZodiacEnglishTranslation = zodiacEnglishTranslation;
        }

        /// <summary>
        /// The native Zodiac name. 
        /// </summary>
        public string ZodiacName { get; set; }

        /// <summary>
        /// The English translation of the Zodiac name.
        /// </summary>
        public string ZodiacEnglishTranslation { get; set; }
    }
}
