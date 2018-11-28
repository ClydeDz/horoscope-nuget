namespace Horoscope.Model
{
    internal class RatChineseZodiacModel: ChineseZodiacModel
    {
        internal RatChineseZodiacModel(string name, string english, string personality, ChineseZodiacElements chineseZodiacFixedElement)
               : base(name, english, personality, chineseZodiacFixedElement)
        {

        }

        internal static RatChineseZodiacModel GetRatModel()
        {
            return new RatChineseZodiacModel("zǐ", ChineseZodiacSigns.Rat.ToString(), "Rat people are very popular. They like to invent things and are good artists.", ChineseZodiacElements.Water);
        }
    }
}
