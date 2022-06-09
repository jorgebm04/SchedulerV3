namespace SchedulerV3
{
    public static class CalculateNewDay
    {
        public static DateTime CalNewDate(Settings settings)
        {
            DateTime result;
            if (settings.dailyFreq == (int)DayFreqEnum.DayFreq.monday)
            {
                DayOfWeek day = DayOfWeek.Monday;
                result = CalculateTheDay.Calculate(day, settings.currentDate, settings.monthlyFreq);
                settings.dayOfTheWeek = "monday";
            }
            else if (settings.dailyFreq == (int)DayFreqEnum.DayFreq.tuesday)
            {
                DayOfWeek day = DayOfWeek.Tuesday;
                settings.dayOfTheWeek = "tuesday";
                result = CalculateTheDay.Calculate(day, settings.currentDate, settings.monthlyFreq);
            }
            else if (settings.dailyFreq == (int)DayFreqEnum.DayFreq.wednesday)
            {
                DayOfWeek day = DayOfWeek.Wednesday;
                result = CalculateTheDay.Calculate(day, settings.currentDate, settings.monthlyFreq);
                settings.dayOfTheWeek = "wednesday";
            }
            else if (settings.dailyFreq == (int)DayFreqEnum.DayFreq.thursday)
            {
                DayOfWeek day = DayOfWeek.Thursday;
                result = CalculateTheDay.Calculate(day, settings.currentDate, settings.monthlyFreq);
                settings.dayOfTheWeek = "thursday";
            }
            else if (settings.dailyFreq == (int)DayFreqEnum.DayFreq.friday)
            {
                DayOfWeek day = DayOfWeek.Friday;
                result = CalculateTheDay.Calculate(day, settings.currentDate, settings.monthlyFreq);
                settings.dayOfTheWeek = "friday";
            }
            else if (settings.dailyFreq == (int)DayFreqEnum.DayFreq.saturday)
            {
                DayOfWeek day = DayOfWeek.Saturday;
                result = CalculateTheDay.Calculate(day, settings.currentDate, settings.monthlyFreq);
                settings.dayOfTheWeek = "saturday";
            }
            else if (settings.dailyFreq == (int)DayFreqEnum.DayFreq.sunday)
            {
                DayOfWeek day = DayOfWeek.Sunday;
                result = CalculateTheDay.Calculate(day, settings.currentDate, settings.monthlyFreq);
                settings.dayOfTheWeek = "sunday";
            }
            else if (settings.dailyFreq == (int)DayFreqEnum.DayFreq.day)
            {
                result = CalculateTheDay.CalculateDay(settings.currentDate, settings.monthlyFreq);
                settings.dayOfTheWeek = "day";
            }
            else if (settings.dailyFreq == (int)DayFreqEnum.DayFreq.weekday)
            {
                result = CalculateTheDay.CalculateWeekday(settings.currentDate, settings.monthlyFreq);
                settings.dayOfTheWeek = "weekday";
            }
            else
            {
                result = CalculateTheDay.CalculateWeekendDay(settings.currentDate, settings.monthlyFreq);
                settings.dayOfTheWeek = "weekend day";
            }
            return result;
        }
    }
}
