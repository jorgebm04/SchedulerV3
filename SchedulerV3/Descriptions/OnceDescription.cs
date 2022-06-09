namespace SchedulerV3
{
    public static class OnceDescription
    {
        public static void SetDescription(Settings settings)
        {
            String description = "Occurs once. Schedule will be used on " + settings.calculatedDate.ToString("dd'/'MM'/'yyyy") + " at " +
                        settings.calculatedDate.ToString("HH:mm");
            settings.description = description;
        }
    }
}
