namespace Horoscope.Model
{
    internal class AriesZodiacModel : ZodiacModel
    {
        internal AriesZodiacModel(string name, string english, ZodiacDateModel start, ZodiacDateModel end)
              : base(name, english, start, end)
        {

        }

        internal static AriesZodiacModel GetAriesModel()
        {
            return new AriesZodiacModel(ZodiacSigns.Aries.ToString(), "The Ram", new ZodiacDateModel(21, 3), new ZodiacDateModel(19, 4));
        }
    }
}
