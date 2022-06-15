namespace SchedulerV3
{
    public static class CalculateMonthlyTheEveryRecurring
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
                    if (TimeSpan.Compare(settings.CurrentDate.TimeOfDay, settings.StartingHour.TimeOfDay) < 0)
                    {
                        ReturnNormalDate(settings, calculatedDate);
                    }
                    else if ((TimeSpan.Compare(settings.CurrentDate.TimeOfDay, settings.StartingHour.TimeOfDay) > 0) &&
                        TimeSpan.Compare(settings.CurrentDate.TimeOfDay, settings.EndingHour.TimeOfDay) < 0)
                    {
                        Calculate(settings, calculatedDate);
                    }
                    else if (TimeSpan.Compare(settings.CurrentDate.TimeOfDay, settings.EndingHour.TimeOfDay) > 0)
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
                settings.StartingHour.Hour, settings.StartingHour.Minute, settings.StartingHour.Second);
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

        public static void ReturnNormalDate(Settings settings,DateTime calculated)
        {
            DateTime calDate = new(settings.CurrentDate.Year, settings.CurrentDate.Month, calculated.Day,
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

        public static void ReturnAddedDate(Settings settings,DateTime calculated)
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
            DateTime newDate = new(calDate.Year, calDate.Month, calDate.Day,
                settings.StartingHour.Hour,settings.StartingHour.Minute, settings.StartingHour.Second);
            settings.CalculatedDate = newDate;
            settings.NextExecutionTime = settings.CalculatedDate.ToString("dd/MM/yyyy HH:mm");
        }

        public static void Calculate(Settings settings,DateTime calculatedDay)
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
            DateTime calDate = new (settings.CurrentDate.Year, settings.CurrentDate.Month, calculatedDay.Day,
                    calculated.Hour, calculated.Minute, calculated.Second);
            bool inLimits = OverLimitsChecker.CheckInLimits(calDate, settings.EndingLimit);
            if (!inLimits)
            {
                settings.NextExecutionTime = "Next execution over end date limits";
                settings.IsOverLimit = true;
                return;
            }
            settings.CalculatedDate = new DateTime(settings.CurrentDate.Year, settings.CurrentDate.Month, calculatedDay.Day,
                    calculated.Hour, calculated.Minute, calculated.Second);
            settings.NextExecutionTime = settings.CalculatedDate.ToString("dd/MM/yyyy HH:mm");
        }
    }
}

