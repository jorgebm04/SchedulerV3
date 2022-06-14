namespace SchedulerV3
{
    public static class OnceDescription
    {
        public static void SetDescription(Settings settings)
        {
            String description = "Occurs once. Schedule will be used on " + settings.CalculatedDate.ToString("dd'/'MM'/'yyyy") + " at " +
                        settings.CalculatedDate.ToString("HH:mm");
            settings.Description = description;
        }
    }
}
