namespace SchedulerV3
{
    public static class CalculateOnce
    {
        public static void CalculateNextExecutionTime(Settings settings)
        {
            settings.CalculatedDate = settings.OnceTimeAt;
            settings.NextExecutionTime = settings.OnceTimeAt.ToString("dd/MM/yyyy HH:mm");
        }
    }
}
