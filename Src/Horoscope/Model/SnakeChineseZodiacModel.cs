namespace Horoscope.Model
{
    internal class SnakeChineseZodiacModel : ChineseZodiacModel
    {
        internal SnakeChineseZodiacModel(string name, string english, string personality, ChineseZodiacElements chineseZodiacFixedElement, YinYang yinYang)
               : base(name, english, personality, chineseZodiacFixedElement, yinYang)
        {

        }

        internal static SnakeChineseZodiacModel GetSnakeModel()
        {
            return new SnakeChineseZodiacModel(
                "shé", 
                ChineseZodiacSigns.Snake.ToString(), 
                "Snake people love good books, food, music & plays. They have good luck with money.", 
                ChineseZodiacElements.Fire,
                YinYang.Yin);
        }
    }
}
