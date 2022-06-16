namespace SchedulerV3.Checks
{
    public static class NeedToAddDaysChecker
    {
        public static bool CheckNeedToAddDays(DateTime current, DateTime hour)
        {
            if (TimeSpan.Compare(current.TimeOfDay, hour.TimeOfDay) > 0)
            {
                return true;
            }
            return false;
        }
    }
}
