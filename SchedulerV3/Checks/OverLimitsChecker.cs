namespace SchedulerV3
{
    public static class OverLimitsChecker
    {
        public static bool CheckInLimits(DateTime calculatedDate, DateTime endLimit)
        {
            if (DateTime.Compare(endLimit, calculatedDate) < 0)
            {
                return false;
            }
            return true;
        }
    }
}
