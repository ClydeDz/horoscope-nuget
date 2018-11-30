namespace Horoscope.Model
{
    internal class DogChineseZodiacModel: ChineseZodiacModel
    {
        internal DogChineseZodiacModel(string name, string english, string personality, ChineseZodiacElements chineseZodiacFixedElement, YinYang yinYang)
               : base(name, english, personality, chineseZodiacFixedElement, yinYang)
        {

        }

        internal static DogChineseZodiacModel GetDogModel()
        {
            return new DogChineseZodiacModel(
                "gòu", 
                ChineseZodiacSigns.Dog.ToString(), 
                "Dog people are loyal & can always keep a secret. Sometimes they worry too much.", 
                ChineseZodiacElements.Earth,
                YinYang.Yang);
        }
    }
}
