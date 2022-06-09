namespace SchedulerV3
{
    public static class CalculateEveryRecurring
    {
        public static void CalculateNextExecutionTime(Settings settings)
        {
            //If current date is later then ending limit
            if (settings.needToAddDay)
            {
                settings.currentDate = settings.currentDate.AddDays(1);
                settings.nextExecutionTime = settings.currentDate.ToString("dd/MM/yyyy") + " " + settings.startingHour.ToString("HH:mm");
                settings.calculatedDate = DateTime.ParseExact(settings.nextExecutionTime, "dd/MM/yyyy HH:mm", null);
                return;
            }
            Calculate(settings);
        }

        public static void Calculate(Settings settings)
        {
            //Calculate the next execution time
            DateTime calculated = settings.startingHour;
            while (TimeSpan.Compare(calculated.TimeOfDay, settings.currentDate.TimeOfDay) < 0)
            {
                switch (settings.freq)
                {
                    case (int)FreqEnum.Frequency.Hours:
                        calculated = calculated.AddHours(settings.occursEveryFreq);
                        break;
                    case (int)FreqEnum.Frequency.Minutes:
                        calculated = calculated.AddMinutes(settings.occursEveryFreq);
                        break;
                    case (int)FreqEnum.Frequency.Seconds:
                        calculated = calculated.AddSeconds(settings.occursEveryFreq);
                        break;
                }
                if (TimeSpan.Compare(calculated.TimeOfDay, settings.endingHour.TimeOfDay) > 0)
                {
                    calculated = settings.endingHour;
                    break;
                }
            }
            string nextExecution = settings.currentDate.ToString("dd/MM/yyyy") + " " + calculated.ToString("HH:mm");
            settings.calculatedDate = DateTime.ParseExact(nextExecution, "dd/MM/yyyy HH:mm", null);
            settings.nextExecutionTime = nextExecution;
        }
    }
}
