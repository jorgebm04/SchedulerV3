namespace SchedulerV3
{
    public static class MonthlyTheOnceDescription
    {
        public static void SetDescription(Settings settings)
        {
            String freq = FreqSetter.SetFreq(settings);
            settings.description = "Occurs the " + freq + " " + settings.dayOfTheWeek + " of every " + settings.numMonths + " months." +
                "Schedule will be used on " + settings.calculatedDate.ToString("dd'/'MM'/'yyyy") + " at " +
                settings.calculatedDate.ToString("HH:mm") + " starting on " + settings.startingLimit.ToString("dd'/'MM'/'yyyy"); ;
        }
    }
}
