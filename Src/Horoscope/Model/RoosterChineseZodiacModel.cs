namespace Horoscope.Model
{
    internal class RoosterChineseZodiacModel: ChineseZodiacModel
    {
        internal RoosterChineseZodiacModel(string name, string english, string personality, ChineseZodiacElements chineseZodiacFixedElement)
                  : base(name, english, personality, chineseZodiacFixedElement)
        {

        }

        internal static RoosterChineseZodiacModel GetRoosterModel()
        {
            return new RoosterChineseZodiacModel("xióng jī", ChineseZodiacSigns.Rooster.ToString(), "Rooster people are hardworkers. They have many talents & think deep thoughts.", ChineseZodiacElements.Metal);
        }
    }
}
