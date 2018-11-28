namespace Horoscope.Model
{
    internal class CapricornZodiacModel : ZodiacModel
    {
        internal CapricornZodiacModel(string name, string english, ZodiacDateModel start, ZodiacDateModel end)
               : base(name, english, start, end)
        {

        }

        internal static CapricornZodiacModel GetCapricornModel()
        {
            return new CapricornZodiacModel(ZodiacSigns.Capricorn.ToString(), "The Goat", new ZodiacDateModel(22, 12), new ZodiacDateModel(19, 1));
        }
    }
}
