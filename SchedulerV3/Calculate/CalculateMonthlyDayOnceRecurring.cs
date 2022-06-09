namespace SchedulerV3
{
    public static class CalculateMonthlyDayOnceRecurring
    {
        public static void CalculateNextExecutionTime(Settings settings)
        {
            if(settings.numDay > settings.currentDate.Day)
            {
                ReturnDate(settings);     
                return;
            } 
            else if (settings.numDay == settings.currentDate.Day)
            {
                if(TimeSpan.Compare(settings.currentDate.TimeOfDay,settings.occursOnceAtHour.TimeOfDay) < 0)
                {
                    ReturnDate(settings);
                    return;
                }
                if (TimeSpan.Compare(settings.currentDate.TimeOfDay, settings.occursOnceAtHour.TimeOfDay) > 0)
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
                    settings.occursOnceAtHour.Hour, settings.occursOnceAtHour.Minute, settings.occursOnceAtHour.Second);
            settings.nextExecutionTime = settings.calculatedDate.ToString("dd/MM/yyyy HH:mm");
        }

        public static void ReturnAddedDate(Settings settings)
        {
            DateTime calDate = new DateTime(settings.currentDate.Year, settings.currentDate.Month, settings.numDay,
                    settings.occursOnceAtHour.Hour, settings.occursOnceAtHour.Minute, settings.occursOnceAtHour.Second);
            settings.calculatedDate = calDate.AddMonths(settings.numMonths);
            settings.nextExecutionTime = settings.calculatedDate.ToString("dd/MM/yyyy HH:mm");
        }
    }
}
