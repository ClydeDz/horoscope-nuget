namespace Horoscope.Model
{
    internal class DragonChineseZodiacModel: ChineseZodiacModel
    {
        internal DragonChineseZodiacModel(string name, string english, string personality, ChineseZodiacElements chineseZodiacFixedElement)
                 : base(name, english, personality, chineseZodiacFixedElement)
        {

        }

        internal static DragonChineseZodiacModel GetDragonModel()
        {
            return new DragonChineseZodiacModel("lóng", ChineseZodiacSigns.Dragon.ToString(), "Dragon people have good health & lots of energy. They are good friends because they listen well.", ChineseZodiacElements.Earth);
        }
    }
}
