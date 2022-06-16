using Xunit;
using FluentAssertions;
using SchedulerV3.Calculate;

namespace SchedulerV3.Test.Calculates_Test
{
    public class CalculateRecurringDailyOnceTests
    {
        [Fact]
        public void Validate_calculated_date_type_recurring_daily_occurs_once()
        {
            //Arrange
            var settings = new Settings
            {
                CurrentDate = new System.DateTime(2022, 05, 27, 8, 10, 0),
                Occurs = 0,
                OccursOnceAt = true,
                OccursOnceAtHour = new System.DateTime(2022, 05, 30, 14, 0, 0),
                NeedToAddDay = false
            };
            var expectedDate = new System.DateTime(2022, 05, 27, 14, 0, 0);
            //Act
            CalculateRecurring.Calculate(settings);
            //Assert
            settings.NextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_daily_occurs_once_over_time()
        {
            //Arrange
            var settings = new Settings
            {
                CurrentDate = new System.DateTime(2022, 05, 27, 14, 10, 0),
                Occurs = 0,
                OccursOnceAt = true,                
                OccursOnceAtHour = new System.DateTime(2022, 05, 27, 8, 0, 0),
                NeedToAddDay = true
            };
            var expectedDate = new System.DateTime(2022, 05, 28, 8, 0, 0);
            //Act
            CalculateRecurring.Calculate(settings);
            //Assert
            settings.NextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }
    }
}
