namespace SchedulerV3
{
    public static class CheckMonthlySettings
    {
        public static void CheckRecurrentMonthlySettings(Settings settings)
        {
            if (settings.the)
            {
                bool monthFreq = MonthFrequencyChecker.CheckMonthFrequency(settings.monthlyFreq);
                if (!monthFreq)
                {
                    settings.nextExecutionTime = "Select a frequency for the monthly frequency";
                    return;
                }
                bool daysFreq = DayFrequencyChecker.CheckDayFrequency(settings.dailyFreq);
                if (!daysFreq)
                {
                    settings.nextExecutionTime = "Select a frequency for the days frequency";
                    return;
                }
            } else if (!settings.day)
            {
                settings.nextExecutionTime = "Select a monthly configuration.";
                return;
            }
            CheckDailySettings.CheckRecurringDailySettings(settings);
        }
    }
}
