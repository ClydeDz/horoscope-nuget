namespace Horoscope.Model
{
    internal class RatChineseZodiacModel: ChineseZodiacModel
    {
        internal RatChineseZodiacModel(string name, string english, string personality)
               : base(name, english, personality)
        {

        }

        internal static RatChineseZodiacModel GetRatModel()
        {
            return new RatChineseZodiacModel("zǐ", "Rat", "Rat people are very popular. They like to invent things and are good artists.");
        }
    }
}
