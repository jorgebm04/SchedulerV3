namespace SchedulerV3
{
    public class RecurringLimitsChecker
    {
        public static bool CheckLimits(DateTime start, DateTime end)
        {
            if(DateTime.Compare(start, end) > 0){
                return false;
            }
            return true;
        }

        public static bool CheckLimitsWithCurrentDate(DateTime start, DateTime end, DateTime currentDate)
        {
            if(DateTime.Compare(start,currentDate)>0 || DateTime.Compare(currentDate, end) > 0)
            {
                return false;
            }
            return true;
        }
    }
}
