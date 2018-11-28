namespace Horoscope.Model
{
    class GoatChineseZodiacModel: ChineseZodiacModel
    {
        internal GoatChineseZodiacModel(string name, string english, string personality)
                 : base(name, english, personality)
        {

        }

        internal static GoatChineseZodiacModel GetGoatModel()
        {
            return new GoatChineseZodiacModel("wèi", ChineseZodiacSigns.Goat.ToString(), "Goat people are very good artists. They ask many questions, like nice things & are very wise.");
        }
    }
}
