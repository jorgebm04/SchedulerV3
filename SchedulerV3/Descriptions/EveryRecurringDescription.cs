namespace SchedulerV3
{
    public static class EveryRecurringDescription
    {
        public static void SetDescription(Settings settings)
        {
            string description = "Occurs every day. Schedule will be used on " + settings.CalculatedDate.ToString("dd'/'MM'/'yyyy") + " at " +
                settings.CalculatedDate.ToString("HH:mm") + " every " + settings.OccursEveryFreq + " " + settings.FreqTime + " starting on " + settings.StartingLimit.ToString("dd'/'MM'/'yyyy");
            settings.Description = description;
        }
    }
}
