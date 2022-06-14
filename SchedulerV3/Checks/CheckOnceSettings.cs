namespace SchedulerV3
{
    public static class CheckOnceSettings
    {
        public static void CheckSettings(Settings settings)
        {
            bool currentDate = CurrentDateChecker.CheckCurrentDate(settings.CurrentDate);
            if (!currentDate)
            {
                settings.NextExecutionTime = "Current date not correct.";
                return;
            }
            CheckOnceTimeAt(settings);
        }

        public static void CheckOnceTimeAt(Settings settings)
        {
            bool time = OnceTimeAtChecker.CheckOnceTimeAt(settings.CurrentDate,settings.OnceTimeAt);
            if (!time)
            {
                settings.NextExecutionTime = "Once time at date not valid";
                return;
            }
            settings.NextExecutionTime = "";
        }
    }
}
