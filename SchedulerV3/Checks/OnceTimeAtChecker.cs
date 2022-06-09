namespace SchedulerV3
{
    public static class OnceTimeAtChecker
    {
        public static bool CheckOnceTimeAt(DateTime currentDate, DateTime onceTimeAt)
        {
            if(DateTime.Compare(currentDate, onceTimeAt) > 0)
            {
                return false;
            }
            return true;
        }
    }
}
