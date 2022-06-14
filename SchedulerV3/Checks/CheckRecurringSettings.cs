namespace SchedulerV3
{
    public static class CheckRecurringSettings
    {
        public static void CheckSettings(Settings settings)
        {
            switch (settings.Occurs)
            {
                case (int)OccursEnum.Occurs.Daily:
                    CheckDailySettings.CheckRecurringDailySettings(settings);
                    break;
                case (int)OccursEnum.Occurs.Monthly:
                    CheckMonthlySettings.CheckRecurrentMonthlySettings(settings);
                    break;
                default:
                    settings.NextExecutionTime = "Select and occurrence.";
                    break;
            }
        }
    }
}
