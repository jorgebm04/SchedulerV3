using Xunit;
using FluentAssertions;

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
                currentDate = new System.DateTime(2022, 05, 27, 8, 10, 0),
                occurs = 0,
                occursOnceAt = true,
                occursOnceAtHour = new System.DateTime(2022, 05, 30, 14, 0, 0),
                needToAddDay = false
            };
            var expectedDate = new System.DateTime(2022, 05, 27, 14, 0, 0);
            //Act
            CalculateRecurring.calculate(settings);
            //Assert
            settings.nextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_daily_occurs_once_over_time()
        {
            //Arrange
            var settings = new Settings
            {
                currentDate = new System.DateTime(2022, 05, 27, 14, 10, 0),
                occurs = 0,
                occursOnceAt = true,                
                occursOnceAtHour = new System.DateTime(2022, 05, 27, 8, 0, 0),
                needToAddDay = true
            };
            var expectedDate = new System.DateTime(2022, 05, 28, 8, 0, 0);
            //Act
            CalculateRecurring.calculate(settings);
            //Assert
            settings.nextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }
    }
}
