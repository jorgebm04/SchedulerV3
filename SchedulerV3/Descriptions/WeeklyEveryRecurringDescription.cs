namespace SchedulerV3
{
    public static class WeeklyEveryRecurringDescription
    {
        public static void SetDescription(Settings settings)
        {
            string resultado = "";
            for (int i = 0; i < settings.days.Count; i++)
            {
                if (i == settings.days.Count - 1)
                {
                    resultado = resultado + " and " + settings.days.GetByIndex(i);
                }
                else if (i == 0)
                {
                    resultado = resultado + settings.days.GetByIndex(i);
                }
                else
                {
                    resultado = resultado + "," + settings.days.GetByIndex(i);
                }

            }
            string description = "Occurs every " + /*settings.weeks +*/ " weeks on " + resultado + ". Schedule will be used on " + settings.calculatedDate.ToString("dd'/'MM'/'yyyy") + " at " +
                settings.calculatedDate.ToString("HH:mm") + " starting on " + settings.startingLimit.ToString("dd'/'MM'/'yyyy");
            settings.description = description;
        }
    }
}
