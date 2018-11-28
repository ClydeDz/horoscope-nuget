namespace Horoscope.Model
{
    internal class PiscesZodiacModel : ZodiacModel
    {
        internal PiscesZodiacModel(string name, string english, ZodiacDateModel start, ZodiacDateModel end)
            : base(name, english, start, end)
        {

        }

        internal static PiscesZodiacModel GetPiscesModel()
        {
            return new PiscesZodiacModel(ZodiacSigns.Pisces.ToString(), "The Fish", new ZodiacDateModel(19, 2), new ZodiacDateModel(20, 3));
        }
    }
}
