namespace Horoscope.Model
{
    /// <summary>
    /// The Chinese zodiac sign object containing information on each Chinese zodiac sign.
    /// </summary>
    public class ChineseZodiacModel: BaseZodiacModel
    {
        internal ChineseZodiacModel(string name, string english, string zodiacPersonality, ChineseZodiacElements chineseZodiacFixedElement, YinYang yinYang)
            :base(name, english)
        {
            ZodiacPersonality = zodiacPersonality;
            ZodiacFixedElement = chineseZodiacFixedElement;
            ZodiacYinYang = yinYang;
        }

        /// <summary>
        /// What this zodiac sign tells about you.
        /// </summary>
        public string ZodiacPersonality { get; set; }

        /// <summary>
        /// The element associated with this zodiac sign.
        /// </summary>
        public ChineseZodiacElements ZodiacFixedElement { get; set; }

        /// <summary>
        /// The YinYang element associated with this zodiac sign.
        /// </summary>
        public YinYang ZodiacYinYang { get; set; }
    }
}
