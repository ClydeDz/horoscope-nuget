using Horoscope.Model;
using System.Collections.Generic;

namespace Horoscope.Helpers
{
    internal class ZodiacHelper
    {
        /// <summary>
        /// Loads all zodiac signs and returns a complete object.
        /// </summary>
        /// <returns>Dictionary collection of zodiac signs.</returns>
        internal static Dictionary<ZodiacSigns, ZodiacModel> InitializeAndGetAllZodiacSigns()
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
