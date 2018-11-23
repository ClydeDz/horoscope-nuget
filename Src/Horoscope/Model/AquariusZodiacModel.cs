using System;
using System.Collections.Generic;
using System.Text;

namespace Horoscope.Model
{
    internal class AquariusZodiacModel : ZodiacModel
    {
        internal AquariusZodiacModel(string name, string english, ZodiacDateModel start, ZodiacDateModel end)
               : base(name, english, start, end)
        {

        }

        internal static AquariusZodiacModel GetAquariusModel()
        {
            return new AquariusZodiacModel("Aquarius", "The Water-Bearer", new ZodiacDateModel(1, 1), new ZodiacDateModel(21, 3));
        }
    }
}
