namespace SchedulerV3
{
    public static class CalculateRecurring
    {
        public static void Calculate(Settings settings)
        {
            if (settings.Occurs == 0)
            {
                if (settings.OccursOnceAt)
                {
                    CalculateDailyRecurring.CalculateNextExecutionTime(settings);
                    DailyRecurringDescription.SetDescription(settings);
                }
                else 
                { 
                    CalculateEveryRecurring.CalculateNextExecutionTime(settings);
                    EveryRecurringDescription.SetDescription(settings);
                }
            }          
            else 
            {
                if (settings.Day)
                {
                    if (settings.OccursOnceAt)
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
                    if (settings.OccursOnceAt)
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
