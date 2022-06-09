namespace SchedulerV3
{
    public static class CalculateRecurring
    {
        public static void calculate(Settings settings)
        {
            if (settings.occurs == 0)
            {
                if (settings.occursOnceAt)
                {
                    CalculateDailyRecurring.CalculateNextExecutionTime(settings);
                    DailyRecurringDescription.setDescription(settings);
                }
                else 
                { 
                    CalculateEveryRecurring.CalculateNextExecutionTime(settings);
                    EveryRecurringDescription.SetDescription(settings);
                }
            }
            
            else if (settings.occurs == 1)
            {
                if (settings.day)
                {
                    if (settings.occursOnceAt)
                    {
                        CalculateMonthlyDayOnceRecurring.CalculateNextExecutionTime(settings);
                        MonthlyDayOnceDescription.SetDescription(settings);
                    }
                    else 
                    {
                        CalculateMonthlyDayEveryRecurring.CalculateNextExecutionTime(settings);
                        MonthlyDayEveryDescription.SetDescription(settings);
                    }
                }
                else
                {
                    if (settings.occursOnceAt)
                    {
                        CalculateMonthlyTheOnceRecurring.CalculateNextExecutionTime(settings);
                        MonthlyTheOnceDescription.SetDescription(settings);
                    }
                    else
                    {
                        CalculateMonthlyTheEveryRecurring.CalculateNextExecutionTime(settings);
                        MonthlyTheEveryDescription.SetDescription(settings);
                    }
                }
                
            }
            
        }
    }
}
