using Xunit;
using FluentAssertions;

namespace SchedulerV3.Test.Calculates_Test
{
    public class CalculateMonthlyDayDailyEveryTests
    {
        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_before_day_occurs_every_hour()
        {
            //Arrange
            var settings = new Settings
            {
                currentDate = new System.DateTime(2022, 06, 09, 8, 10, 0),
                occurs = 1,
                numDay = 15,
                numMonths = 2,
                day = true,
                occursEvery = true,
                occursEveryFreq = 1,
                freq = 0,
                needToAddDay = false,
                startingHour = new System.DateTime(2000, 01, 01, 10, 0, 0),
                endingHour = new System.DateTime(2000, 01, 01, 16, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 06, 15, 10, 0, 0);
            //Act
            CalculateRecurring.calculate(settings);
            //Assert
            settings.nextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_in_day_before_hour_occurs_every_hour()
        {
            //Arrange
            var settings = new Settings
            {
                currentDate = new System.DateTime(2022, 06, 09, 8, 10, 0),
                occurs = 1,
                numDay = 09,
                numMonths = 2,
                day = true,
                occursEvery = true,
                occursEveryFreq = 1,
                freq = 0,
                needToAddDay = false,
                startingHour = new System.DateTime(2000, 01, 01, 10, 0, 0),
                endingHour = new System.DateTime(2000, 01, 01, 16, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 06, 09, 10, 0, 0);
            //Act
            CalculateRecurring.calculate(settings);
            //Assert
            settings.nextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_in_day_in_hour_occurs_every_hour()
        {
            //Arrange
            var settings = new Settings
            {
                currentDate = new System.DateTime(2022, 06, 09, 10, 10, 0),
                occurs = 1,
                numDay = 09,
                numMonths = 2,
                day = true,
                occursEvery = true,
                occursEveryFreq = 1,
                freq = 0,
                needToAddDay = false,
                startingHour = new System.DateTime(2000, 01, 01, 10, 0, 0),
                endingHour = new System.DateTime(2000, 01, 01, 16, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 06, 09, 11, 0, 0);
            //Act
            CalculateRecurring.calculate(settings);
            //Assert
            settings.nextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_in_day_over_hour_occurs_every_hour()
        {
            //Arrange
            var settings = new Settings
            {
                currentDate = new System.DateTime(2022, 06, 09, 13, 10, 0),
                occurs = 1,
                numDay = 09,
                numMonths = 2,
                day = true,
                occursEvery = true,
                occursEveryFreq = 1,
                freq = 0,
                needToAddDay = true,
                startingHour = new System.DateTime(2000, 01, 01, 10, 0, 0),
                endingHour = new System.DateTime(2000, 01, 01, 12, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 08, 09, 10, 0, 0);
            //Act
            CalculateRecurring.calculate(settings);
            //Assert
            settings.nextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_over_day_occurs_every_hour()
        {
            //Arrange
            var settings = new Settings
            {
                currentDate = new System.DateTime(2022, 06, 09, 13, 10, 0),
                occurs = 1,
                numDay = 08,
                numMonths = 2,
                day = true,
                occursEvery = true,
                occursEveryFreq = 1,
                freq = 0,
                needToAddDay = true,
                startingHour = new System.DateTime(2000, 01, 01, 10, 0, 0),
                endingHour = new System.DateTime(2000, 01, 01, 12, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 08, 08, 10, 0, 0);
            //Act
            CalculateRecurring.calculate(settings);
            //Assert
            settings.nextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_before_day_occurs_every_minutes()
        {
            //Arrange
            var settings = new Settings
            {
                currentDate = new System.DateTime(2022, 06, 09, 8, 10, 0),
                occurs = 1,
                numDay = 15,
                numMonths = 2,
                day = true,
                occursEvery = true,
                occursEveryFreq = 30,
                freq = 1,
                needToAddDay = false,
                startingHour = new System.DateTime(2000, 01, 01, 10, 0, 0),
                endingHour = new System.DateTime(2000, 01, 01, 16, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 06, 15, 10, 0, 0);
            //Act
            CalculateRecurring.calculate(settings);
            //Assert
            settings.nextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_in_day_before_hour_occurs_every_minutes()
        {
            //Arrange
            var settings = new Settings
            {
                currentDate = new System.DateTime(2022, 06, 09, 8, 10, 0),
                occurs = 1,
                numDay = 09,
                numMonths = 2,
                day = true,
                occursEvery = true,
                occursEveryFreq = 30,
                freq = 1,
                needToAddDay = false,
                startingHour = new System.DateTime(2000, 01, 01, 10, 0, 0),
                endingHour = new System.DateTime(2000, 01, 01, 16, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 06, 09, 10, 0, 0);
            //Act
            CalculateRecurring.calculate(settings);
            //Assert
            settings.nextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_in_day_in_hour_occurs_every_minutes()
        {
            //Arrange
            var settings = new Settings
            {
                currentDate = new System.DateTime(2022, 06, 09, 10, 10, 0),
                occurs = 1,
                numDay = 09,
                numMonths = 2,
                day = true,
                occursEvery = true,
                occursEveryFreq = 30,
                freq = 1,
                needToAddDay = false,
                startingHour = new System.DateTime(2000, 01, 01, 10, 0, 0),
                endingHour = new System.DateTime(2000, 01, 01, 16, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 06, 09, 10, 30, 0);
            //Act
            CalculateRecurring.calculate(settings);
            //Assert
            settings.nextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_in_day_over_hour_occurs_every_minutes()
        {
            //Arrange
            var settings = new Settings
            {
                currentDate = new System.DateTime(2022, 06, 09, 13, 10, 0),
                occurs = 1,
                numDay = 09,
                numMonths = 2,
                day = true,
                occursEvery = true,
                occursEveryFreq = 30,
                freq = 1,
                needToAddDay = true,
                startingHour = new System.DateTime(2000, 01, 01, 10, 0, 0),
                endingHour = new System.DateTime(2000, 01, 01, 12, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 08, 09, 10, 0, 0);
            //Act
            CalculateRecurring.calculate(settings);
            //Assert
            settings.nextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_over_day_occurs_every_minutes()
        {
            //Arrange
            var settings = new Settings
            {
                currentDate = new System.DateTime(2022, 06, 09, 13, 10, 0),
                occurs = 1,
                numDay = 08,
                numMonths = 2,
                day = true,
                occursEvery = true,
                occursEveryFreq = 30,
                freq = 1,
                needToAddDay = true,
                startingHour = new System.DateTime(2000, 01, 01, 10, 0, 0),
                endingHour = new System.DateTime(2000, 01, 01, 12, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 08, 08, 10, 0, 0);
            //Act
            CalculateRecurring.calculate(settings);
            //Assert
            settings.nextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }
    }
}
