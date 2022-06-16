using SchedulerV3.Checks;

namespace SchedulerV3.Calculate
{
    public static class DifferentReturnTypes
    {
        public static void ReturnDateThe(Settings settings, int rest)
        {
            int newMonth;
            if (settings.Day)
            {
                newMonth = (settings.CurrentDate.Month - rest) + settings.NumMonths;
            }
            else
            {
                newMonth = (settings.CurrentDate.Month - rest) + settings.Monthly2Freq;
            }
            if (settings.OccursOnceAt)
            {             
                settings.CurrentDate = new DateTime(settings.CurrentDate.Year, newMonth, 1,
                settings.OccursOnceAtHour.Hour, settings.OccursOnceAtHour.Minute, settings.OccursOnceAtHour.Second);
            } 
            else 
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
                return;
            }
            settings.CalculatedDate = calDate;
            settings.NextExecutionTime = settings.CalculatedDate.ToString("dd/MM/yyyy HH:mm");
        }

        public static void ReturnNormalDateThe(Settings settings, DateTime calculated)
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
                return;
            }
            settings.CalculatedDate = calDate;
            settings.NextExecutionTime = settings.CalculatedDate.ToString("dd/MM/yyyy HH:mm");
        }

        public static void ReturnAddedDateThe(Settings settings, DateTime calculated)
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
        }

        public static void ReturnDateDay(Settings settings, int rest)
        {
            int newMonth;
            if (settings.Day)
            {
                newMonth = (settings.CurrentDate.Month - rest) + settings.NumMonths;
            }
            else
            {
                newMonth = (settings.CurrentDate.Month - rest) + settings.Monthly2Freq;
            }
            DateTime calDate;
            if (settings.OccursOnceAt)
            {
                calDate = new DateTime(settings.CurrentDate.Year, newMonth, settings.NumDay,
                settings.OccursOnceAtHour.Hour, settings.OccursOnceAtHour.Minute, settings.OccursOnceAtHour.Second);
            }
            else
            {
                calDate = new DateTime(settings.CurrentDate.Year, newMonth, settings.NumDay,
                settings.StartingHour.Hour, settings.StartingHour.Minute, settings.StartingHour.Second);
            }
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

        public static void ReturnNormalDateDay(Settings settings)
        {
            DateTime calDate;
            if (settings.OccursOnceAt)
            {
                calDate = new(settings.CurrentDate.Year, settings.CurrentDate.Month, settings.NumDay,
                    settings.OccursOnceAtHour.Hour, settings.OccursOnceAtHour.Minute, settings.OccursOnceAtHour.Second);
            }
            else
            {
                calDate = new(settings.CurrentDate.Year, settings.CurrentDate.Month, settings.NumDay,
                    settings.StartingHour.Hour, settings.StartingHour.Minute, settings.StartingHour.Second);
            }
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

        public static void ReturnAddedDateDay(Settings settings)
        {
            DateTime calDate;
            if (settings.OccursOnceAt)
            {
                calDate = new (settings.CurrentDate.Year, settings.CurrentDate.Month, settings.NumDay,
                    settings.OccursOnceAtHour.Hour, settings.OccursOnceAtHour.Minute, settings.OccursOnceAtHour.Second);
            }
            else
            {
                calDate = new (settings.CurrentDate.Year, settings.CurrentDate.Month, settings.NumDay,
                    settings.StartingHour.Hour, settings.StartingHour.Minute, settings.StartingHour.Second);
            }
            
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
