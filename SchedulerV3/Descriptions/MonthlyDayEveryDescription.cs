namespace SchedulerV3
{
    public static class MonthlyDayEveryDescription
    {
        public static void SetDescription(Settings settings)
        {
            if (!settings.isOverLimit)
            {
                settings.description = "Occurs every " + settings.numDay + "day every " + settings.numMonths + ". Schedule will be used on " + settings.calculatedDate.ToString("dd'/'MM'/'yyyy") + " at " +
                settings.calculatedDate.ToString("HH:mm") + " every " + settings.occursEveryFreq + " " + settings.freqTime + " starting on " + settings.startingLimit.ToString("dd'/'MM'/'yyyy");
            }
        }           
    }
}
