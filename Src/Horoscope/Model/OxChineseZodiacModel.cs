namespace Horoscope.Model
{
    internal class OxChineseZodiacModel: ChineseZodiacModel
    {
        internal OxChineseZodiacModel(string name, string english, string personality, ChineseZodiacElements chineseZodiacFixedElement, YinYang yinYang)
                  : base(name, english, personality, chineseZodiacFixedElement, yinYang)
        {

        }

        internal static OxChineseZodiacModel GetOxModel()
        {
            return new OxChineseZodiacModel(
                "niú", 
                ChineseZodiacSigns.Ox.ToString(), 
                "Ox people are dependable & calm. They are good listeners & have very strong ideas.", 
                ChineseZodiacElements.Earth,
                YinYang.Yin);
        }
    }
}
