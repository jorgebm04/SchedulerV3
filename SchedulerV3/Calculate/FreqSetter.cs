namespace SchedulerV3
{
    public static class FreqSetter
    {
        public static String SetFreq(Settings settings)
        {
            string freq;
            if (settings.MonthlyFreq == (int)OccursDayEnum.OccursDay.first)
            {
                freq = "first";
            }
            else if (settings.MonthlyFreq == (int)OccursDayEnum.OccursDay.second)
            {
                freq = "second";
            }
            else if (settings.MonthlyFreq == (int)OccursDayEnum.OccursDay.third)
            {
                freq = "third";
            }
            else if (settings.MonthlyFreq == (int)OccursDayEnum.OccursDay.fourth)
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
