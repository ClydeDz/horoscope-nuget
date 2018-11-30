namespace Horoscope.Model
{
    internal class MonkeyChineseZodiacModel: ChineseZodiacModel
    {
        internal MonkeyChineseZodiacModel(string name, string english, string personality, ChineseZodiacElements chineseZodiacFixedElement, YinYang yinYang)
                 : base(name, english, personality, chineseZodiacFixedElement, yinYang)
        {

        }

        internal static MonkeyChineseZodiacModel GetMonkeyModel()
        {
            return new MonkeyChineseZodiacModel(
                "hóu", 
                ChineseZodiacSigns.Monkey.ToString(), 
                "Monkey people are very funny. They can always make others laugh & are good problem solvers.", 
                ChineseZodiacElements.Metal,
                YinYang.Yang);
        }
    }
}
