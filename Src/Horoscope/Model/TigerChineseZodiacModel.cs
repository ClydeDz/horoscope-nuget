namespace Horoscope.Model
{
    internal class TigerChineseZodiacModel: ChineseZodiacModel
    {
        internal TigerChineseZodiacModel(string name, string english, string personality, ChineseZodiacElements chineseZodiacFixedElement, YinYang yinYang)
                  : base(name, english, personality, chineseZodiacFixedElement, yinYang)
        {

        }

        internal static TigerChineseZodiacModel GetTigerModel()
        {
            return new TigerChineseZodiacModel(
                "hǔ", 
                ChineseZodiacSigns.Tiger.ToString(), 
                "Tiger people are brave. They are respected for their deep thoughts & courageous actions.", 
                ChineseZodiacElements.Wood,
                YinYang.Yang);
        }
    }
}
