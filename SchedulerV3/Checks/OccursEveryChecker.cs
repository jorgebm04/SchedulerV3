namespace SchedulerV3.Checks
{
    public static class OccursEveryChecker
    {
        public static bool CheckOccursEveryComboBox (int index)
        {
            if (index == -1)
            {
                return false;
            }
            return true;
        }

        public static bool CheckOccursEveryLimits(DateTime start, DateTime end)
        {
            if(TimeSpan.Compare(start.TimeOfDay, end.TimeOfDay) > 0)
            {
                return false;
            }
            return true;
        }
    }
}
