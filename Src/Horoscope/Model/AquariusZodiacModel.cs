namespace Horoscope.Model
{
    internal class AquariusZodiacModel : ZodiacModel
    {
        internal AquariusZodiacModel(string name, string english, ZodiacDateModel start, ZodiacDateModel end)
               : base(name, english, start, end)
        {

        }

        internal static AquariusZodiacModel GetAquariusModel()
        {
            return new AquariusZodiacModel(ZodiacSigns.Aquarius.ToString(), "The Water-Bearer", new ZodiacDateModel(20, 1), new ZodiacDateModel(18, 2));
        }
    }
}
