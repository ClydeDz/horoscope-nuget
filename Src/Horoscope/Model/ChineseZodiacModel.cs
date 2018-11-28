namespace Horoscope.Model
{
    public class ChineseZodiacModel: BaseZodiacModel
    {
        internal ChineseZodiacModel(string name, string english, string zodiacPersonality, ChineseZodiacElements chineseZodiacFixedElement)
            :base(name, english)
        {
            ZodiacPersonality = zodiacPersonality;
            ZodiacFixedElement = chineseZodiacFixedElement;
        }

        /// <summary>
        /// What this Zodiac sign tells about you.
        /// </summary>
        public string ZodiacPersonality { get; set; }

        public ChineseZodiacElements ZodiacFixedElement { get; set; }
    }
}
