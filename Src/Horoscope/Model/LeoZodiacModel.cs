namespace Horoscope.Model
{
    internal class LeoZodiacModel : ZodiacModel
    {
        internal LeoZodiacModel(string name, string english, ZodiacDateModel start, ZodiacDateModel end)
               : base(name, english, start, end)
        {

        }

        internal static LeoZodiacModel GetLeoModel()
        {
            return new LeoZodiacModel("Leo", "The Lion", new ZodiacDateModel(23, 7), new ZodiacDateModel(22, 8));
        }
    }
}
