namespace SchedulerV3
{
    public static class MonthlyTheEveryDescription
    {
        public static void SetDescription(Settings settings)
        {
            if (!settings.IsOverLimit)
            {
                String freq = FreqSetter.SetFreq(settings);

                settings.Description = "Occurs the " + freq + " " + settings.DayOfTheWeek + " of every " + settings.NumMonths +
                    " months. Schedule will be used on " + settings.CalculatedDate.ToString("dd'/'MM'/'yyyy") + " at " +
                    settings.CalculatedDate.ToString("HH:mm") + " every " + settings.OccursEveryFreq + " " + settings.FreqTime + " starting on " + settings.StartingLimit.ToString("dd'/'MM'/'yyyy");
            }           
        }
    }
}
