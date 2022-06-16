namespace SchedulerV3.Checks
{
    public static class CheckMonthlySettings
    {
        public static void CheckRecurrentMonthlySettings(Settings settings)
        {
            if (settings.The)
            {
                bool monthFreq = MonthFrequencyChecker.CheckMonthFrequency(settings.MonthlyFreq);
                if (!monthFreq)
                {
                    settings.NextExecutionTime = "Select a frequency for the monthly frequency";
                    return;
                }
                bool daysFreq = DayFrequencyChecker.CheckDayFrequency(settings.DailyFreq);
                if (!daysFreq)
                {
                    settings.NextExecutionTime = "Select a frequency for the days frequency";
                    return;
                }
            } else if (!settings.Day)
            {
                settings.NextExecutionTime = "Select a monthly configuration.";
                return;
            }
            CheckDailySettings.CheckRecurringDailySettings(settings);
        }
    }
}
