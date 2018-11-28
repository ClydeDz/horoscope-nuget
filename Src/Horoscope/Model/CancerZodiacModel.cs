namespace Horoscope.Model
{
    internal class CancerZodiacModel : ZodiacModel
    {
        internal CancerZodiacModel(string name, string english, ZodiacDateModel start, ZodiacDateModel end)
              : base(name, english, start, end)
        {

        }

        internal static CancerZodiacModel GetCancerModel()
        {
            return new CancerZodiacModel(ZodiacSigns.Cancer.ToString(), "The Crab", new ZodiacDateModel(21, 6), new ZodiacDateModel(22, 7));
        }
    }
}
