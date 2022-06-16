using Xunit;
using FluentAssertions;
using SchedulerV3.Calculate;

namespace SchedulerV3.Test.Calculates_Test
{
    public class CalculateMonthlyDayDailyEveryTests
    {
        //-------------------- NOT IN LIMITS -------------------//
        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_not_in_limits()
        {
            //Arrange
            var settings = new Settings
            {
                CurrentDate = new System.DateTime(2022, 06, 09, 8, 10, 0),
                Occurs = 1,
                NumDay = 15,
                NumMonths = 4,
                Day = true,
                OccursEvery = true,
                OccursEveryFreq = 1,
                Freq = 0,
                NeedToAddDay = false,
                StartingHour = new System.DateTime(2000, 01, 01, 10, 0, 0),
                EndingHour = new System.DateTime(2000, 01, 01, 16, 0, 0),
                StartingLimit = new System.DateTime(2022,1,1,0,0,0),
                EndingLimit = new System.DateTime(2022,07,1,0,0,0)
            };
            //Act
            CalculateRecurring.Calculate(settings);
            //Assert
            settings.NextExecutionTime.Should().Be("Next execution over end date limits");
        }

        //-------------------- IN LIMITS -------------------//
        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_not_in_month()
        {
            //Arrange
            var settings = new Settings
            {
                CurrentDate = new System.DateTime(2022, 06, 09, 8, 10, 0),
                Occurs = 1,
                NumDay = 15,
                NumMonths = 4,
                Day = true,
                OccursEvery = true,
                OccursEveryFreq = 1,
                Freq = 0,
                NeedToAddDay = false,
                StartingHour = new System.DateTime(2000, 01, 01, 10, 0, 0),
                EndingHour = new System.DateTime(2000, 01, 01, 16, 0, 0),
                StartingLimit = new System.DateTime(2022, 1, 1, 0, 0, 0),
                EndingLimit = new System.DateTime(2022, 12, 31, 0, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 08, 15, 10, 0, 0);
            //Act
            CalculateRecurring.Calculate(settings);
            //Assert
            settings.NextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_in_month_before_day_occurs_every_hour()
        {
            //Arrange
            var settings = new Settings
            {
                CurrentDate = new System.DateTime(2022, 06, 09, 8, 10, 0),
                Occurs = 1,
                NumDay = 15,
                NumMonths = 2,
                Day = true,
                OccursEvery = true,
                OccursEveryFreq = 1,
                Freq = 0,
                NeedToAddDay = false,
                StartingHour = new System.DateTime(2000, 01, 01, 10, 0, 0),
                EndingHour = new System.DateTime(2000, 01, 01, 16, 0, 0),
                StartingLimit = new System.DateTime(2022, 1, 1, 0, 0, 0),
                EndingLimit = new System.DateTime(2022, 12, 31, 0, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 06, 15, 10, 0, 0);
            //Act
            CalculateRecurring.Calculate(settings);
            //Assert
            settings.NextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_in_month_in_day_before_hour_occurs_every_hour()
        {
            //Arrange
            var settings = new Settings
            {
                CurrentDate = new System.DateTime(2022, 06, 09, 8, 10, 0),
                Occurs = 1,
                NumDay = 09,
                NumMonths = 2,
                Day = true,
                OccursEvery = true,
                OccursEveryFreq = 1,
                Freq = 0,
                NeedToAddDay = false,
                StartingHour = new System.DateTime(2000, 01, 01, 10, 0, 0),
                EndingHour = new System.DateTime(2000, 01, 01, 16, 0, 0),
                StartingLimit = new System.DateTime(2022, 1, 1, 0, 0, 0),
                EndingLimit = new System.DateTime(2022, 12, 31, 0, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 06, 09, 10, 0, 0);
            //Act
            CalculateRecurring.Calculate(settings);
            //Assert
            settings.NextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_in_month_in_day_in_hour_occurs_every_hour()
        {
            //Arrange
            var settings = new Settings
            {
                CurrentDate = new System.DateTime(2022, 06, 09, 10, 10, 0),
                Occurs = 1,
                NumDay = 09,
                NumMonths = 2,
                Day = true,
                OccursEvery = true,
                OccursEveryFreq = 1,
                Freq = 0,
                NeedToAddDay = false,
                StartingHour = new System.DateTime(2000, 01, 01, 10, 0, 0),
                EndingHour = new System.DateTime(2000, 01, 01, 16, 0, 0),
                StartingLimit = new System.DateTime(2022, 1, 1, 0, 0, 0),
                EndingLimit = new System.DateTime(2022, 12, 31, 0, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 06, 09, 11, 0, 0);
            //Act
            CalculateRecurring.Calculate(settings);
            //Assert
            settings.NextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_in_month_in_day_over_hour_occurs_every_hour()
        {
            //Arrange
            var settings = new Settings
            {
                CurrentDate = new System.DateTime(2022, 06, 09, 13, 10, 0),
                Occurs = 1,
                NumDay = 09,
                NumMonths = 2,
                Day = true,
                OccursEvery = true,
                OccursEveryFreq = 1,
                Freq = 0,
                NeedToAddDay = true,
                StartingHour = new System.DateTime(2000, 01, 01, 10, 0, 0),
                EndingHour = new System.DateTime(2000, 01, 01, 12, 0, 0),
                StartingLimit = new System.DateTime(2022, 1, 1, 0, 0, 0),
                EndingLimit = new System.DateTime(2022, 12, 31, 0, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 08, 09, 10, 0, 0);
            //Act
            CalculateRecurring.Calculate(settings);
            //Assert
            settings.NextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_in_month_over_day_occurs_every_hour()
        {
            //Arrange
            var settings = new Settings
            {
                CurrentDate = new System.DateTime(2022, 06, 09, 13, 10, 0),
                Occurs = 1,
                NumDay = 08,
                NumMonths = 2,
                Day = true,
                OccursEvery = true,
                OccursEveryFreq = 1,
                Freq = 0,
                NeedToAddDay = true,
                StartingHour = new System.DateTime(2000, 01, 01, 10, 0, 0),
                EndingHour = new System.DateTime(2000, 01, 01, 12, 0, 0),
                StartingLimit = new System.DateTime(2022, 1, 1, 0, 0, 0),
                EndingLimit = new System.DateTime(2022, 12, 31, 0, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 08, 08, 10, 0, 0);
            //Act
            CalculateRecurring.Calculate(settings);
            //Assert
            settings.NextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_in_month_before_day_occurs_every_minutes()
        {
            //Arrange
            var settings = new Settings
            {
                CurrentDate = new System.DateTime(2022, 06, 09, 8, 10, 0),
                Occurs = 1,
                NumDay = 15,
                NumMonths = 2,
                Day = true,
                OccursEvery = true,
                OccursEveryFreq = 30,
                Freq = 1,
                NeedToAddDay = false,
                StartingHour = new System.DateTime(2000, 01, 01, 10, 0, 0),
                EndingHour = new System.DateTime(2000, 01, 01, 16, 0, 0),
                StartingLimit = new System.DateTime(2022, 1, 1, 0, 0, 0),
                EndingLimit = new System.DateTime(2022, 12, 31, 0, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 06, 15, 10, 0, 0);
            //Act
            CalculateRecurring.Calculate(settings);
            //Assert
            settings.NextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_in_month_in_day_before_hour_occurs_every_minutes()
        {
            //Arrange
            var settings = new Settings
            {
                CurrentDate = new System.DateTime(2022, 06, 09, 8, 10, 0),
                Occurs = 1,
                NumDay = 09,
                NumMonths = 2,
                Day = true,
                OccursEvery = true,
                OccursEveryFreq = 30,
                Freq = 1,
                NeedToAddDay = false,
                StartingHour = new System.DateTime(2000, 01, 01, 10, 0, 0),
                EndingHour = new System.DateTime(2000, 01, 01, 16, 0, 0),
                StartingLimit = new System.DateTime(2022, 1, 1, 0, 0, 0),
                EndingLimit = new System.DateTime(2022, 12, 31, 0, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 06, 09, 10, 0, 0);
            //Act
            CalculateRecurring.Calculate(settings);
            //Assert
            settings.NextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_in_month_in_day_in_hour_occurs_every_minutes()
        {
            //Arrange
            var settings = new Settings
            {
                CurrentDate = new System.DateTime(2022, 06, 09, 10, 10, 0),
                Occurs = 1,
                NumDay = 09,
                NumMonths = 2,
                Day = true,
                OccursEvery = true,
                OccursEveryFreq = 30,
                Freq = 1,
                NeedToAddDay = false,
                StartingHour = new System.DateTime(2000, 01, 01, 10, 0, 0),
                EndingHour = new System.DateTime(2000, 01, 01, 16, 0, 0),
                StartingLimit = new System.DateTime(2022, 1, 1, 0, 0, 0),
                EndingLimit = new System.DateTime(2022, 12, 31, 0, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 06, 09, 10, 30, 0);
            //Act
            CalculateRecurring.Calculate(settings);
            //Assert
            settings.NextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_in_month_in_day_over_hour_occurs_every_minutes()
        {
            //Arrange
            var settings = new Settings
            {
                CurrentDate = new System.DateTime(2022, 06, 09, 13, 10, 0),
                Occurs = 1,
                NumDay = 09,
                NumMonths = 2,
                Day = true,
                OccursEvery = true,
                OccursEveryFreq = 30,
                Freq = 1,
                NeedToAddDay = true,
                StartingHour = new System.DateTime(2000, 01, 01, 10, 0, 0),
                EndingHour = new System.DateTime(2000, 01, 01, 12, 0, 0),
                StartingLimit = new System.DateTime(2022, 1, 1, 0, 0, 0),
                EndingLimit = new System.DateTime(2022, 12, 31, 0, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 08, 09, 10, 0, 0);
            //Act
            CalculateRecurring.Calculate(settings);
            //Assert
            settings.NextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_in_month_over_day_occurs_every_minutes()
        {
            //Arrange
            var settings = new Settings
            {
                CurrentDate = new System.DateTime(2022, 06, 09, 13, 10, 0),
                Occurs = 1,
                NumDay = 08,
                NumMonths = 2,
                Day = true,
                OccursEvery = true,
                OccursEveryFreq = 30,
                Freq = 1,
                NeedToAddDay = true,
                StartingHour = new System.DateTime(2000, 01, 01, 10, 0, 0),
                EndingHour = new System.DateTime(2000, 01, 01, 12, 0, 0),
                StartingLimit = new System.DateTime(2022, 1, 1, 0, 0, 0),
                EndingLimit = new System.DateTime(2022, 12, 31, 0, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 08, 08, 10, 0, 0);
            //Act
            CalculateRecurring.Calculate(settings);
            //Assert
            settings.NextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }
    }
}
