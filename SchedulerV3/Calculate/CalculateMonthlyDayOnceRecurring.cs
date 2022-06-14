namespace SchedulerV3
{
    public static class CalculateMonthlyDayOnceRecurring
    {
        public static void CalculateNextExecutionTime(Settings settings)
        {
            int rest = settings.CurrentDate.Month % settings.NumMonths;
            if ( rest != 0)
            {
                ReturnDate(settings, rest);
            } 
            else
            {
                if (settings.NumDay > settings.CurrentDate.Day)
                {
                    ReturnNormalDate(settings);
                } 
                else if (settings.NumDay == settings.CurrentDate.Day)
                {
                    if (TimeSpan.Compare(settings.CurrentDate.TimeOfDay, settings.OccursOnceAtHour.TimeOfDay) < 0)
                    {
                        ReturnNormalDate(settings);
                        return;
                    }
                    if (TimeSpan.Compare(settings.CurrentDate.TimeOfDay, settings.OccursOnceAtHour.TimeOfDay) > 0)
                    {
                        ReturnAddedDate(settings);
                        return;
                    }
                }
                else
                {
                    ReturnAddedDate(settings);
                    return;
                }
            }
        }

        public static void ReturnDate(Settings settings, int rest)
        {
            int newMonth = (settings.CurrentDate.Month - rest) + settings.NumMonths;
            DateTime calDate = new (settings.CurrentDate.Year, newMonth, settings.NumDay,
                    settings.OccursOnceAtHour.Hour, settings.OccursOnceAtHour.Minute, settings.OccursOnceAtHour.Second);
            bool inLimits = OverLimitsChecker.CheckInLimits(calDate, settings.EndingLimit);
            if (!inLimits)
            {
                settings.NextExecutionTime = "Next execution over end date limits";
                settings.IsOverLimit = true;
                return;
            }
            settings.CalculatedDate = calDate;
            settings.NextExecutionTime = settings.CalculatedDate.ToString("dd/MM/yyyy HH:mm");
        }

        public static void ReturnNormalDate(Settings settings)
        {
            DateTime calDate = new (settings.CurrentDate.Year, settings.CurrentDate.Month, settings.NumDay,
                    settings.OccursOnceAtHour.Hour, settings.OccursOnceAtHour.Minute, settings.OccursOnceAtHour.Second);
            bool inLimits = OverLimitsChecker.CheckInLimits(calDate, settings.EndingLimit);
            if (!inLimits)
            {
                settings.NextExecutionTime = "Next execution over end date limits";
                settings.IsOverLimit = true;
                return;
            }
            settings.CalculatedDate = calDate;
            settings.NextExecutionTime = settings.CalculatedDate.ToString("dd/MM/yyyy HH:mm");
        }

        public static void ReturnAddedDate(Settings settings)
        {
            DateTime calDate = new (settings.CurrentDate.Year, settings.CurrentDate.Month, settings.NumDay,
                    settings.OccursOnceAtHour.Hour, settings.OccursOnceAtHour.Minute, settings.OccursOnceAtHour.Second);
            calDate = calDate.AddMonths(settings.NumMonths);
            bool inLimits = OverLimitsChecker.CheckInLimits(calDate, settings.EndingLimit);
            if (!inLimits)
            {
                settings.NextExecutionTime = "Next execution over end date limits";
                settings.IsOverLimit = true;
                return;
            }
            settings.CalculatedDate = calDate;
            settings.NextExecutionTime = settings.CalculatedDate.ToString("dd/MM/yyyy HH:mm");
        }
    }
}
