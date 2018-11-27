namespace Horoscope.Model
{
    internal class TigerChineseZodiacModel: ChineseZodiacModel
    {
        internal TigerChineseZodiacModel(string name, string english, string personality)
                  : base(name, english, personality)
        {

        }

        internal static TigerChineseZodiacModel GetTigerModel()
        {
            return new TigerChineseZodiacModel("yín", "Tiger", "Tiger people	are brave. They are respected for their deep thoughts & courageous actions.");
        }
    }
}
