namespace Horoscope.Model
{
    internal class MonkeyChineseZodiacModel: ChineseZodiacModel
    {
        internal MonkeyChineseZodiacModel(string name, string english, string personality)
                 : base(name, english, personality)
        {

        }

        internal static MonkeyChineseZodiacModel GetMonkeyModel()
        {
            return new MonkeyChineseZodiacModel("shēn", ChineseZodiacSigns.Monkey.ToString(), "Monkey people are very funny. They can always make others laugh & are good problem solvers.");
        }
    }
}
