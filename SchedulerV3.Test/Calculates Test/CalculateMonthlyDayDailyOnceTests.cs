using Xunit;
using FluentAssertions;

namespace SchedulerV3.Test.Calculates_Test
{
    public class CalculateMonthlyDayDailyOnceTests
    {
        //-------------------- NOT IN LIMITS -------------------//
        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_not_in_limits()
        {
            //Arrange
            var settings = new Settings
            {
                currentDate = new System.DateTime(2022, 06, 09, 8, 10, 0),
                occurs = 1,
                numDay = 15,
                numMonths = 4,
                day = true,
                occursOnceAt = true,
                occursOnceAtHour = new System.DateTime(2000, 01, 1, 14, 0, 0),
                needToAddDay = false,
                startingLimit = new System.DateTime(2022, 1, 1, 0, 0, 0),
                endingLimit = new System.DateTime(2022, 07, 1, 0, 0, 0)
            };
            //Act
            CalculateRecurring.calculate(settings);
            //Assert
            settings.nextExecutionTime.Should().Be("Next execution over end date limits");
        }

        //-------------------- IN LIMITS -------------------//
        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_not_in_month_occurs_once()
        {
            //Arrange
            var settings = new Settings
            {
                currentDate = new System.DateTime(2022, 06, 09, 8, 10, 0),
                occurs = 1,
                numDay = 15,
                numMonths = 4,
                day = true,
                occursOnceAt = true,
                occursOnceAtHour = new System.DateTime(2000, 01, 1, 14, 0, 0),
                needToAddDay = false,
                startingLimit = new System.DateTime(2022, 1, 1, 0, 0, 0),
                endingLimit = new System.DateTime(2022, 12, 31, 0, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 08, 15, 14, 0, 0);
            //Act
            CalculateRecurring.calculate(settings);
            //Assert
            settings.nextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_in_month_before_day_occurs_once()
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
                needToAddDay = false,
                startingLimit = new System.DateTime(2022, 1, 1, 0, 0, 0),
                endingLimit = new System.DateTime(2022, 12, 31, 0, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 06, 15, 14, 0, 0);
            //Act
            CalculateRecurring.calculate(settings);
            //Assert
            settings.nextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }


        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_in_month_in_day_before_hour_occurs_once()
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
                needToAddDay = false,
                startingLimit = new System.DateTime(2022, 1, 1, 0, 0, 0),
                endingLimit = new System.DateTime(2022, 12, 31, 0, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 06, 9, 14, 0, 0);
            //Act
            CalculateRecurring.calculate(settings);
            //Assert
            settings.nextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_in_month_in_day_after_hour_occurs_once()
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
                needToAddDay = true,
                startingLimit = new System.DateTime(2022, 1, 1, 0, 0, 0),
                endingLimit = new System.DateTime(2022, 12, 31, 0, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 08, 9, 8, 0, 0);
            //Act
            CalculateRecurring.calculate(settings);
            //Assert
            settings.nextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_in_month_over_day_occurs_once()
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
                needToAddDay = true,
                startingLimit = new System.DateTime(2022, 1, 1, 0, 0, 0),
                endingLimit = new System.DateTime(2022, 12, 31, 0, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 08, 7, 8, 0, 0);
            //Act
            CalculateRecurring.calculate(settings);
            //Assert
            settings.nextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }
    }
}
