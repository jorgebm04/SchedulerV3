namespace SchedulerV3
{
    public static class CalculateMonthlyTheEveryRecurring
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
                    if (TimeSpan.Compare(settings.CurrentDate.TimeOfDay, settings.StartingHour.TimeOfDay) < 0)
                    {
                        correctLimit = DifferentReturnTypes.ReturnNormalDateThe(settings, calculatedDate);
                        if (!correctLimit)
                        {
                            return;
                        }
                    }
                    else if ((TimeSpan.Compare(settings.CurrentDate.TimeOfDay, settings.StartingHour.TimeOfDay) > 0) &&
                        TimeSpan.Compare(settings.CurrentDate.TimeOfDay, settings.EndingHour.TimeOfDay) < 0)
                    {
                        Calculate(settings, calculatedDate);
                    }
                    else if (TimeSpan.Compare(settings.CurrentDate.TimeOfDay, settings.EndingHour.TimeOfDay) > 0)
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

        public static void Calculate(Settings settings,DateTime calculatedDay)
        {
            //Calculate the next execution time
            DateTime calculated = CalculateEvery.Calculate(settings);
            DateTime calDate = new (settings.CurrentDate.Year, settings.CurrentDate.Month, calculatedDay.Day,
                    calculated.Hour, calculated.Minute, calculated.Second);
            bool inLimits = OverLimitsChecker.CheckInLimits(calDate, settings.EndingLimit);
            if (!inLimits)
            {
                settings.NextExecutionTime = "Next execution over end date limits";
                settings.IsOverLimit = true;
                return;
            }
            settings.CalculatedDate = new DateTime(settings.CurrentDate.Year, settings.CurrentDate.Month, calculatedDay.Day,
                    calculated.Hour, calculated.Minute, calculated.Second);
            settings.NextExecutionTime = settings.CalculatedDate.ToString("dd/MM/yyyy HH:mm");
        }
    }
}

