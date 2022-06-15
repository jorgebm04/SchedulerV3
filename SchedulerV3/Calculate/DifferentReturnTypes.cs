namespace SchedulerV3
{
    public static class DifferentReturnTypes
    {
        public static bool ReturnDateThe(Settings settings, int rest)
        {
            int newMonth = (settings.CurrentDate.Month - rest) + settings.Monthly2Freq;
            if (settings.OccursOnceAt)
            {
                settings.CurrentDate = new DateTime(settings.CurrentDate.Year, newMonth, 1,
                settings.OccursOnceAtHour.Hour, settings.OccursOnceAtHour.Minute, settings.OccursOnceAtHour.Second);
            } else 
            {
                settings.CurrentDate = new DateTime(settings.CurrentDate.Year, newMonth, 1,
                settings.StartingHour.Hour, settings.StartingHour.Minute, settings.StartingHour.Second);
            }
            DateTime calDate = CalculateNewDay.CalNewDate(settings);
            bool inLimits = OverLimitsChecker.CheckInLimits(calDate, settings.EndingLimit);
            if (!inLimits)
            {
                settings.NextExecutionTime = "Next execution over end date limits";
                settings.IsOverLimit = true;
                return false;
            }
            settings.CalculatedDate = calDate;
            settings.NextExecutionTime = settings.CalculatedDate.ToString("dd/MM/yyyy HH:mm");
            return true;
        }

        public static bool ReturnNormalDateThe(Settings settings, DateTime calculated)
        {
            DateTime calDate;
            if (settings.OccursOnceAt)
            {
                calDate = new(settings.CurrentDate.Year, settings.CurrentDate.Month, calculated.Day,
                    settings.OccursOnceAtHour.Hour, settings.OccursOnceAtHour.Minute, settings.OccursOnceAtHour.Second);
            } else 
            {
                calDate = new(settings.CurrentDate.Year, settings.CurrentDate.Month, calculated.Day,
                settings.StartingHour.Hour, settings.StartingHour.Minute, settings.StartingHour.Second);
            }
            
            bool inLimits = OverLimitsChecker.CheckInLimits(calDate, settings.EndingLimit);
            if (!inLimits)
            {
                settings.NextExecutionTime = "Next execution over end date limits";
                settings.IsOverLimit = true;
                return false;
            }
            settings.CalculatedDate = calDate;
            settings.NextExecutionTime = settings.CalculatedDate.ToString("dd/MM/yyyy HH:mm");
            return true;
        }

        public static bool ReturnAddedDateThe(Settings settings, DateTime calculated)
        {
            settings.CurrentDate = calculated.AddMonths(settings.Monthly2Freq);
            DateTime calDate = CalculateNewDay.CalNewDate(settings);
            bool inLimits = OverLimitsChecker.CheckInLimits(calDate, settings.EndingLimit);
            if (!inLimits)
            {
                settings.NextExecutionTime = "Next execution over end date limits";
                settings.IsOverLimit = true;
                return false;
            }
            DateTime newDate;
            if (settings.OccursOnceAt)
            {
                newDate = new(calDate.Year, calDate.Month, calDate.Day,
                settings.OccursOnceAtHour.Hour, settings.OccursOnceAtHour.Minute, settings.OccursOnceAtHour.Second);
            }
            else
            {
                newDate = new(calDate.Year, calDate.Month, calDate.Day,
                settings.StartingHour.Hour, settings.StartingHour.Minute, settings.StartingHour.Second);
            }
            settings.CalculatedDate = newDate;
            settings.NextExecutionTime = settings.CalculatedDate.ToString("dd/MM/yyyy HH:mm");
            return true;
        }
    }
}
