namespace Horoscope.Model
{
    class GoatChineseZodiacModel: ChineseZodiacModel
    {
        internal GoatChineseZodiacModel(string name, string english, string personality, ChineseZodiacElements chineseZodiacFixedElement, YinYang yinYang)
                 : base(name, english, personality, chineseZodiacFixedElement, yinYang)
        {

        }

        internal static GoatChineseZodiacModel GetGoatModel()
        {
            return new GoatChineseZodiacModel(
                "yáng", 
                ChineseZodiacSigns.Goat.ToString(), 
                "Goat people are very good artists. They ask many questions, like nice things & are very wise.", 
                ChineseZodiacElements.Earth,
                YinYang.Yin);
        }
    }
}
