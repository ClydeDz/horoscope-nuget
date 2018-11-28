namespace Horoscope.Model
{
    internal class DragonChineseZodiacModel: ChineseZodiacModel
    {
        internal DragonChineseZodiacModel(string name, string english, string personality)
                 : base(name, english, personality)
        {

        }

        internal static DragonChineseZodiacModel GetDragonModel()
        {
            return new DragonChineseZodiacModel("chén", ChineseZodiacSigns.Dragon.ToString(), "Dragon people have good health & lots of energy. They are good friends because they listen well.");
        }
    }
}
