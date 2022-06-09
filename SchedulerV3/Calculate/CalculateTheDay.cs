namespace SchedulerV3
{
    public static class CalculateTheDay
    {
        public static DateTime Calculate(DayOfWeek day, DateTime current,int freq)
        {
            DateTime pre;
            if(freq == 4)
            {
                int daysInMonth = DateTime.DaysInMonth(current.Year, current.Month);
                pre = new DateTime(current.Year, current.Month, daysInMonth);
                while(pre.DayOfWeek != day)
                {
                    pre = pre.AddDays(-1);
                }
            } 
            else
            {
                pre = new DateTime(current.Year, current.Month, 1);
                while (pre.DayOfWeek != day)
                {
                    pre = pre.AddDays(1);
                }
                pre = pre.AddDays(7 * freq);
            }
            return pre;
        }

        public static DateTime CalculateDay(DateTime current, int freq)
        {
            DateTime pre = new DateTime(current.Year, current.Month, 1);
            if(freq == 4)
            {
                return new DateTime(current.Year, current.Month, DateTime.DaysInMonth(current.Year, current.Month));
            }
            else
            {
                pre = pre.AddDays(freq);
                return pre;
            }
        }

        public static DateTime CalculateWeekday(DateTime current, int freq)
        {
            DateTime pre;
            if (freq == 4)
            {
                int daysInMonth = DateTime.DaysInMonth(current.Year, current.Month);
                pre = new DateTime(current.Year, current.Month, daysInMonth);
                while (pre.DayOfWeek != DayOfWeek.Monday && pre.DayOfWeek != DayOfWeek.Tuesday && pre.DayOfWeek != DayOfWeek.Wednesday &&
                    pre.DayOfWeek != DayOfWeek.Thursday && pre.DayOfWeek != DayOfWeek.Friday)
                {
                    pre = pre.AddDays(-1);
                }
            } else
            {
                pre = new DateTime(current.Year, current.Month, 1);
                int count = freq;
                while (count >= 0)
                {
                    if (pre.DayOfWeek == DayOfWeek.Saturday)
                    {
                        pre = pre.AddDays(2);
                        count--;
                    }
                    else if (pre.DayOfWeek == DayOfWeek.Sunday)
                    {
                        pre = pre.AddDays(1);
                        count--;
                    }
                    else
                    {
                        pre = pre.AddDays(freq);
                        return pre;
                    }
                }  
            }
            return pre;
        }

        public static DateTime CalculateWeekendDay(DateTime current, int freq)
        {
            DateTime pre;
            if (freq == 4)
            {
                int daysInMonth = DateTime.DaysInMonth(current.Year, current.Month);
                pre = new DateTime(current.Year, current.Month, daysInMonth);
                while (pre.DayOfWeek != DayOfWeek.Saturday && pre.DayOfWeek != DayOfWeek.Sunday)
                {
                    pre = pre.AddDays(-1);
                }
            } else
            {
                pre = new DateTime(current.Year, current.Month, 1);
                int count = freq;
                while (count >= 0)
                {
                    if (pre.DayOfWeek == DayOfWeek.Monday)
                    {
                        pre = pre.AddDays(5);
                        count--;
                    }
                    else if (pre.DayOfWeek == DayOfWeek.Tuesday)
                    {
                        pre = pre.AddDays(4);
                        count--;
                    }
                    else if(pre.DayOfWeek == DayOfWeek.Wednesday)
                    {
                        pre = pre.AddDays(3);
                        count--;
                    }
                    else if (pre.DayOfWeek == DayOfWeek.Thursday)
                    {
                        pre = pre.AddDays(2);
                        count--;
                    } 
                    else if (pre.DayOfWeek == DayOfWeek.Friday || pre.DayOfWeek == DayOfWeek.Saturday)
                    {
                        pre = pre.AddDays(1);
                        count--;
                    }
                    else if(pre.DayOfWeek == DayOfWeek.Sunday)
                    {
                        pre = pre.AddDays(6);
                        count--;
                    }
                }
            }
            return pre;
        }
    }
}
