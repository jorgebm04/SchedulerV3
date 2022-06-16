using SchedulerV3.Enums;

namespace SchedulerV3.Calculate
{
    public static class CalculateNewDay
    {
        public static DateTime CalNewDate(Settings settings)
        {
            DateTime result;
            if (settings.DailyFreq == (int)DayFreqEnum.DayFreq.Monday)
            {
                DayOfWeek day = DayOfWeek.Monday;
                result = CalculateTheDay.Calculate(day, settings.CurrentDate, settings.MonthlyFreq);
                settings.DayOfTheWeek = "monday";
            }
            else if (settings.DailyFreq == (int)DayFreqEnum.DayFreq.Tuesday)
            {
                DayOfWeek day = DayOfWeek.Tuesday;
                settings.DayOfTheWeek = "tuesday";
                result = CalculateTheDay.Calculate(day, settings.CurrentDate, settings.MonthlyFreq);
            }
            else if (settings.DailyFreq == (int)DayFreqEnum.DayFreq.Wednesday)
            {
                DayOfWeek day = DayOfWeek.Wednesday;
                result = CalculateTheDay.Calculate(day, settings.CurrentDate, settings.MonthlyFreq);
                settings.DayOfTheWeek = "wednesday";
            }
            else if (settings.DailyFreq == (int)DayFreqEnum.DayFreq.Thursday)
            {
                DayOfWeek day = DayOfWeek.Thursday;
                result = CalculateTheDay.Calculate(day, settings.CurrentDate, settings.MonthlyFreq);
                settings.DayOfTheWeek = "thursday";
            }
            else if (settings.DailyFreq == (int)DayFreqEnum.DayFreq.Friday)
            {
                DayOfWeek day = DayOfWeek.Friday;
                result = CalculateTheDay.Calculate(day, settings.CurrentDate, settings.MonthlyFreq);
                settings.DayOfTheWeek = "friday";
            }
            else if (settings.DailyFreq == (int)DayFreqEnum.DayFreq.Saturday)
            {
                DayOfWeek day = DayOfWeek.Saturday;
                result = CalculateTheDay.Calculate(day, settings.CurrentDate, settings.MonthlyFreq);
                settings.DayOfTheWeek = "saturday";
            }
            else if (settings.DailyFreq == (int)DayFreqEnum.DayFreq.Sunday)
            {
                DayOfWeek day = DayOfWeek.Sunday;
                result = CalculateTheDay.Calculate(day, settings.CurrentDate, settings.MonthlyFreq);
                settings.DayOfTheWeek = "sunday";
            }
            else if (settings.DailyFreq == (int)DayFreqEnum.DayFreq.Day)
            {
                result = CalculateTheDay.CalculateDay(settings.CurrentDate, settings.MonthlyFreq);
                settings.DayOfTheWeek = "day";
            }
            else if (settings.DailyFreq == (int)DayFreqEnum.DayFreq.Weekday)
            {
                result = CalculateTheDay.CalculateWeekday(settings.CurrentDate, settings.MonthlyFreq);
                settings.DayOfTheWeek = "weekday";
            }
            else
            {
                result = CalculateTheDay.CalculateWeekendDay(settings.CurrentDate, settings.MonthlyFreq);
                settings.DayOfTheWeek = "weekend day";
            }
            return result;
        }
    }
}
