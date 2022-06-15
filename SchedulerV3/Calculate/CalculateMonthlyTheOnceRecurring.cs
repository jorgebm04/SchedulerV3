namespace SchedulerV3
{
    public static class CalculateMonthlyTheOnceRecurring
    {
        public static void CalculateNextExecutionTime(Settings settings)
        {
            bool correctLimit;
            int rest = settings.CurrentDate.Month % settings.Monthly2Freq;
            if (rest != 0)
            {
                correctLimit = DifferentReturnTypes.ReturnDateThe(settings, rest);
                if (!correctLimit)
                {
                    return;
                }
            }
            else
            {
                DateTime calculatedDate = CalculateNewDay.CalNewDate(settings);
                if (DateTime.Compare(calculatedDate, settings.CurrentDate) > 0)
                {
                    correctLimit = DifferentReturnTypes.ReturnNormalDateThe(settings, calculatedDate);
                    if (!correctLimit)
                    {
                        return;
                    }
                }
                else if (calculatedDate.ToString("dd/MM/yyyy").Equals(settings.CurrentDate.ToString("dd/MM/yyyy")))
                {
                    if (TimeSpan.Compare(settings.CurrentDate.TimeOfDay, settings.OccursOnceAtHour.TimeOfDay) < 0)
                    {
                        correctLimit = DifferentReturnTypes.ReturnNormalDateThe(settings, calculatedDate);
                        if (!correctLimit)
                        {
                            return;
                        }
                    }
                    else
                    {
                        correctLimit = DifferentReturnTypes.ReturnAddedDateThe(settings, calculatedDate);
                        if (!correctLimit)
                        {
                            return;
                        }
                    }
                }
                else
                {
                    correctLimit = DifferentReturnTypes.ReturnAddedDateThe(settings, calculatedDate);
                    if (!correctLimit)
                    {
                        return;
                    }
                }
            }        
        }
    }
}

