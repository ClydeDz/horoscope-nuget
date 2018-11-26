namespace Horoscope.Model
{
    internal class RoosterChineseZodiacModel: ChineseZodiacModel
    {
        internal RoosterChineseZodiacModel(string name, string english, string personality)
                  : base(name, english, personality)
        {

        }

        internal static RoosterChineseZodiacModel GetRoosterModel()
        {
            return new RoosterChineseZodiacModel("yǒu", "Rooster", "Rooster	people are hardworkers. They have many talents & think deep thoughts.");
        }
    }
}
