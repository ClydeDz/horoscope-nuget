namespace Horoscope.Model
{
    internal class PigChineseZodiacModel: ChineseZodiacModel
    {
        internal PigChineseZodiacModel(string name, string english, string personality, ChineseZodiacElements chineseZodiacFixedElement, YinYang yinYang)
                  : base(name, english, personality, chineseZodiacFixedElement, yinYang)
        {

        }

        internal static PigChineseZodiacModel GetPigModel()
        {
            return new PigChineseZodiacModel(
                "zhū", 
                ChineseZodiacSigns.Pig.ToString(), 
                "Pig people are very good students. They are honest & brave.They always finish a project or assignment.", 
                ChineseZodiacElements.Water,
                YinYang.Yin);
        }
    }
}
