namespace SchedulerV3
{
    public static class CalculateMonthlyDayEveryRecurring
    {
        public static void CalculateNextExecutionTime(Settings settings)
        {
            int rest = settings.currentDate.Month % settings.numMonths;
            if (rest != 0)
            {
                ReturnDate(settings, rest);
            }
            else
            {
                if (settings.numDay > settings.currentDate.Day)
                {
                    ReturnNormalDate(settings);
                    return;
                }
                else if (settings.numDay == settings.currentDate.Day)
                {
                    if (TimeSpan.Compare(settings.currentDate.TimeOfDay, settings.startingHour.TimeOfDay) < 0)
                    {
                        ReturnNormalDate(settings);
                        return;
                    }
                    else if ((TimeSpan.Compare(settings.currentDate.TimeOfDay, settings.startingHour.TimeOfDay) > 0) &&
                        TimeSpan.Compare(settings.currentDate.TimeOfDay, settings.endingHour.TimeOfDay) < 0)
                    {
                        Calculate(settings);
                        return;
                    }
                    else if (TimeSpan.Compare(settings.currentDate.TimeOfDay, settings.endingHour.TimeOfDay) > 0)
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
            int newMonth = (settings.currentDate.Month - rest) + settings.numMonths;
            DateTime calDate = new DateTime(settings.currentDate.Year, newMonth, settings.numDay,
                    settings.startingHour.Hour, settings.startingHour.Minute, settings.startingHour.Second);
            bool inLimits = OverLimitsChecker.CheckInLimits(calDate, settings.endingLimit);
            if (!inLimits)
            {
                settings.nextExecutionTime = "Next execution over end date limits";
                settings.isOverLimit = true;
                return;
            }
            settings.calculatedDate = calDate;
            settings.nextExecutionTime = settings.calculatedDate.ToString("dd/MM/yyyy HH:mm");
        }

        public static void ReturnNormalDate(Settings settings)
        {
            DateTime calDate = new DateTime(settings.currentDate.Year, settings.currentDate.Month, settings.numDay,
                    settings.startingHour.Hour, settings.startingHour.Minute, settings.startingHour.Second);
            bool inLimits = OverLimitsChecker.CheckInLimits(calDate, settings.endingLimit);
            if (!inLimits)
            {
                settings.nextExecutionTime = "Next execution over end date limits";
                settings.isOverLimit = true;
                return;
            }
            settings.calculatedDate = calDate;
            settings.nextExecutionTime = settings.calculatedDate.ToString("dd/MM/yyyy HH:mm");
        }

        public static void ReturnAddedDate(Settings settings)
        {
            DateTime calDate = new DateTime(settings.currentDate.Year, settings.currentDate.Month, settings.numDay,
                    settings.startingHour.Hour, settings.startingHour.Minute, settings.startingHour.Second);
            calDate = calDate.AddMonths(settings.numMonths);
            bool inLimits = OverLimitsChecker.CheckInLimits(calDate, settings.endingLimit);
            if (!inLimits)
            {
                settings.nextExecutionTime = "Next execution over end date limits";
                settings.isOverLimit = true;
                return;
            }
            settings.calculatedDate = calDate;
            settings.nextExecutionTime = settings.calculatedDate.ToString("dd/MM/yyyy HH:mm");
        }

        public static void Calculate(Settings settings)
        {
            //Calculate the next execution time
            DateTime calculated = settings.startingHour;
            while (TimeSpan.Compare(calculated.TimeOfDay, settings.currentDate.TimeOfDay) < 0)
            {
                switch (settings.freq)
                {
                    case (int)FreqEnum.Frequency.Hours:
                        calculated = calculated.AddHours(settings.occursEveryFreq);
                        break;
                    case (int)FreqEnum.Frequency.Minutes:
                        calculated = calculated.AddMinutes(settings.occursEveryFreq);
                        break;
                    case (int)FreqEnum.Frequency.Seconds:
                        calculated = calculated.AddSeconds(settings.occursEveryFreq);
                        break;
                }
                if (TimeSpan.Compare(calculated.TimeOfDay, settings.endingHour.TimeOfDay) > 0)
                {
                    calculated = settings.endingHour;
                    break;
                }
            }
            DateTime calDate = new DateTime(settings.currentDate.Year, settings.currentDate.Month, settings.numDay,
                    calculated.Hour, calculated.Minute, calculated.Second);
            bool inLimits = OverLimitsChecker.CheckInLimits(calDate, settings.endingLimit);
            if (!inLimits)
            {
                settings.nextExecutionTime = "Next execution over end date limits";
                settings.isOverLimit = true;
                return;
            }
            settings.calculatedDate = calDate;
            settings.nextExecutionTime = settings.calculatedDate.ToString("dd/MM/yyyy HH:mm");
        }
    }
}
