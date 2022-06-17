namespace SchedulerV3.Calculate
{
    public static class CalculateMonthlyDayOnceRecurring
    {
        public static void CalculateNextExecutionTime(Settings settings)
        {
            int rest = settings.CurrentDate.Month % settings.NumMonths;
            if ( rest != 0)
            {
                DifferentReturnTypes.ReturnDateDay(settings, rest);
            } 
            else
            {
                if (settings.NumDay > settings.CurrentDate.Day)
                {
                    DifferentReturnTypes.ReturnNormalDateDay(settings);
                } 
                else if (settings.NumDay == settings.CurrentDate.Day)
                {
                    if (TimeSpan.Compare(settings.CurrentDate.TimeOfDay, settings.OccursOnceAtHour.TimeOfDay) < 0)
                    {
                        DifferentReturnTypes.ReturnNormalDateDay(settings);
                    }
                    else 
                    {
                        DifferentReturnTypes.ReturnAddedDateDay(settings);
                    }
                }
                else
                {
                    DifferentReturnTypes.ReturnAddedDateDay(settings);
                }
            }
        }
    }
}
