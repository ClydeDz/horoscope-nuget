using System;
using System.Collections.Generic;
using System.Text;

namespace Horoscope.Model
{
    public class ZodiacDateModel
    {
        internal ZodiacDateModel(int date, int month)
        {
            Date = date;
            Month = month;
        }

        internal int Date { get; set; }
        internal int Month { get; set; }        
    }
}
