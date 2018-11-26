namespace Horoscope.Model
{
    public class ChineseZodiacModel: BaseZodiacModel
    {
        internal ChineseZodiacModel(string name, string english, string zodiacPersonality)
            :base(name, english)
        {
            ZodiacPersonality = zodiacPersonality;
        }

        /// <summary>
        /// What this Zodiac sign tells about you.
        /// </summary>
        public string ZodiacPersonality { get; set; }
    }
}
