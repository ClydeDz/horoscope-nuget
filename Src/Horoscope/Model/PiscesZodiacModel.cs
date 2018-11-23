using System;
using System.Collections.Generic;
using System.Text;

namespace Horoscope.Model
{
    internal class PiscesZodiacModel : ZodiacModel
    {
        internal PiscesZodiacModel(string name, string english, ZodiacDateModel start, ZodiacDateModel end)
            : base(name, english, start, end)
        {

        }

        internal static PiscesZodiacModel GetPiscesModel()
        {
            return new PiscesZodiacModel("Pisces", "The Fish", new ZodiacDateModel(21, 3), new ZodiacDateModel(5, 6));
        }
    }
}
