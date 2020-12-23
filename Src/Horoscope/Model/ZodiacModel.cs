namespace Horoscope.Model
{
    /// <summary>
    /// The zodiac sign object containing information on each zodiac sign.
    /// </summary>
    public class ZodiacModel: BaseZodiacModel
    {
        internal ZodiacModel(string name, string english, ZodiacDateModel start, ZodiacDateModel end)
            :base(name, english)
        {
            ZodiacStartDate = start;
            ZodiacEndDate = end;
        }

        /// <summary>
        /// The duration for this zodiac sign.
        /// Example: December 22 to January 19.
        /// </summary>
        public string ZodiacDuration { get { return $"{ToMonth(ZodiacStartDate.Month)} {ZodiacStartDate.Date} to {ToMonth(ZodiacEndDate.Month)} {ZodiacEndDate.Date}"; } }

        internal ZodiacDateModel ZodiacStartDate { get; set; }

        internal ZodiacDateModel ZodiacEndDate { get; set; }

        internal string ToMonth(int month)
        {
            switch (month)
            {
                case 1:
                    return "January";
                case 2:
                    return "February";
                case 3:
                    return "March";
                case 4:
                    return "April";
                case 5:
                    return "May";
                case 6:
                    return "June";
                case 7:
                    return "July";
                case 8:
                    return "August";
                case 9:
                    return "September";
                case 10:
                    return "October";
                case 11:
                    return "November";
                case 12:
                    return "December";
                default:
                    return "January";
            }
        }
    }  
}
