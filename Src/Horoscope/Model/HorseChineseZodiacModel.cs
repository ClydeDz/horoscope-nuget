namespace Horoscope.Model
{
    internal class HorseChineseZodiacModel: ChineseZodiacModel
    {
        internal HorseChineseZodiacModel(string name, string english, string personality, ChineseZodiacElements chineseZodiacFixedElement, YinYang yinYang)
                 : base(name, english, personality, chineseZodiacFixedElement, yinYang)
        {

        }

        internal static HorseChineseZodiacModel GetHorseModel()
        {
            return new HorseChineseZodiacModel(
                "mǎ", 
                ChineseZodiacSigns.Horse.ToString(), 
                "Horse people are popular, cheerful & quick to compliment others. They can work very hard.", 
                ChineseZodiacElements.Fire,
                YinYang.Yang);
        }
    }
}
