using System.Collections;

namespace SchedulerV3
{
    public class Settings
    {
        public DateTime currentDate { get; set; }
        public int type { get; set; }
        public bool enabled { get; set; }
        public DateTime onceTimeAt { get; set; }
        public int occurs { get; set; }
        public bool day { get; set; }
        public int numDay { get; set; }
        public int numMonths { get; set; }
        public bool the { get; set; }
        public int monthlyFreq { get; set; }
        public int dailyFreq { get; set; }
        public int monthly2Freq { get; set; }
        public bool occursOnceAt { get; set; }
        public DateTime occursOnceAtHour { get; set; }
        public bool occursEvery { get; set; }
        public int occursEveryFreq { get; set; }
        public int freq { get; set; }
        public string? freqTime { get; set; }
        public DateTime startingHour { get; set; }
        public DateTime endingHour { get; set; }
        public DateTime startingLimit { get; set; }
        public DateTime endingLimit { get; set; }
        public String? nextExecutionTime { get; set; }
        public String? description { get; set; }
        public DateTime calculatedDate { get; set; }
        public bool needToAddDay { get; set; }
        public int lastDay { get; set; }
        public SortedList days = new SortedList();
        public String? dayOfTheWeek { get; set; }
    }
}