namespace Horoscope.Model
{
    internal class VirgoZodiacModel : ZodiacModel
    {
        internal VirgoZodiacModel(string name, string english, ZodiacDateModel start, ZodiacDateModel end)
               : base(name, english, start, end)
        {

        }

        internal static VirgoZodiacModel GetVirgoModel()
        {
            return new VirgoZodiacModel(ZodiacSigns.Virgo.ToString(), "The Virgin", new ZodiacDateModel(23, 8), new ZodiacDateModel(22, 9));
        }
    }
}
