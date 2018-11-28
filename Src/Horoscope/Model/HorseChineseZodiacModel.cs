namespace Horoscope.Model
{
    internal class HorseChineseZodiacModel: ChineseZodiacModel
    {
        internal HorseChineseZodiacModel(string name, string english, string personality)
                 : base(name, english, personality)
        {

        }

        internal static HorseChineseZodiacModel GetHorseModel()
        {
            return new HorseChineseZodiacModel("zǐ", ChineseZodiacSigns.Horse.ToString(), "Horse people are popular, cheerful & quick to compliment others. They can work very hard.");
        }
    }
}
