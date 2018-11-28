namespace Horoscope.Model
{
    class GoatChineseZodiacModel: ChineseZodiacModel
    {
        internal GoatChineseZodiacModel(string name, string english, string personality, ChineseZodiacElements chineseZodiacFixedElement)
                 : base(name, english, personality, chineseZodiacFixedElement)
        {

        }

        internal static GoatChineseZodiacModel GetGoatModel()
        {
            return new GoatChineseZodiacModel("wèi", ChineseZodiacSigns.Goat.ToString(), "Goat people are very good artists. They ask many questions, like nice things & are very wise.", ChineseZodiacElements.Earth);
        }
    }
}
