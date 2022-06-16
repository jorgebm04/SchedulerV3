using SchedulerV3.Calculate;

namespace SchedulerV3.Descriptions
{
    public static class MonthlyTheOnceDescription
    {
        public static void SetDescription(Settings settings)
        {
            if (!settings.IsOverLimit)
            {
                String freq = FreqSetter.SetFreq(settings);
                settings.Description = "Occurs the " + freq + " " + settings.DayOfTheWeek + " of every " + settings.NumMonths + " months." +
                    "Schedule will be used on " + settings.CalculatedDate.ToString("dd'/'MM'/'yyyy") + " at " +
                    settings.CalculatedDate.ToString("HH:mm") + " starting on " + settings.StartingLimit.ToString("dd'/'MM'/'yyyy");
            }
        }
    }
}
