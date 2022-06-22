namespace SchedulerV3.Calculate
{
    public static class CalculateTheDay
    {
        public static DateTime Calculate(DayOfWeek day, DateTime current,int freq)
        {
            DateTime pre;
            if(freq == 4)
            {
                int daysInMonth = DateTime.DaysInMonth(current.Year, current.Month);
                pre = new DateTime(current.Year, current.Month, daysInMonth, current.Hour, current.Minute, current.Second);
                while(pre.DayOfWeek != day)
                {
                    pre = pre.AddDays(-1);
                }
            } 
            else
            {
                pre = new DateTime(current.Year, current.Month, 1, current.Hour,current.Minute,current.Second);
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
            DateTime pre = new (current.Year, current.Month, 1);
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
                pre = new DateTime(current.Year, current.Month, daysInMonth, current.Hour, current.Minute, current.Second);
                while (pre.DayOfWeek != DayOfWeek.Monday && pre.DayOfWeek != DayOfWeek.Tuesday && pre.DayOfWeek != DayOfWeek.Wednesday &&
                    pre.DayOfWeek != DayOfWeek.Thursday && pre.DayOfWeek != DayOfWeek.Friday)
                {
                    pre = pre.AddDays(-1);
                }
            } else
            {
                pre = new DateTime(current.Year, current.Month, 1,current.Hour,current.Minute,current.Second);
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
                pre = new DateTime(current.Year, current.Month, daysInMonth, current.Hour, current.Minute, current.Second);
                while (pre.DayOfWeek != DayOfWeek.Saturday && pre.DayOfWeek != DayOfWeek.Sunday)
                {
                    pre = pre.AddDays(-1);
                }
            } else
            {
                pre = new DateTime(current.Year, current.Month, 1,current.Hour, current.Minute, current.Second);
                int count = freq;
                while (count >= 0)
                {
                    switch (pre.DayOfWeek)
                    {
                        case DayOfWeek.Monday:
                            pre = pre.AddDays(5);
                            count--;
                            break;
                        case DayOfWeek.Tuesday:
                            pre = pre.AddDays(4);
                            count--;
                            break;
                        case DayOfWeek.Wednesday:
                            pre = pre.AddDays(3);
                            count--;
                            break;
                        case DayOfWeek.Thursday:
                            pre = pre.AddDays(2);
                            count--;
                            break;
                        case DayOfWeek.Friday:
                        case DayOfWeek.Saturday:
                            pre = pre.AddDays(1);
                            count--;
                            break;
                        case DayOfWeek.Sunday:
                            pre = pre.AddDays(6);
                            count--;
                            break;
                    }
                }
            }
            return pre;
        }
    }
}
