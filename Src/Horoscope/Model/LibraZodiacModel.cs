namespace Horoscope.Model
{
    internal class LibraZodiacModel : ZodiacModel
    {
        internal LibraZodiacModel(string name, string english, ZodiacDateModel start, ZodiacDateModel end)
             : base(name, english, start, end)
        {

        }

        internal static LibraZodiacModel GetLibraModel()
        {
            return new LibraZodiacModel(ZodiacSigns.Libra.ToString(), "The Scales", new ZodiacDateModel(23, 9), new ZodiacDateModel(22, 10));
        }
    }
}
