namespace SchedulerV3
{
    public static class CheckOnceSettings
    {
        public static void CheckSettings(Settings settings)
        {
            bool currentDate = CurrentDateChecker.CheckCurrentDate(settings.currentDate);
            if (!currentDate)
            {
                settings.nextExecutionTime = "Current date not correct.";
                return;
            }
            CheckOnceTimeAt(settings);
        }

        public static void CheckOnceTimeAt(Settings settings)
        {
            bool time = OnceTimeAtChecker.CheckOnceTimeAt(settings.currentDate,settings.onceTimeAt);
            if (!time)
            {
                settings.nextExecutionTime = "Once time at date not valid";
                return;
            }
            settings.nextExecutionTime = "";
        }
    }
}
