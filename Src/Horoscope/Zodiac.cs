using Horoscope.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Horoscope
{
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
    
    public class Zodiac
    {        
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

        public static ZodiacModel GetZodiacSign(ZodiacSigns requestedZodiacSign)
        {
            InitializeAndGetAllZodiacSigns().TryGetValue(requestedZodiacSign, out ZodiacModel zodiacSign);
            return zodiacSign;
        }

        public static List<ZodiacModel> GetAllZodiacSigns()
        {
            return InitializeAndGetAllZodiacSigns().Values.ToList();
        }

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
