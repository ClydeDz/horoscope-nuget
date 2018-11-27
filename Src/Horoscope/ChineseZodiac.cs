using Horoscope.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Horoscope
{
    public enum ChineseZodiacSigns
    {
        Rat,
        Ox,
        Tiger,
        Rabbit,
        Dragon,
        Snake,
        Horse,
        Goat,
        Monkey,
        Rooster,
        Dog,
        Pig
    }

    public enum ChineseZodiacElements
    {
        Wood,
        Fire,
        Earth,
        Metal,
        Water
    }

    public class ChineseZodiac
    {
        public static ChineseZodiacModel GetChineseZodiacAnimal(DateTime requestedDateTime)
        {
            ChineseZodiacSigns chineseZodiacSign = Get(requestedDateTime.Year);
            InitializeAndGetAllZodiacSigns().TryGetValue(chineseZodiacSign, out ChineseZodiacModel chineseZodiacModel);
            return chineseZodiacModel;
        }

        /// <summary>
        /// Get details of the Zodiac sign supplied.
        /// </summary>
        /// <param name="requestedZodiacSign">The Zodiac sign that you want more details about.</param>
        /// <returns>A Zodiac sign object.</returns>
        public static ChineseZodiacModel GetZodiacSign(ChineseZodiacSigns requestedZodiacSign)
        {
            InitializeAndGetAllZodiacSigns().TryGetValue(requestedZodiacSign, out ChineseZodiacModel zodiacSign);
            return zodiacSign;
        }

        /// <summary>
        /// Gets all Zodiac signs and details for each sign.
        /// </summary>
        /// <returns>List of Zodiac signs each as a Zodiac sign object.</returns>
        public static List<ChineseZodiacModel> GetAllZodiacSigns()
        {
            return InitializeAndGetAllZodiacSigns().Values.ToList();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        /// <remarks>
        /// Math credits: https://stackoverflow.com/a/22047886
        /// </remarks>
        internal static ChineseZodiacSigns Get(int year)
        {
            int a = (year - 4);
            int b = (a / 12) * 12;
            return (ChineseZodiacSigns)(a - b);
        }

        /// <summary>
        /// Loads all Zodiac signs and returns a complete object.
        /// </summary>
        /// <returns>Dictionary collection of Zodiac signs.</returns>
        private static Dictionary<ChineseZodiacSigns, ChineseZodiacModel> InitializeAndGetAllZodiacSigns()
        {
            Dictionary<ChineseZodiacSigns, ChineseZodiacModel> zodiacSigns = new Dictionary<ChineseZodiacSigns, ChineseZodiacModel>
            {
                { ChineseZodiacSigns.Rat, RatChineseZodiacModel.GetRatModel() },
                { ChineseZodiacSigns.Ox, OxChineseZodiacModel.GetOxModel() },
                { ChineseZodiacSigns.Tiger, TigerChineseZodiacModel.GetTigerModel() },
                { ChineseZodiacSigns.Rabbit, RabbitChineseZodiacModel.GetRabbitModel() },
                { ChineseZodiacSigns.Dragon, DragonChineseZodiacModel.GetDragonModel() },
                { ChineseZodiacSigns.Snake, SnakeChineseZodiacModel.GetSnakeModel() },
                { ChineseZodiacSigns.Horse, HorseChineseZodiacModel.GetHorseModel() },
                { ChineseZodiacSigns.Goat, GoatChineseZodiacModel.GetGoatModel() },
                { ChineseZodiacSigns.Monkey, MonkeyChineseZodiacModel.GetMonkeyModel() },
                { ChineseZodiacSigns.Rooster, RoosterChineseZodiacModel.GetRoosterModel() },
                { ChineseZodiacSigns.Dog, DogChineseZodiacModel.GetDogModel() },
                { ChineseZodiacSigns.Pig, PigChineseZodiacModel.GetPigModel() }
            };
            return zodiacSigns;      
        }
    }
}
