namespace Horoscope.Model
{
    internal class RoosterChineseZodiacModel: ChineseZodiacModel
    {
        internal RoosterChineseZodiacModel(string name, string english, string personality, ChineseZodiacElements chineseZodiacFixedElement, YinYang yinYang)
                  : base(name, english, personality, chineseZodiacFixedElement, yinYang)
        {

        }

        internal static RoosterChineseZodiacModel GetRoosterModel()
        {
            return new RoosterChineseZodiacModel(
                "xióng jī", 
                ChineseZodiacSigns.Rooster.ToString(), 
                "Rooster people are hardworkers. They have many talents & think deep thoughts.", 
                ChineseZodiacElements.Metal,
                YinYang.Yin);
        }
    }
}
