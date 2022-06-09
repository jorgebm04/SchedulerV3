namespace SchedulerV3
{
    public class CalculateDailyRecurring
    {
        public static void CalculateNextExecutionTime(Settings settings)
        {
            if (settings.needToAddDay)
            {
                settings.currentDate = settings.currentDate.AddDays(1);
            }
            string calculated = settings.currentDate.ToString("dd/MM/yyyy") + " " + settings.occursOnceAtHour.ToString("HH:mm");
            settings.calculatedDate = DateTime.ParseExact(calculated,"dd/MM/yyyy HH:mm",null);
            settings.nextExecutionTime = calculated;
        }
    }
}
