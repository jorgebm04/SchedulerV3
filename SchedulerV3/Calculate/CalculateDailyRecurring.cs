namespace SchedulerV3
{
    public static class CalculateDailyRecurring
    {
        public static void CalculateNextExecutionTime(Settings settings)
        {
            if (settings.NeedToAddDay)
            {
                settings.CurrentDate = settings.CurrentDate.AddDays(1);
            }
            string calculated = settings.CurrentDate.ToString("dd/MM/yyyy") + " " + settings.OccursOnceAtHour.ToString("HH:mm");
            settings.CalculatedDate = DateTime.ParseExact(calculated,"dd/MM/yyyy HH:mm",null);
            settings.NextExecutionTime = calculated;
        }
    }
}
