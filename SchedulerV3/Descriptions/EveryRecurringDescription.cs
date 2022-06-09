namespace SchedulerV3
{
    public static class EveryRecurringDescription
    {
        public static void SetDescription(Settings settings)
        {
            string description = "Occurs every day. Schedule will be used on " + settings.calculatedDate.ToString("dd'/'MM'/'yyyy") + " at " +
                settings.calculatedDate.ToString("HH:mm") + " every " + settings.occursEveryFreq + " " + settings.freqTime + " starting on " + settings.startingLimit.ToString("dd'/'MM'/'yyyy");
            settings.description = description;
        }
    }
}
