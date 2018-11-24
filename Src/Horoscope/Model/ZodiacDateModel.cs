namespace Horoscope.Model
{
    internal class ZodiacDateModel
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
