namespace Horoscope.Model
{
    internal class ScorpioZodiacModel : ZodiacModel
    {
        internal ScorpioZodiacModel(string name, string english, ZodiacDateModel start, ZodiacDateModel end)
               : base(name, english, start, end)
        {

        }

        internal static ScorpioZodiacModel GetScorpioModel()
        {
            return new ScorpioZodiacModel(ZodiacSigns.Scorpio.ToString(), "The Scorpion", new ZodiacDateModel(23, 10), new ZodiacDateModel(21, 11));
        }
    }
}
