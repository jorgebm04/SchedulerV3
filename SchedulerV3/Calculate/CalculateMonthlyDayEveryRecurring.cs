namespace SchedulerV3
{
    public static class CalculateMonthlyDayEveryRecurring
    {
        public static void CalculateNextExecutionTime(Settings settings)
        {
            if (settings.numDay > settings.currentDate.Day)
            {
                ReturnDate(settings);
                return;
            }
            else if (settings.numDay == settings.currentDate.Day)
            {
                if (TimeSpan.Compare(settings.currentDate.TimeOfDay, settings.startingHour.TimeOfDay) < 0)
                {
                    ReturnDate(settings);
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

        public static void ReturnDate(Settings settings)
        {
            settings.calculatedDate = new DateTime(settings.currentDate.Year, settings.currentDate.Month, settings.numDay,
                    settings.startingHour.Hour, settings.startingHour.Minute, settings.startingHour.Second);
            settings.nextExecutionTime = settings.calculatedDate.ToString("dd/MM/yyyy HH:mm");
        }

        public static void ReturnAddedDate(Settings settings)
        {
            DateTime calDate = new DateTime(settings.currentDate.Year, settings.currentDate.Month, settings.numDay,
                    settings.startingHour.Hour, settings.startingHour.Minute, settings.startingHour.Second);
            settings.calculatedDate = calDate.AddMonths(settings.numMonths);
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
            settings.calculatedDate = new DateTime(settings.currentDate.Year, settings.currentDate.Month, settings.numDay,
                    calculated.Hour, calculated.Minute, calculated.Second);
            settings.nextExecutionTime = settings.calculatedDate.ToString("dd/MM/yyyy HH:mm");
        }
    }
}
