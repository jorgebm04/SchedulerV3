﻿namespace SchedulerV3
{
    public static class CalculateMonthlyTheOnceRecurring
    {
        public static void CalculateNextExecutionTime(Settings settings)
        {   
            int rest = settings.currentDate.Month % settings.monthly2Freq;
            if (rest != 0)
            {
                ReturnDate(settings, rest);
            }
            else
            {
                DateTime calculatedDate = CalculateNewDay.CalNewDate(settings);
                if (DateTime.Compare(calculatedDate, settings.currentDate) > 0)
                {
                    ReturnNormalDate(settings, calculatedDate);
                    return;
                }
                else if (calculatedDate.ToString("dd/MM/yyyy").Equals(settings.currentDate.ToString("dd/MM/yyyy")))
                {
                    if (TimeSpan.Compare(settings.currentDate.TimeOfDay, settings.occursOnceAtHour.TimeOfDay) < 0)
                    {
                        ReturnNormalDate(settings, calculatedDate);
                        return;
                    }
                    if (TimeSpan.Compare(settings.currentDate.TimeOfDay, settings.occursOnceAtHour.TimeOfDay) > 0)
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
        }

        public static void ReturnDate(Settings settings, int rest)
        {
            int newMonth = (settings.currentDate.Month - rest) + settings.monthly2Freq;
            settings.currentDate = new DateTime(settings.currentDate.Year, newMonth, 1,
                settings.occursOnceAtHour.Hour, settings.occursOnceAtHour.Minute, settings.occursOnceAtHour.Second);
            settings.calculatedDate = CalculateNewDay.CalNewDate(settings);
            settings.nextExecutionTime = settings.calculatedDate.ToString("dd/MM/yyyy HH:mm");
        }

        public static void ReturnNormalDate(Settings settings, DateTime calculated)
        {
            settings.calculatedDate = new DateTime(settings.currentDate.Year, settings.currentDate.Month, calculated.Day,
                    settings.occursOnceAtHour.Hour, settings.occursOnceAtHour.Minute, settings.occursOnceAtHour.Second);
            settings.nextExecutionTime = settings.calculatedDate.ToString("dd/MM/yyyy HH:mm");
        }

        public static void ReturnAddedDate(Settings settings, DateTime calculated)
        {
            DateTime calDate = new DateTime(settings.currentDate.Year, settings.currentDate.Month, calculated.Day,
                    settings.occursOnceAtHour.Hour, settings.occursOnceAtHour.Minute, settings.occursOnceAtHour.Second);
            settings.currentDate = calDate.AddMonths(settings.monthly2Freq);
            settings.calculatedDate = CalculateNewDay.CalNewDate(settings);
            calDate = new DateTime(settings.currentDate.Year, settings.currentDate.Month, settings.calculatedDate.Day,
                    settings.occursOnceAtHour.Hour, settings.occursOnceAtHour.Minute, settings.occursOnceAtHour.Second);
            settings.calculatedDate = calDate;
            settings.nextExecutionTime = settings.calculatedDate.ToString("dd/MM/yyyy HH:mm");
        }
    }
}
