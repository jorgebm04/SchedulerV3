using SchedulerV3.Enums;

namespace SchedulerV3.Calculate
{
    public static class CalculateEvery
    {
        public static DateTime Calculate(Settings settings)
        {
            //Calculate the next execution time
            DateTime calculated = settings.StartingHour;
            while (TimeSpan.Compare(calculated.TimeOfDay, settings.CurrentDate.TimeOfDay) < 0)
            {
                switch (settings.Freq)
                {
                    case (int)FreqEnum.Frequency.Hours:
                        calculated = calculated.AddHours(settings.OccursEveryFreq);
                        break;
                    case (int)FreqEnum.Frequency.Minutes:
                        calculated = calculated.AddMinutes(settings.OccursEveryFreq);
                        break;
                    case (int)FreqEnum.Frequency.Seconds:
                        calculated = calculated.AddSeconds(settings.OccursEveryFreq);
                        break;
                }
                if (TimeSpan.Compare(calculated.TimeOfDay, settings.EndingHour.TimeOfDay) > 0)
                {
                    calculated = settings.EndingHour;
                    break;
                }
            }
            return calculated;
        }
    }
}
