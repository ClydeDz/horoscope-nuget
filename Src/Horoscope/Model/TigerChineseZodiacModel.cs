namespace Horoscope.Model
{
    internal class TigerChineseZodiacModel: ChineseZodiacModel
    {
        internal TigerChineseZodiacModel(string name, string english, string personality, ChineseZodiacElements chineseZodiacFixedElement)
                  : base(name, english, personality, chineseZodiacFixedElement)
        {

        }

        internal static TigerChineseZodiacModel GetTigerModel()
        {
            return new TigerChineseZodiacModel("hǔ", ChineseZodiacSigns.Tiger.ToString(), "Tiger people are brave. They are respected for their deep thoughts & courageous actions.", ChineseZodiacElements.Wood);
        }
    }
}
