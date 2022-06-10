namespace SchedulerV3
{
    public static class MonthlyDayOnceDescription
    {
        public static void SetDescription(Settings settings)
        {
            if (!settings.isOverLimit)
            {
                settings.description = "Occurs every " + settings.numDay + " day, every " + settings.numMonths +
                " months at " + settings.calculatedDate.ToString("HH:mm") + ", starting on " + settings.startingLimit.ToString("dd/MM/yyyy");
            }   
        }
    }
}
