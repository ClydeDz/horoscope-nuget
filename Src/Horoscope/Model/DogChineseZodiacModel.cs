namespace Horoscope.Model
{
    internal class DogChineseZodiacModel: ChineseZodiacModel
    {
        internal DogChineseZodiacModel(string name, string english, string personality)
               : base(name, english, personality)
        {

        }

        internal static DogChineseZodiacModel GetDogModel()
        {
            return new DogChineseZodiacModel("xū", "Dog", "Dog people are loyal & can always keep a secret. Sometimes they worry too much.");
        }
    }
}
