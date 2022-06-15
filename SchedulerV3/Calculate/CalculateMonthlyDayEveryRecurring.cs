namespace SchedulerV3
{
    public static class CalculateMonthlyDayEveryRecurring
    {
        public static void CalculateNextExecutionTime(Settings settings)
        {
            int rest = settings.CurrentDate.Month % settings.NumMonths;
            if (rest != 0)
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
                    if (TimeSpan.Compare(settings.CurrentDate.TimeOfDay, settings.StartingHour.TimeOfDay) < 0)
                    {
                        ReturnNormalDate(settings);
                    }
                    else if ((TimeSpan.Compare(settings.CurrentDate.TimeOfDay, settings.StartingHour.TimeOfDay) > 0) &&
                        TimeSpan.Compare(settings.CurrentDate.TimeOfDay, settings.EndingHour.TimeOfDay) < 0)
                    {
                        Calculate(settings);
                    }
                    else if (TimeSpan.Compare(settings.CurrentDate.TimeOfDay, settings.EndingHour.TimeOfDay) > 0)
                    {
                        ReturnAddedDate(settings);
                    }
                }
                else
                {
                    ReturnAddedDate(settings);
                }
            }     
        }

        public static void ReturnDate(Settings settings, int rest)
        {
            int newMonth = (settings.CurrentDate.Month - rest) + settings.NumMonths;
            DateTime calDate = new(settings.CurrentDate.Year, newMonth, settings.NumDay,
                    settings.StartingHour.Hour, settings.StartingHour.Minute, settings.StartingHour.Second);
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
            DateTime calDate = new(settings.CurrentDate.Year, settings.CurrentDate.Month, settings.NumDay,
                    settings.StartingHour.Hour, settings.StartingHour.Minute, settings.StartingHour.Second);
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
                    settings.StartingHour.Hour, settings.StartingHour.Minute, settings.StartingHour.Second);
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

        public static void Calculate(Settings settings)
        {
            //Calculate the next execution time
            DateTime calculated = settings.StartingHour;
            while (TimeSpan.Compare(calculated.TimeOfDay, settings.CurrentDate.TimeOfDay) < 0)
            {
                switch (settings.Freq)
                {
                    case (int)FreqEnum.Frequency.Hours:
                        calculated = calculated.AddHours(settings.OccursEveryFreq);
                        break;
                    case (int)FreqEnum.Frequency.Minutes:
                        calculated = calculated.AddMinutes(settings.OccursEveryFreq);
                        break;
                    case (int)FreqEnum.Frequency.Seconds:
                        calculated = calculated.AddSeconds(settings.OccursEveryFreq);
                        break;
                }
                if (TimeSpan.Compare(calculated.TimeOfDay, settings.EndingHour.TimeOfDay) > 0)
                {
                    calculated = settings.EndingHour;
                    break;
                }
            }
            DateTime calDate = new(settings.CurrentDate.Year, settings.CurrentDate.Month, settings.NumDay,
                    calculated.Hour, calculated.Minute, calculated.Second);
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
