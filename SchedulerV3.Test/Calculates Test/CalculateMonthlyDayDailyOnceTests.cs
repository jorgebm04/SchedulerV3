using Xunit;
using FluentAssertions;

namespace SchedulerV3.Test.Calculates_Test
{
    public class CalculateMonthlyDayDailyOnceTests
    {
        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_before_day_occurs_once()
        {
            //Arrange
            var settings = new Settings
            {
                currentDate = new System.DateTime(2022, 06, 09, 8, 10, 0),
                occurs = 1,
                numDay = 15,
                numMonths = 2,
                day = true,
                occursOnceAt = true,
                occursOnceAtHour = new System.DateTime(2000, 01, 1, 14, 0, 0),
                needToAddDay = false
            };
            var expectedDate = new System.DateTime(2022, 06, 15, 14, 0, 0);
            //Act
            CalculateRecurring.calculate(settings);
            //Assert
            settings.nextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_in_day_before_hour_occurs_once()
        {
            //Arrange
            var settings = new Settings
            {
                currentDate = new System.DateTime(2022, 06, 09, 8, 10, 0),
                occurs = 1,
                numDay = 9,
                numMonths = 2,
                day = true,
                occursOnceAt = true,
                occursOnceAtHour = new System.DateTime(2000, 01, 1, 14, 0, 0),
                needToAddDay = false
            };
            var expectedDate = new System.DateTime(2022, 06, 9, 14, 0, 0);
            //Act
            CalculateRecurring.calculate(settings);
            //Assert
            settings.nextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_in_day_after_hour_occurs_once()
        {
            //Arrange
            var settings = new Settings
            {
                currentDate = new System.DateTime(2022, 06, 09, 10, 10, 0),
                occurs = 1,
                numDay = 9,
                numMonths = 2,
                day = true,
                occursOnceAt = true,
                occursOnceAtHour = new System.DateTime(2000, 01, 1, 8, 0, 0),
                needToAddDay = true
            };
            var expectedDate = new System.DateTime(2022, 08, 9, 8, 0, 0);
            //Act
            CalculateRecurring.calculate(settings);
            //Assert
            settings.nextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_over_day_occurs_once()
        {
            //Arrange
            var settings = new Settings
            {
                currentDate = new System.DateTime(2022, 06, 09, 10, 10, 0),
                occurs = 1,
                numDay = 7,
                numMonths = 2,
                day = true,
                occursOnceAt = true,
                occursOnceAtHour = new System.DateTime(2000, 01, 1, 8, 0, 0),
                needToAddDay = true
            };
            var expectedDate = new System.DateTime(2022, 08, 7, 8, 0, 0);
            //Act
            CalculateRecurring.calculate(settings);
            //Assert
            settings.nextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }
    }
}
