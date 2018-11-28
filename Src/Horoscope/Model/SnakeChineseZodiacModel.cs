namespace Horoscope.Model
{
    internal class SnakeChineseZodiacModel : ChineseZodiacModel
    {
        internal SnakeChineseZodiacModel(string name, string english, string personality, ChineseZodiacElements chineseZodiacFixedElement)
               : base(name, english, personality, chineseZodiacFixedElement)
        {

        }

        internal static SnakeChineseZodiacModel GetSnakeModel()
        {
            return new SnakeChineseZodiacModel("sì", ChineseZodiacSigns.Snake.ToString(), "Snake people love good books, food, music & plays. They have good luck with money.", ChineseZodiacElements.Fire);
        }
    }
}
