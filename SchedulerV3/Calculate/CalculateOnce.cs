namespace SchedulerV3
{
    public static class CalculateOnce
    {
        public static void CalculateNextExecutionTime(Settings settings)
        {
            settings.calculatedDate = settings.onceTimeAt;
            settings.nextExecutionTime = settings.onceTimeAt.ToString("dd/MM/yyyy HH:mm");
        }
    }
}
