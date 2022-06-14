namespace SchedulerV3
{
    public static class CalculateEveryRecurring
    {
        public static void CalculateNextExecutionTime(Settings settings)
        {
            //If current date is later then ending limit
            if (settings.NeedToAddDay)
            {
                settings.CurrentDate = settings.CurrentDate.AddDays(1);
                settings.NextExecutionTime = settings.CurrentDate.ToString("dd/MM/yyyy") + " " + settings.StartingHour.ToString("HH:mm");
                settings.CalculatedDate = DateTime.ParseExact(settings.NextExecutionTime, "dd/MM/yyyy HH:mm", null);
                return;
            }
            Calculate(settings);
        }

        public static void Calculate(Settings settings)
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
            string nextExecution = settings.CurrentDate.ToString("dd/MM/yyyy") + " " + calculated.ToString("HH:mm");
            settings.CalculatedDate = DateTime.ParseExact(nextExecution, "dd/MM/yyyy HH:mm", null);
            settings.NextExecutionTime = nextExecution;
        }
    }
}
