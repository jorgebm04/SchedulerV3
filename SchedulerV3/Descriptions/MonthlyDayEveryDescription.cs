namespace SchedulerV3.Descriptions
{
    public static class MonthlyDayEveryDescription
    {
        public static void SetDescription(Settings settings)
        {
            if (!settings.IsOverLimit)
            {
                settings.Description = "Occurs every " + settings.NumDay + "day every " + settings.NumMonths + ". Schedule will be used on " + settings.CalculatedDate.ToString("dd'/'MM'/'yyyy") + " at " +
                settings.CalculatedDate.ToString("HH:mm") + " every " + settings.OccursEveryFreq + " " + settings.FreqTime + " starting on " + settings.StartingLimit.ToString("dd'/'MM'/'yyyy");
            }
        }           
    }
}
