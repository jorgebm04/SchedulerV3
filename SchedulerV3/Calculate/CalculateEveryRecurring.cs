namespace SchedulerV3.Calculate
{
    public static class CalculateEveryRecurring
    {
        public static void CalculateNextExecutionTime(Settings settings)
        {
            //If current date is later then ending limit
            if (settings.NeedToAddDay)
            {
                settings.CurrentDate = settings.CurrentDate.AddDays(1);
                SetNextExecutionTime(settings, settings.StartingHour);
                return;
            }
            Calculate(settings);
        }

        private static void Calculate(Settings settings)
        {
            //Calculate the next execution time
            DateTime calculated = CalculateEvery.Calculate(settings);
            SetNextExecutionTime(settings, calculated);
        }

        private static void SetNextExecutionTime(Settings settings, DateTime calculated)
        {
            settings.NextExecutionTime = settings.CurrentDate.ToString("dd/MM/yyyy") + " " + calculated.ToString("HH:mm");
            settings.CalculatedDate = DateTime.ParseExact(settings.NextExecutionTime, "dd/MM/yyyy HH:mm", null);
        }
    }
}
