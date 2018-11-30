namespace Horoscope.Model
{
    internal class RabbitChineseZodiacModel: ChineseZodiacModel
    {
        internal RabbitChineseZodiacModel(string name, string english, string personality, ChineseZodiacElements chineseZodiacFixedElement, YinYang yinYang)
                 : base(name, english, personality, chineseZodiacFixedElement, yinYang)
        {

        }

        internal static RabbitChineseZodiacModel GetRabbitModel()
        {
            return new RabbitChineseZodiacModel(
                "tù", 
                ChineseZodiacSigns.Rabbit.ToString(), 
                "Rabbit people are nice to be around. They like to talk and many people trust them.", 
                ChineseZodiacElements.Wood,
                YinYang.Yin);
        }
    }
}
