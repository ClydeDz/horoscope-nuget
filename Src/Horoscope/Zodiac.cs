using Horoscope.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Horoscope
{
    /// <summary>
    /// List of all Zodiac signs
    /// </summary>
    public enum ZodiacSigns
    {
        Pisces,
        Aquarius,
        Virgo,
        Taurus,
        Scorpio,
        Sagittarius,
        Libra,
        Leo,
        Gemini,
        Capricorn,
        Cancer,
        Aries
    }
    
    /// <summary>
    /// Contains all methods pertaining to Zodiac signs.
    /// </summary>
    public class Zodiac
    {        
        /// <summary>
        /// Gets the Zodiac sign for the date supplied.
        /// </summary>
        /// <param name="requestedDateTime">The date for which you want the Zodiac sign.</param>
        /// <returns>A Zodiac sign object.</returns>
        public static ZodiacModel GetZodiacSignForDate(DateTime requestedDateTime)
        {
            var zodiacSymbol = InitializeAndGetAllZodiacSigns().Values
                .Where(d => 
                    (d.ZodiacStartDate.Month == requestedDateTime.Month && requestedDateTime.Day >= d.ZodiacStartDate.Date) 
                    || (d.ZodiacEndDate.Month == requestedDateTime.Month && requestedDateTime.Day <= d.ZodiacEndDate.Date))                
                .Select(s => s)
                .FirstOrDefault();
            return zodiacSymbol;
        }

        /// <summary>
        /// Get details of the Zodiac sign supplied.
        /// </summary>
        /// <param name="requestedZodiacSign">The Zodiac sign that you want more details about.</param>
        /// <returns>A Zodiac sign object.</returns>
        public static ZodiacModel GetZodiacSign(ZodiacSigns requestedZodiacSign)
        {
            InitializeAndGetAllZodiacSigns().TryGetValue(requestedZodiacSign, out ZodiacModel zodiacSign);
            return zodiacSign;
        }

        /// <summary>
        /// Gets all Zodiac signs and details for each sign.
        /// </summary>
        /// <returns>List of Zodiac signs each as a Zodiac sign object.</returns>
        public static List<ZodiacModel> GetAllZodiacSigns()
        {
            return InitializeAndGetAllZodiacSigns().Values.ToList();
        }

        /// <summary>
        /// Loads all Zodiac signs and returns a complete object.
        /// </summary>
        /// <returns>Dictionary collection of Zodiac signs.</returns>
        private static Dictionary<ZodiacSigns, ZodiacModel> InitializeAndGetAllZodiacSigns()
        {
            Dictionary<ZodiacSigns, ZodiacModel> zodiacSigns = new Dictionary<ZodiacSigns, ZodiacModel>
            {
                { ZodiacSigns.Pisces, PiscesZodiacModel.GetPiscesModel() },
                { ZodiacSigns.Aquarius, AquariusZodiacModel.GetAquariusModel() },
                { ZodiacSigns.Leo, LeoZodiacModel.GetLeoModel() },
                { ZodiacSigns.Taurus, TaurusZodiacModel.GetTaurusModel() },
                { ZodiacSigns.Scorpio, ScorpioZodiacModel.GetScorpioModel() },
                { ZodiacSigns.Sagittarius, SagittariusZodiacModel.GetSagittariusModel() },
                { ZodiacSigns.Aries, AriesZodiacModel.GetAriesModel() },
                { ZodiacSigns.Gemini, GeminiZodiacModel.GetGeminiModel() },
                { ZodiacSigns.Capricorn, CapricornZodiacModel.GetCapricornModel() },
                { ZodiacSigns.Libra, LibraZodiacModel.GetLibraModel() },
                { ZodiacSigns.Virgo, VirgoZodiacModel.GetVirgoModel() },
                { ZodiacSigns.Cancer, CancerZodiacModel.GetCancerModel() }
            };
            return zodiacSigns;
        }
    }
}
