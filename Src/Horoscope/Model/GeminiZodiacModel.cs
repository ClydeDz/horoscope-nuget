namespace Horoscope.Model
{
    internal class GeminiZodiacModel : ZodiacModel
    {
        internal GeminiZodiacModel(string name, string english, ZodiacDateModel start, ZodiacDateModel end)
               : base(name, english, start, end)
        {

        }

        internal static GeminiZodiacModel GetGeminiModel()
        {
            return new GeminiZodiacModel(ZodiacSigns.Gemini.ToString(), "The Twins", new ZodiacDateModel(21, 5), new ZodiacDateModel(20, 6));
        }
    }
}
