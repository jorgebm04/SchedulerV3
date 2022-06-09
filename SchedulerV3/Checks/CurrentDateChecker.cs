namespace SchedulerV3
{
    public static class CurrentDateChecker
    {
        public static bool CheckCurrentDate(DateTime currentDate)
        {
            //if (DateTime.Compare(currentDate,DateTime.Now) != 0)
            if(currentDate.Day != DateTime.Now.Day || currentDate.Month != DateTime.Now.Month || currentDate.Year != DateTime.Now.Year
                || currentDate.Hour != DateTime.Now.Hour || currentDate.Minute != DateTime.Now.Minute)
            {
                return false;
            }
            return true;
        }
    }
}
