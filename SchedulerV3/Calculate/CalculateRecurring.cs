using SchedulerV3.Descriptions;

namespace SchedulerV3.Calculate
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
                    return;
                }
                CalculateEveryRecurring.CalculateNextExecutionTime(settings);
                EveryRecurringDescription.SetDescription(settings);

            }
            else
            {
                if (settings.Day)
                {
                    if (settings.OccursOnceAt)
                    {
                        CalculateMonthlyDayOnceRecurring.CalculateNextExecutionTime(settings);
                        MonthlyDayOnceDescription.SetDescription(settings);
                        return;
                    }
                    CalculateMonthlyDayEveryRecurring.CalculateNextExecutionTime(settings);
                    MonthlyDayEveryDescription.SetDescription(settings);

                }
                else
                {
                    if (settings.OccursOnceAt)
                    {
                        CalculateMonthlyTheOnceRecurring.CalculateNextExecutionTime(settings);
                        MonthlyTheOnceDescription.SetDescription(settings);
                        return;
                    }
                    CalculateMonthlyTheEveryRecurring.CalculateNextExecutionTime(settings);
                    MonthlyTheEveryDescription.SetDescription(settings);

                }

            }

        }
    }
}
