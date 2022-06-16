using SchedulerV3.Enums;

namespace SchedulerV3.Calculate
{
    public static class FreqSetter
    {
        public static String SetFreq(Settings settings)
        {
            string freq;
            if (settings.MonthlyFreq == (int)OccursDayEnum.OccursDay.First)
            {
                freq = "first";
            }
            else if (settings.MonthlyFreq == (int)OccursDayEnum.OccursDay.Second)
            {
                freq = "second";
            }
            else if (settings.MonthlyFreq == (int)OccursDayEnum.OccursDay.Third)
            {
                freq = "third";
            }
            else if (settings.MonthlyFreq == (int)OccursDayEnum.OccursDay.Fourth)
            {
                freq = "fourth";
            }
            else
            {
                freq = "last";
            }
            return freq;
        }
    }
}
