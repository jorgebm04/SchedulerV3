namespace SchedulerV3
{
    public static class DailyRecurringDescription
    {
        public static void setDescription(Settings settings)
        {
            string description = "Occurs every day. Schedule will be used on " + settings.calculatedDate.ToString("dd'/'MM'/'yyyy") + " at " +
                settings.calculatedDate.ToString("HH:mm") + " starting on " + settings.startingLimit.ToString("dd'/'MM'/'yyyy");
            settings.description = description;
        }
    }
}
