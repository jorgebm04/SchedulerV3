namespace SchedulerV3
{
    public static class FreqSetter
    {
        public static String SetFreq(Settings settings)
        {
            String freq = "";
            if (settings.monthlyFreq == (int)OccursDayEnum.OccursDay.first)
            {
                freq = "first";
            }
            else if (settings.monthlyFreq == (int)OccursDayEnum.OccursDay.second)
            {
                freq = "second";
            }
            else if (settings.monthlyFreq == (int)OccursDayEnum.OccursDay.third)
            {
                freq = "third";
            }
            else if (settings.monthlyFreq == (int)OccursDayEnum.OccursDay.fourth)
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
