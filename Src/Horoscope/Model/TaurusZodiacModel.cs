namespace Horoscope.Model
{
    internal class TaurusZodiacModel : ZodiacModel
    {
        internal TaurusZodiacModel(string name, string english, ZodiacDateModel start, ZodiacDateModel end)
              : base(name, english, start, end)
        {

        }

        internal static TaurusZodiacModel GetTaurusModel()
        {
            return new TaurusZodiacModel("Taurus", "The Bull", new ZodiacDateModel(20, 4), new ZodiacDateModel(20, 5));
        }
    }
}
