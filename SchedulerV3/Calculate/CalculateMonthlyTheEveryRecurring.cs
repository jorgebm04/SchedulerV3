namespace SchedulerV3
{
    public static class CalculateMonthlyTheEveryRecurring
    {
        public static void CalculateNextExecutionTime(Settings settings)
        {
            DateTime calculatedDate = CalculateNewDay.CalNewDate(settings);
            if (DateTime.Compare(calculatedDate, settings.currentDate) > 0)
            {
                ReturnDate(settings,calculatedDate);
                return;
            }
            else if (calculatedDate.ToString("dd/MM/yyyy").Equals(settings.currentDate.ToString("dd/MM/yyyy")))
            {
                if (TimeSpan.Compare(settings.currentDate.TimeOfDay, settings.startingHour.TimeOfDay) < 0)
                {
                    ReturnDate(settings,calculatedDate);
                    return;
                }
                else if ((TimeSpan.Compare(settings.currentDate.TimeOfDay, settings.startingHour.TimeOfDay) > 0) &&
                    TimeSpan.Compare(settings.currentDate.TimeOfDay, settings.endingHour.TimeOfDay) < 0)
                {
                    Calculate(settings,calculatedDate);
                    return;
                }
                else if (TimeSpan.Compare(settings.currentDate.TimeOfDay, settings.endingHour.TimeOfDay) > 0)
                {
                    ReturnAddedDate(settings, calculatedDate);
                    return;
                }
            }
            else
            {
                ReturnAddedDate(settings, calculatedDate);
                return;
            }
        }

        public static void ReturnDate(Settings settings,DateTime calculated)
        {
            settings.calculatedDate = new DateTime(settings.currentDate.Year, settings.currentDate.Month, calculated.Day,
            settings.startingHour.Hour, settings.startingHour.Minute, settings.startingHour.Second);
            settings.nextExecutionTime = settings.calculatedDate.ToString("dd/MM/yyyy HH:mm");
        }

        public static void ReturnAddedDate(Settings settings,DateTime calculated)
        {
            DateTime calDate = new DateTime(settings.currentDate.Year, settings.currentDate.Month, calculated.Day,
                    settings.startingHour.Hour, settings.startingHour.Minute, settings.startingHour.Second);
            settings.currentDate = calDate.AddMonths(settings.monthly2Freq);
            settings.calculatedDate = CalculateNewDay.CalNewDate(settings);
            calDate = new DateTime(settings.currentDate.Year, settings.currentDate.Month, settings.calculatedDate.Day,
                    settings.startingHour.Hour, settings.startingHour.Minute, settings.startingHour.Second);
            settings.calculatedDate = calDate;
            settings.nextExecutionTime = settings.calculatedDate.ToString("dd/MM/yyyy HH:mm");
        }

        public static void Calculate(Settings settings,DateTime calculatedDay)
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
            settings.calculatedDate = new DateTime(settings.currentDate.Year, settings.currentDate.Month, calculatedDay.Day,
                    calculated.Hour, calculated.Minute, calculated.Second);
            settings.nextExecutionTime = settings.calculatedDate.ToString("dd/MM/yyyy HH:mm");
        }
    }
}

