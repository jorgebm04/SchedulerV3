namespace SchedulerV3
{
    public static class CheckDailySettings
    {
        public static void CheckRecurringDailySettings(Settings settings)
        {
            if (settings.occursOnceAt)
            {
                settings.needToAddDay = NeedToAddDaysChecker.CheckNeedToAddDays(settings.currentDate, settings.occursOnceAtHour);
            } else if (settings.occursEvery)
            {
                settings.needToAddDay = NeedToAddDaysChecker.CheckNeedToAddDays(settings.currentDate, settings.endingHour);
                bool freq = CheckOccursEveryFreq(settings);
                if (!freq)
                {
                    settings.nextExecutionTime = "Select a frequency for the daily frequency";
                    return;
                }
                bool freqLimits = CheckOccursEveryLimits(settings);
                if (!freqLimits)
                {
                    settings.nextExecutionTime = "Limits in the daily frequency not correct";
                    return;
                }
            }
            else
            {
                settings.nextExecutionTime = "Select a type for daily frequency.";
                return;
            }
            CheckLimits(settings);
        }

        public static bool CheckOccursEveryFreq(Settings settings)
        {
            bool occurs = OccursEveryChecker.CheckOccursEveryComboBox(settings.freq);
            return occurs;
        }

        public static bool CheckOccursEveryLimits(Settings settings)
        {
            bool occursLimits = OccursEveryChecker.CheckOccursEveryLimits(settings.startingHour, settings.endingHour);
            return occursLimits;
        }

        public static void CheckLimits(Settings settings)
        {
            bool limits = RecurringLimitsChecker.CheckLimits(settings.startingLimit, settings.endingLimit);
            if (!limits)
            {
                settings.nextExecutionTime = "Not correct limits";
                return;
            }
            bool currentDateInLimits = RecurringLimitsChecker.CheckLimitsWithCurrentDate(settings.startingLimit, settings.endingLimit, settings.currentDate);
            if (!currentDateInLimits)
            {
                settings.nextExecutionTime = "Current date not in the limits";
                return;
            }
            settings.nextExecutionTime = "";
        }
    }
}
