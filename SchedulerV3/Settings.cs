using System.Diagnostics.CodeAnalysis;

namespace SchedulerV3
{
    [ExcludeFromCodeCoverage]
    public class Settings
    {
        public DateTime CurrentDate { get; set; }
        public int Type { get; init; }
        public bool Enabled { get; set; }
        public DateTime OnceTimeAt { get; init; }
        public int Occurs { get; init; }
        public bool Day { get; init; }
        public int NumDay { get; init; }
        public int NumMonths { get; init; }
        public bool The { get; init; }
        public int MonthlyFreq { get; init; }
        public int DailyFreq { get; init; }
        public int Monthly2Freq { get; init; }
        public bool OccursOnceAt { get; init; }
        public DateTime OccursOnceAtHour { get; init; }
        public bool OccursEvery { get; init; }
        public int OccursEveryFreq { get; init; }
        public int Freq { get; init; }
        public string? FreqTime { get; init; }
        public DateTime StartingHour { get; init; }
        public DateTime EndingHour { get; init; }
        public DateTime StartingLimit { get; init; }
        public DateTime EndingLimit { get; init; }
        public String? NextExecutionTime { get; set; }
        public String? Description { get; set; }
        public DateTime CalculatedDate { get; set; }
        public bool NeedToAddDay { get; set; }
        public int LastDay { get; set; }
        public String? DayOfTheWeek { get; set; }
        public bool IsOverLimit { get; set; }
    }
}