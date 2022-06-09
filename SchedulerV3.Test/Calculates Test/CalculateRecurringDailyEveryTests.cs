using Xunit;
using FluentAssertions;

namespace SchedulerV3.Test.Calculates_Test
{
    public class CalculateRecurringDailyEveryTests
    {
        [Fact]
        public void Validate_calculated_date_type_recurring_daily_every_hour()
        {
            //Arrange
            var settings = new Settings
            {
                currentDate = new System.DateTime(2022, 05, 27, 8, 10, 0),
                occurs = 0,
                occursEvery = true,
                occursEveryFreq = 1,
                freq = 0,
                needToAddDay = false,
                startingHour = new System.DateTime(2022, 05, 27, 10, 0, 0),
                endingHour = new System.DateTime(2022, 05, 27, 16, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 05, 27, 10, 0, 0);
            //Act
            CalculateRecurring.calculate(settings);
            //Assert
            settings.nextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_daily_every_hour_in_limits()
        {
            //Arrange
            var settings = new Settings
            {
                currentDate = new System.DateTime(2022, 05, 27, 12, 10, 0),
                occurs = 0,
                occursEvery = true,
                occursEveryFreq = 1,
                freq = 0,
                needToAddDay = false,
                startingHour = new System.DateTime(2022, 05, 27, 10, 0, 0),
                endingHour = new System.DateTime(2022, 05, 27, 16, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 05, 27, 13, 0, 0);
            //Act
            CalculateRecurring.calculate(settings);
            //Assert
            settings.nextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_daily_every_hour_in_over_limits()
        {
            //Arrange
            var settings = new Settings
            {
                currentDate = new System.DateTime(2022, 05, 27, 12, 15, 0),
                occurs = 0,
                occursEvery = true,
                occursEveryFreq = 1,
                freq = 0,
                needToAddDay = false,
                startingHour = new System.DateTime(2022, 05, 27, 12, 0, 0),
                endingHour = new System.DateTime(2022, 05, 27, 12, 30, 0)
            };
            var expectedDate = new System.DateTime(2022, 05, 27, 12, 30, 0);
            //Act
            CalculateRecurring.calculate(settings);
            //Assert
            settings.nextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_daily_every_hour_over_limits()
        {
            //Arrange
            var settings = new Settings
            {
                currentDate = new System.DateTime(2022, 05, 27, 12, 15, 0),
                occurs = 0,
                occursEvery = true,
                occursEveryFreq = 1,
                freq = 0,
                needToAddDay = true,
                startingHour = new System.DateTime(2022, 05, 27, 10, 0, 0),
                endingHour = new System.DateTime(2022, 05, 27, 12, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 05, 28, 10, 0, 0);
            //Act
            CalculateRecurring.calculate(settings);
            //Assert
            settings.nextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_daily_every_minute()
        {
            //Arrange
            var settings = new Settings
            {
                currentDate = new System.DateTime(2022, 05, 27, 8, 10, 0),
                occurs = 0,
                occursEvery = true,
                occursEveryFreq = 30,
                freq = 1,
                needToAddDay = false,
                startingHour = new System.DateTime(2022, 05, 27, 10, 0, 0),
                endingHour = new System.DateTime(2022, 05, 27, 16, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 05, 27, 10, 0, 0);
            //Act
            CalculateRecurring.calculate(settings);
            //Assert
            settings.nextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_daily_every_minute_in_limits()
        {
            //Arrange
            var settings = new Settings
            {
                currentDate = new System.DateTime(2022, 05, 27, 12, 10, 0),
                occurs = 0,
                occursEvery = true,
                occursEveryFreq = 30,
                freq = 1,
                needToAddDay = false,
                startingHour = new System.DateTime(2022, 05, 27, 10, 0, 0),
                endingHour = new System.DateTime(2022, 05, 27, 16, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 05, 27, 12, 30, 0);
            //Act
            CalculateRecurring.calculate(settings);
            //Assert
            settings.nextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_daily_every_minute_in_over_limits()
        {
            //Arrange
            var settings = new Settings
            {
                currentDate = new System.DateTime(2022, 05, 27, 12, 10, 0),
                occurs = 0,
                occursEvery = true,
                occursEveryFreq = 30,
                freq = 1,
                needToAddDay = false,
                startingHour = new System.DateTime(2022, 05, 27, 12, 0, 0),
                endingHour = new System.DateTime(2022, 05, 27, 12, 15, 0)
            };
            var expectedDate = new System.DateTime(2022, 05, 27, 12, 15, 0);
            //Act
            CalculateRecurring.calculate(settings);
            //Assert
            settings.nextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_daily_every_minute_over_limits()
        {
            //Arrange
            var settings = new Settings
            {
                currentDate = new System.DateTime(2022, 05, 27, 12, 15, 0),
                occurs = 0,
                occursEvery = true,
                occursEveryFreq = 1,
                freq = 1,
                needToAddDay = true,
                startingHour = new System.DateTime(2022, 05, 27, 10, 0, 0),
                endingHour = new System.DateTime(2022, 05, 27, 12, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 05, 28, 10, 0, 0);
            //Act
            CalculateRecurring.calculate(settings);
            //Assert
            settings.nextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }
    }
}
