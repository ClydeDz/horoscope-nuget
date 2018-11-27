namespace Horoscope.Model
{
    internal class SnakeChineseZodiacModel : ChineseZodiacModel
    {
        internal SnakeChineseZodiacModel(string name, string english, string personality)
               : base(name, english, personality)
        {

        }

        internal static SnakeChineseZodiacModel GetSnakeModel()
        {
            return new SnakeChineseZodiacModel("sì", "Snake", "Snake people love good books, food, music & plays. They have good luck with money.");
        }
    }
}
