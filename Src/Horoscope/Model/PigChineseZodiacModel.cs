namespace Horoscope.Model
{
    internal class PigChineseZodiacModel: ChineseZodiacModel
    {
        internal PigChineseZodiacModel(string name, string english, string personality)
                  : base(name, english, personality)
        {

        }

        internal static PigChineseZodiacModel GetPigModel()
        {
            return new PigChineseZodiacModel("hài", "Pig", "Pig	people are very good students. They are honest & brave.They always finish a project or assignment.");
        }
    }
}
