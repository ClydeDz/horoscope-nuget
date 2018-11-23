using Horoscope.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Horoscope
{
    public enum ZodiacSymbols
    {
        Pisces,
        Aquarius
    }
    
    public class Zodiac
    {        
        public static ZodiacModel ConvertDateToZodiacSign(DateTime dateTime)
        {
            var symbols = GetAllZodiacSymbols().Values
                .Where(d => d.ZodiacStartDate.Month == dateTime.Month || d.ZodiacEndDate.Month == dateTime.Month)
                .Select(s => s)
                .FirstOrDefault();
            return symbols;
        }

        public static ZodiacModel GetZodiacSymbolDetails(ZodiacSymbols symbol)
        {
            GetAllZodiacSymbols().TryGetValue(symbol, out ZodiacModel zodiacSymbol);
            return zodiacSymbol;
        }

        public static List<ZodiacModel> GetAllZodiacSymbolDetails()
        {
            return GetAllZodiacSymbols().Values.ToList<ZodiacModel>();
        }

        internal static Dictionary<ZodiacSymbols, ZodiacModel> GetAllZodiacSymbols()
        {
            Dictionary<ZodiacSymbols, ZodiacModel> zodiacSymbols = new Dictionary<ZodiacSymbols, ZodiacModel>();
            zodiacSymbols.Add(ZodiacSymbols.Pisces, PiscesZodiacModel.GetPiscesModel());
            zodiacSymbols.Add(ZodiacSymbols.Aquarius, AquariusZodiacModel.GetAquariusModel());
            return zodiacSymbols;
        }
    }
}
