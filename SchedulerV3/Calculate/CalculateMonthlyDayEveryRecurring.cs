using SchedulerV3.Checks;

namespace SchedulerV3.Calculate
{
    public static class CalculateMonthlyDayEveryRecurring
    {
        public static void CalculateNextExecutionTime(Settings settings)
        {
            int rest = settings.CurrentDate.Month % settings.NumMonths;
            if (rest != 0)
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
                    if (TimeSpan.Compare(settings.CurrentDate.TimeOfDay, settings.StartingHour.TimeOfDay) < 0)
                    {
                        DifferentReturnTypes.ReturnNormalDateDay(settings);
                    }
                    else if ((TimeSpan.Compare(settings.CurrentDate.TimeOfDay, settings.StartingHour.TimeOfDay) > 0) &&
                             TimeSpan.Compare(settings.CurrentDate.TimeOfDay, settings.EndingHour.TimeOfDay) < 0)
                    {
                        Calculate(settings);
                    }
                    else if (TimeSpan.Compare(settings.CurrentDate.TimeOfDay, settings.EndingHour.TimeOfDay) > 0)
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

        private static void Calculate(Settings settings)
        {
            //Calculate the next execution time
            DateTime calculated = CalculateEvery.Calculate(settings);
            DateTime calDate = new(settings.CurrentDate.Year, settings.CurrentDate.Month, settings.NumDay,
                    calculated.Hour, calculated.Minute, calculated.Second);
            bool inLimits = OverLimitsChecker.CheckInLimits(calDate, settings.EndingLimit);
            if (!inLimits)
            {
                settings.NextExecutionTime = "Next execution over end date limits";
                settings.IsOverLimit = true;
                return;
            }
            settings.CalculatedDate = calDate;
            settings.NextExecutionTime = settings.CalculatedDate.ToString("dd/MM/yyyy HH:mm");
        }
    }
}
