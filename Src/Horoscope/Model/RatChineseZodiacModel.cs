namespace Horoscope.Model
{
    internal class RatChineseZodiacModel: ChineseZodiacModel
    {
        internal RatChineseZodiacModel(string name, string english, string personality, ChineseZodiacElements chineseZodiacFixedElement, YinYang yinYang)
               : base(name, english, personality, chineseZodiacFixedElement, yinYang)
        {

        }

        internal static RatChineseZodiacModel GetRatModel()
        {
            return new RatChineseZodiacModel(
                "shǔ", 
                ChineseZodiacSigns.Rat.ToString(), 
                "Rat people are very popular. They like to invent things and are good artists.", 
                ChineseZodiacElements.Water,
                YinYang.Yang);
        }
    }
}
