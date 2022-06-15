namespace SchedulerV3
{
    public static class CalculateMonthlyTheOnceRecurring
    {
        public static void CalculateNextExecutionTime(Settings settings)
        {   
            int rest = settings.CurrentDate.Month % settings.Monthly2Freq;
            if (rest != 0)
            {
                ReturnDate(settings, rest);
            }
            else
            {
                DateTime calculatedDate = CalculateNewDay.CalNewDate(settings);
                if (DateTime.Compare(calculatedDate, settings.CurrentDate) > 0)
                {
                    ReturnNormalDate(settings, calculatedDate);
                }
                else if (calculatedDate.ToString("dd/MM/yyyy").Equals(settings.CurrentDate.ToString("dd/MM/yyyy")))
                {
                    if (TimeSpan.Compare(settings.CurrentDate.TimeOfDay, settings.OccursOnceAtHour.TimeOfDay) < 0)
                    {
                        ReturnNormalDate(settings, calculatedDate);
                    }
                    else
                    {
                        ReturnAddedDate(settings, calculatedDate);
                    }
                }
                else
                {
                    ReturnAddedDate(settings, calculatedDate);
                }
            }        
        }

        public static void ReturnDate(Settings settings, int rest)
        {
            int newMonth = (settings.CurrentDate.Month - rest) + settings.Monthly2Freq;
            settings.CurrentDate = new DateTime(settings.CurrentDate.Year, newMonth, 1,
                settings.OccursOnceAtHour.Hour, settings.OccursOnceAtHour.Minute, settings.OccursOnceAtHour.Second);
            DateTime calDate = CalculateNewDay.CalNewDate(settings);
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

        public static void ReturnNormalDate(Settings settings, DateTime calculated)
        {
            DateTime calDate = new (settings.CurrentDate.Year, settings.CurrentDate.Month, calculated.Day,
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

        public static void ReturnAddedDate(Settings settings, DateTime calculated)
        {
            settings.CurrentDate = calculated.AddMonths(settings.Monthly2Freq);
            DateTime calDate = CalculateNewDay.CalNewDate(settings);
            bool inLimits = OverLimitsChecker.CheckInLimits(calDate, settings.EndingLimit);
            if (!inLimits)
            {
                settings.NextExecutionTime = "Next execution over end date limits";
                settings.IsOverLimit = true;
                return;
            }
            DateTime newDate = new (calDate.Year,calDate.Month,calDate.Day,
                settings.OccursOnceAtHour.Hour,settings.OccursOnceAtHour.Minute,settings.OccursOnceAtHour.Second);
            settings.CalculatedDate = newDate;
            settings.NextExecutionTime = settings.CalculatedDate.ToString("dd/MM/yyyy HH:mm");
        }
    }
}

