namespace SchedulerV3.Calculate
{
    public static class CalculateMonthlyTheOnceRecurring
    {
        public static void CalculateNextExecutionTime(Settings settings)
        {
            int rest = settings.CurrentDate.Month % settings.Monthly2Freq;
            if (rest != 0)
            {
                DifferentReturnTypes.ReturnDateThe(settings, rest);    
            }
            else
            {
                DateTime calculatedDate = CalculateNewDay.CalNewDate(settings);
                if (DateTime.Compare(calculatedDate, settings.CurrentDate) > 0)
                {
                    DifferentReturnTypes.ReturnNormalDateThe(settings, calculatedDate);                    
                }
                else if (calculatedDate.ToString("dd/MM/yyyy").Equals(settings.CurrentDate.ToString("dd/MM/yyyy")))
                {
                    if (TimeSpan.Compare(settings.CurrentDate.TimeOfDay, settings.OccursOnceAtHour.TimeOfDay) < 0)
                    {
                        DifferentReturnTypes.ReturnNormalDateThe(settings, calculatedDate);
                    }
                    else
                    {
                        DifferentReturnTypes.ReturnAddedDateThe(settings, calculatedDate);
                    }
                }
                else
                {
                    DifferentReturnTypes.ReturnAddedDateThe(settings, calculatedDate);
                }
            }        
        }
    }
}

