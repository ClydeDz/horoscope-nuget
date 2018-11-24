using Horoscope.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Horoscope
{
    public enum ZodiacSymbols
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
        public static ZodiacModel ConvertDateToZodiacSign(DateTime inputDateTime)
        {
            var zodiacSymbol = GetAllZodiacSymbols().Values
                .Where(d => 
                    (d.ZodiacStartDate.Month == inputDateTime.Month && inputDateTime.Day > d.ZodiacStartDate.Date) 
                    || (d.ZodiacEndDate.Month == inputDateTime.Month && inputDateTime.Day < d.ZodiacEndDate.Date))                
                .Select(s => s)
                .FirstOrDefault();
            return zodiacSymbol;
        }

        public static ZodiacModel GetZodiacSymbolDetails(ZodiacSymbols symbol)
        {
            GetAllZodiacSymbols().TryGetValue(symbol, out ZodiacModel zodiacSymbol);
            return zodiacSymbol;
        }

        public static List<ZodiacModel> GetAllZodiacSymbolDetails()
        {
            return GetAllZodiacSymbols().Values.ToList();
        }

        internal static Dictionary<ZodiacSymbols, ZodiacModel> GetAllZodiacSymbols()
        {
            Dictionary<ZodiacSymbols, ZodiacModel> zodiacSymbols = new Dictionary<ZodiacSymbols, ZodiacModel>();
            zodiacSymbols.Add(ZodiacSymbols.Pisces, PiscesZodiacModel.GetPiscesModel());
            zodiacSymbols.Add(ZodiacSymbols.Aquarius, AquariusZodiacModel.GetAquariusModel());
            zodiacSymbols.Add(ZodiacSymbols.Leo, LeoZodiacModel.GetLeoModel());
            zodiacSymbols.Add(ZodiacSymbols.Taurus, TaurusZodiacModel.GetTaurusModel());
            zodiacSymbols.Add(ZodiacSymbols.Scorpio, ScorpioZodiacModel.GetScorpioModel());
            zodiacSymbols.Add(ZodiacSymbols.Sagittarius, SagittariusZodiacModel.GetSagittariusModel());
            zodiacSymbols.Add(ZodiacSymbols.Aries, AriesZodiacModel.GetAriesModel());
            zodiacSymbols.Add(ZodiacSymbols.Gemini, GeminiZodiacModel.GetGeminiModel());
            zodiacSymbols.Add(ZodiacSymbols.Capricorn, CapricornZodiacModel.GetCapricornModel());
            zodiacSymbols.Add(ZodiacSymbols.Libra, LibraZodiacModel.GetLibraModel());
            zodiacSymbols.Add(ZodiacSymbols.Virgo, VirgoZodiacModel.GetVirgoModel());
            zodiacSymbols.Add(ZodiacSymbols.Cancer, CancerZodiacModel.GetCancerModel());
            return zodiacSymbols;
        }
    }
}
