namespace SchedulerV3.Descriptions
{
    public static class MonthlyDayOnceDescription
    {
        public static void SetDescription(Settings settings)
        {
            if (!settings.IsOverLimit)
            {
                settings.Description = "Occurs every " + settings.NumDay + " day, every " + settings.NumMonths +
                " months at " + settings.CalculatedDate.ToString("HH:mm") + ", starting on " + settings.StartingLimit.ToString("dd/MM/yyyy");
            }   
        }
    }
}
