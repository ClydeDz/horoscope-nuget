namespace Horoscope.Model
{
    internal class RabbitChineseZodiacModel: ChineseZodiacModel
    {
        internal RabbitChineseZodiacModel(string name, string english, string personality)
                 : base(name, english, personality)
        {

        }

        internal static RabbitChineseZodiacModel GetRabbitModel()
        {
            return new RabbitChineseZodiacModel("mǎo", ChineseZodiacSigns.Rabbit.ToString(), "Rabbit people are nice to be around. They like to talk and many people trust them.");
        }
    }
}
