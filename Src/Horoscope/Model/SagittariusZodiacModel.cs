namespace Horoscope.Model
{
    internal class SagittariusZodiacModel : ZodiacModel
    {
        internal SagittariusZodiacModel(string name, string english, ZodiacDateModel start, ZodiacDateModel end)
              : base(name, english, start, end)
        {

        }

        internal static SagittariusZodiacModel GetSagittariusModel()
        {
            return new SagittariusZodiacModel(ZodiacSigns.Sagittarius.ToString(), "The Archer", new ZodiacDateModel(22, 11), new ZodiacDateModel(21, 12));
        }
    }
}
