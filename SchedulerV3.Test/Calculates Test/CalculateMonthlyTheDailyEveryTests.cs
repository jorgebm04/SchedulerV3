using Xunit;
using FluentAssertions;
using SchedulerV3.Calculate;

namespace SchedulerV3.Test.Calculates_Test
{
    public class CalculateMonthlyTheDailyEveryTests
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
                MonthlyFreq = 0, //First
                DailyFreq = 0, //Monday
                Monthly2Freq = 2, //Num Months
                The = true,
                OccursEvery = true,
                OccursEveryFreq = 1,
                Freq = 0,
                StartingHour = new System.DateTime(2000, 01, 01, 10, 0, 0),
                EndingHour = new System.DateTime(2000, 01, 01, 16, 0, 0),
                StartingLimit = new System.DateTime(2022, 1, 1, 0, 0, 0),
                EndingLimit = new System.DateTime(2022, 07, 1, 0, 0, 0)
            };
            //Act
            CalculateRecurring.Calculate(settings);
            //Assert
            settings.NextExecutionTime.Should().Be("Next execution over end date limits");
        }

        //-------------------- IN LIMITS -------------------//
        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_not_in_months()
        {
            //Arrange
            var settings = new Settings
            {
                CurrentDate = new System.DateTime(2022, 06, 09, 8, 10, 0),
                Occurs = 1,
                MonthlyFreq = 0, //First
                DailyFreq = 0, //Monday
                Monthly2Freq = 4, //Num Months
                The = true,
                OccursEvery = true,
                OccursEveryFreq = 1,
                Freq = 0,
                StartingHour = new System.DateTime(2000, 01, 01, 10, 0, 0),
                EndingHour = new System.DateTime(2000, 01, 01, 16, 0, 0),
                StartingLimit = new System.DateTime(2022, 1, 1, 0, 0, 0),
                EndingLimit = new System.DateTime(2022, 12, 31, 0, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 08, 01, 10, 0, 0);
            //Act
            CalculateRecurring.Calculate(settings);
            //Assert
            settings.NextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }
        //-------------------------------- FIRST TESTS -----------------------------------//
        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_first_monday()
        {
            //Arrange
            var settings = new Settings
            {
                CurrentDate = new System.DateTime(2022, 06, 09, 8, 10, 0),
                Occurs = 1,
                MonthlyFreq = 0, //First
                DailyFreq = 0, //Monday
                Monthly2Freq = 2, //Num Months
                The = true,
                OccursEvery = true,
                OccursEveryFreq = 1,
                Freq = 0,
                StartingHour = new System.DateTime(2000, 01, 01, 10, 0, 0),
                EndingHour = new System.DateTime(2000, 01, 01, 16, 0, 0),
                StartingLimit = new System.DateTime(2022, 1, 1, 0, 0, 0),
                EndingLimit = new System.DateTime(2022, 12, 31, 0, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 08, 01, 10, 0, 0);
            //Act
            CalculateRecurring.Calculate(settings);
            //Assert
            settings.NextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_first_tuesday()
        {
            //Arrange
            var settings = new Settings
            {
                CurrentDate = new System.DateTime(2022, 06, 09, 8, 10, 0),
                Occurs = 1,
                MonthlyFreq = 0, //First
                DailyFreq = 1, //Tuesday
                Monthly2Freq = 2, //Num Months
                OccursEvery = true,
                The = true,
                OccursEveryFreq = 1,
                Freq = 0,
                StartingHour = new System.DateTime(2000, 01, 01, 10, 0, 0),
                EndingHour = new System.DateTime(2000, 01, 01, 16, 0, 0),
                StartingLimit = new System.DateTime(2022, 1, 1, 0, 0, 0),
                EndingLimit = new System.DateTime(2022, 12, 31, 0, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 08, 02, 10, 0, 0);
            //Act
            CalculateRecurring.Calculate(settings);
            //Assert
            settings.NextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_first_wednesday()
        {
            //Arrange
            var settings = new Settings
            {
                CurrentDate = new System.DateTime(2022, 06, 09, 8, 10, 0),
                Occurs = 1,
                MonthlyFreq = 0, //First
                DailyFreq = 2, //Wednesday
                Monthly2Freq = 2, //Num Months
                The = true,
                OccursEveryFreq = 1,
                Freq = 0,
                StartingHour = new System.DateTime(2000, 01, 01, 10, 0, 0),
                EndingHour = new System.DateTime(2000, 01, 01, 16, 0, 0),
                StartingLimit = new System.DateTime(2022, 1, 1, 0, 0, 0),
                EndingLimit = new System.DateTime(2022, 12, 31, 0, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 08, 03, 10, 0, 0);
            //Act
            CalculateRecurring.Calculate(settings);
            //Assert
            settings.NextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_first_thursday()
        {
            //Arrange
            var settings = new Settings
            {
                CurrentDate = new System.DateTime(2022, 06, 09, 8, 10, 0),
                Occurs = 1,
                MonthlyFreq = 0, //First
                DailyFreq = 3, //Thursday
                Monthly2Freq = 2, //Num Months
                The = true,
                OccursEveryFreq = 1,
                Freq = 0,
                StartingHour = new System.DateTime(2000, 01, 01, 10, 0, 0),
                EndingHour = new System.DateTime(2000, 01, 01, 16, 0, 0),
                StartingLimit = new System.DateTime(2022, 1, 1, 0, 0, 0),
                EndingLimit = new System.DateTime(2022, 12, 31, 0, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 08, 04, 10, 0, 0);
            //Act
            CalculateRecurring.Calculate(settings);
            //Assert
            settings.NextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_first_friday()
        {
            //Arrange
            var settings = new Settings
            {
                CurrentDate = new System.DateTime(2022, 06, 09, 8, 10, 0),
                Occurs = 1,
                MonthlyFreq = 0, //First
                DailyFreq = 4, //Friday
                Monthly2Freq = 2, //Num Months
                The = true,
                OccursEveryFreq = 1,
                Freq = 0,
                StartingHour = new System.DateTime(2000, 01, 01, 10, 0, 0),
                EndingHour = new System.DateTime(2000, 01, 01, 16, 0, 0),
                StartingLimit = new System.DateTime(2022, 1, 1, 0, 0, 0),
                EndingLimit = new System.DateTime(2022, 12, 31, 0, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 08, 05, 10, 0, 0);
            //Act
            CalculateRecurring.Calculate(settings);
            //Assert
            settings.NextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_first_saturday()
        {
            //Arrange
            var settings = new Settings
            {
                CurrentDate = new System.DateTime(2022, 06, 09, 8, 10, 0),
                Occurs = 1,
                MonthlyFreq = 0, //First
                DailyFreq = 5, //Saturday
                Monthly2Freq = 2, //Num Months
                The = true,
                OccursEveryFreq = 1,
                Freq = 0,
                StartingHour = new System.DateTime(2000, 01, 01, 10, 0, 0),
                EndingHour = new System.DateTime(2000, 01, 01, 16, 0, 0),
                StartingLimit = new System.DateTime(2022, 1, 1, 0, 0, 0),
                EndingLimit = new System.DateTime(2022, 12, 31, 0, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 08, 06, 10, 0, 0);
            //Act
            CalculateRecurring.Calculate(settings);
            //Assert
            settings.NextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_first_sunday()
        {
            //Arrange
            var settings = new Settings
            {
                CurrentDate = new System.DateTime(2022, 06, 09, 8, 10, 0),
                Occurs = 1,
                MonthlyFreq = 0, //First
                DailyFreq = 6, //Sunday
                Monthly2Freq = 2, //Num Months
                The = true,
                OccursEveryFreq = 1,
                Freq = 0,
                StartingHour = new System.DateTime(2000, 01, 01, 10, 0, 0),
                EndingHour = new System.DateTime(2000, 01, 01, 16, 0, 0),
                StartingLimit = new System.DateTime(2022, 1, 1, 0, 0, 0),
                EndingLimit = new System.DateTime(2022, 12, 31, 0, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 08, 07, 10, 0, 0);
            //Act
            CalculateRecurring.Calculate(settings);
            //Assert
            settings.NextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_first_day()
        {
            //Arrange
            var settings = new Settings
            {
                CurrentDate = new System.DateTime(2022, 06, 09, 8, 10, 0),
                Occurs = 1,
                MonthlyFreq = 0, //First
                DailyFreq = 7, //Day
                Monthly2Freq = 2, //Num Months
                The = true,
                OccursEveryFreq = 1,
                Freq = 0,
                StartingHour = new System.DateTime(2000, 01, 01, 10, 0, 0),
                EndingHour = new System.DateTime(2000, 01, 01, 16, 0, 0),
                StartingLimit = new System.DateTime(2022, 1, 1, 0, 0, 0),
                EndingLimit = new System.DateTime(2022, 12, 31, 0, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 08, 01, 10, 0, 0);
            //Act
            CalculateRecurring.Calculate(settings);
            //Assert
            settings.NextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_first_weekday()
        {
            //Arrange
            var settings = new Settings
            {
                CurrentDate = new System.DateTime(2022, 06, 09, 8, 10, 0),
                Occurs = 1,
                MonthlyFreq = 0, //First
                DailyFreq = 8, //WeekDay
                Monthly2Freq = 2, //Num Months
                The = true,
                OccursEveryFreq = 1,
                Freq = 0,
                StartingHour = new System.DateTime(2000, 01, 01, 10, 0, 0),
                EndingHour = new System.DateTime(2000, 01, 01, 16, 0, 0),
                StartingLimit = new System.DateTime(2022, 1, 1, 0, 0, 0),
                EndingLimit = new System.DateTime(2022, 12, 31, 0, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 08, 01, 10, 0, 0);
            //Act
            CalculateRecurring.Calculate(settings);
            //Assert
            settings.NextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_first_weekend_day()
        {
            //Arrange
            var settings = new Settings
            {
                CurrentDate = new System.DateTime(2022, 06, 09, 8, 10, 0),
                Occurs = 1,
                MonthlyFreq = 0, //First
                DailyFreq = 9, //WeekendDay
                Monthly2Freq = 2, //Num Months
                The = true,
                OccursEveryFreq = 1,
                Freq = 0,
                StartingHour = new System.DateTime(2000, 01, 01, 10, 0, 0),
                EndingHour = new System.DateTime(2000, 01, 01, 16, 0, 0),
                StartingLimit = new System.DateTime(2022, 1, 1, 0, 0, 0),
                EndingLimit = new System.DateTime(2022, 12, 31, 0, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 08, 06, 10, 0, 0);
            //Act
            CalculateRecurring.Calculate(settings);
            //Assert
            settings.NextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        //-------------------------------- SECOND TESTS -----------------------------------//
        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_second_monday()
        {
            //Arrange
            var settings = new Settings
            {
                CurrentDate = new System.DateTime(2022, 06, 09, 8, 10, 0),
                Occurs = 1,
                MonthlyFreq = 1, //Second
                DailyFreq = 0, //Monday
                Monthly2Freq = 2, //Num Months
                The = true,
                OccursEveryFreq = 1,
                Freq = 0,
                StartingHour = new System.DateTime(2000, 01, 01, 10, 0, 0),
                EndingHour = new System.DateTime(2000, 01, 01, 16, 0, 0),
                StartingLimit = new System.DateTime(2022, 1, 1, 0, 0, 0),
                EndingLimit = new System.DateTime(2022, 12, 31, 0, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 06, 13, 10, 0, 0);
            //Act
            CalculateRecurring.Calculate(settings);
            //Assert
            settings.NextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_second_tuesday()
        {
            //Arrange
            var settings = new Settings
            {
                CurrentDate = new System.DateTime(2022, 06, 09, 8, 10, 0),
                Occurs = 1,
                MonthlyFreq = 1, //Second
                DailyFreq = 1, //Tuesday
                Monthly2Freq = 2, //Num Months
                The = true,
                OccursEveryFreq = 1,
                Freq = 0,
                StartingHour = new System.DateTime(2000, 01, 01, 10, 0, 0),
                EndingHour = new System.DateTime(2000, 01, 01, 16, 0, 0),
                StartingLimit = new System.DateTime(2022, 1, 1, 0, 0, 0),
                EndingLimit = new System.DateTime(2022, 12, 31, 0, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 06, 14, 10, 0, 0);
            //Act
            CalculateRecurring.Calculate(settings);
            //Assert
            settings.NextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_second_wednesday()
        {
            //Arrange
            var settings = new Settings
            {
                CurrentDate = new System.DateTime(2022, 06, 09, 8, 10, 0),
                Occurs = 1,
                MonthlyFreq = 1, //second
                DailyFreq = 2, //Wednesday
                Monthly2Freq = 2, //Num Months
                The = true,
                OccursEveryFreq = 1,
                Freq = 0,
                StartingHour = new System.DateTime(2000, 01, 01, 10, 0, 0),
                EndingHour = new System.DateTime(2000, 01, 01, 16, 0, 0),
                StartingLimit = new System.DateTime(2022, 1, 1, 0, 0, 0),
                EndingLimit = new System.DateTime(2022, 12, 31, 0, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 08, 10, 10, 0, 0);
            //Act
            CalculateRecurring.Calculate(settings);
            //Assert
            settings.NextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_second_thursday()
        {
            //Arrange
            var settings = new Settings
            {
                CurrentDate = new System.DateTime(2022, 06, 09, 8, 10, 0),
                Occurs = 1,
                MonthlyFreq = 1, //second
                DailyFreq = 3, //Thursday
                Monthly2Freq = 2, //Num Months
                The = true,
                OccursEveryFreq = 1,
                Freq = 0,
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

        /**
         * In this case 9/6/2022 is the second thursday of June so we must check before and after the hour.
         */
        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_second_thursday_in_time_in_hours()
        {
            //Arrange
            var settings = new Settings
            {
                CurrentDate = new System.DateTime(2022, 06, 09, 8, 10, 0),
                Occurs = 1,
                MonthlyFreq = 1, //second
                DailyFreq = 3, //Thursday
                Monthly2Freq = 2, //Num Months
                The = true,
                OccursEveryFreq = 1,
                Freq = 0,
                StartingHour = new System.DateTime(2000, 01, 01, 8, 0, 0),
                EndingHour = new System.DateTime(2000, 01, 01, 16, 0, 0),
                StartingLimit = new System.DateTime(2022, 1, 1, 0, 0, 0),
                EndingLimit = new System.DateTime(2022, 12, 31, 0, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 06, 9, 9, 0, 0);
            //Act
            CalculateRecurring.Calculate(settings);
            //Assert
            settings.NextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_second_thursday_over_time_in_hours()
        {
            //Arrange
            var settings = new Settings
            {
                CurrentDate = new System.DateTime(2022, 06, 09, 8, 10, 0),
                Occurs = 1,
                MonthlyFreq = 1, //second
                DailyFreq = 3, //Thursday
                Monthly2Freq = 2, //Num Months
                The = true,
                OccursEveryFreq = 1,
                Freq = 0,
                StartingHour = new System.DateTime(2000, 01, 01, 8, 0, 0),
                EndingHour = new System.DateTime(2000, 01, 01, 8, 30, 0),
                StartingLimit = new System.DateTime(2022, 1, 1, 0, 0, 0),
                EndingLimit = new System.DateTime(2022, 12, 31, 0, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 06, 9, 8, 30, 0);
            //Act
            CalculateRecurring.Calculate(settings);
            //Assert
            settings.NextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_second_thursday_over_time_over_hours()
        {
            //Arrange
            var settings = new Settings
            {
                CurrentDate = new System.DateTime(2022, 06, 09, 8, 10, 0),
                Occurs = 1,
                MonthlyFreq = 1, //second
                DailyFreq = 3, //Thursday
                Monthly2Freq = 2, //Num Months
                The = true,
                OccursEveryFreq = 1,
                Freq = 0,
                StartingHour = new System.DateTime(2000, 01, 01, 8, 0, 0),
                EndingHour = new System.DateTime(2000, 01, 01, 8, 5, 0),
                StartingLimit = new System.DateTime(2022, 1, 1, 0, 0, 0),
                EndingLimit = new System.DateTime(2022, 12, 31, 0, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 08, 11, 8, 0, 0);
            //Act
            CalculateRecurring.Calculate(settings);
            //Assert
            settings.NextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_second_friday()
        {
            //Arrange
            var settings = new Settings
            {
                CurrentDate = new System.DateTime(2022, 06, 09, 8, 10, 0),
                Occurs = 1,
                MonthlyFreq = 1, //second
                DailyFreq = 4, //Friday
                Monthly2Freq = 2, //Num Months
                The = true,
                OccursEveryFreq = 1,
                Freq = 0,
                StartingHour = new System.DateTime(2000, 01, 01, 10, 0, 0),
                EndingHour = new System.DateTime(2000, 01, 01, 16, 0, 0),
                StartingLimit = new System.DateTime(2022, 1, 1, 0, 0, 0),
                EndingLimit = new System.DateTime(2022, 12, 31, 0, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 06, 10, 10, 0, 0);
            //Act
            CalculateRecurring.Calculate(settings);
            //Assert
            settings.NextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_second_saturday()
        {
            //Arrange
            var settings = new Settings
            {
                CurrentDate = new System.DateTime(2022, 06, 09, 8, 10, 0),
                Occurs = 1,
                MonthlyFreq = 1, //second
                DailyFreq = 5, //Saturday
                Monthly2Freq = 2, //Num Months
                The = true,
                OccursEveryFreq = 1,
                Freq = 0,
                StartingHour = new System.DateTime(2000, 01, 01, 10, 0, 0),
                EndingHour = new System.DateTime(2000, 01, 01, 16, 0, 0),
                StartingLimit = new System.DateTime(2022, 1, 1, 0, 0, 0),
                EndingLimit = new System.DateTime(2022, 12, 31, 0, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 06, 11, 10, 0, 0);
            //Act
            CalculateRecurring.Calculate(settings);
            //Assert
            settings.NextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_second_sunday()
        {
            //Arrange
            var settings = new Settings
            {
                CurrentDate = new System.DateTime(2022, 06, 09, 8, 10, 0),
                Occurs = 1,
                MonthlyFreq = 1, //second
                DailyFreq = 6, //Sunday
                Monthly2Freq = 2, //Num Months
                The = true,
                OccursEveryFreq = 1,
                Freq = 0,
                StartingHour = new System.DateTime(2000, 01, 01, 10, 0, 0),
                EndingHour = new System.DateTime(2000, 01, 01, 16, 0, 0),
                StartingLimit = new System.DateTime(2022, 1, 1, 0, 0, 0),
                EndingLimit = new System.DateTime(2022, 12, 31, 0, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 06, 12, 10, 0, 0);
            //Act
            CalculateRecurring.Calculate(settings);
            //Assert
            settings.NextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_second_day()
        {
            //Arrange
            var settings = new Settings
            {
                CurrentDate = new System.DateTime(2022, 06, 09, 8, 10, 0),
                Occurs = 1,
                MonthlyFreq = 1, //second
                DailyFreq = 7, //Day
                Monthly2Freq = 2, //Num Months
                The = true,
                OccursEveryFreq = 1,
                Freq = 0,
                StartingHour = new System.DateTime(2000, 01, 01, 10, 0, 0),
                EndingHour = new System.DateTime(2000, 01, 01, 16, 0, 0),
                StartingLimit = new System.DateTime(2022, 1, 1, 0, 0, 0),
                EndingLimit = new System.DateTime(2022, 12, 31, 0, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 08, 02, 10, 0, 0);
            //Act
            CalculateRecurring.Calculate(settings);
            //Assert
            settings.NextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_second_weekday()
        {
            //Arrange
            var settings = new Settings
            {
                CurrentDate = new System.DateTime(2022, 06, 09, 8, 10, 0),
                Occurs = 1,
                MonthlyFreq = 1, //second
                DailyFreq = 8, //WeekDay
                Monthly2Freq = 2, //Num Months
                The = true,
                OccursEveryFreq = 1,
                Freq = 0,
                StartingHour = new System.DateTime(2000, 01, 01, 10, 0, 0),
                EndingHour = new System.DateTime(2000, 01, 01, 16, 0, 0),
                StartingLimit = new System.DateTime(2022, 1, 1, 0, 0, 0),
                EndingLimit = new System.DateTime(2022, 12, 31, 0, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 08, 02, 10, 0, 0);
            //Act
            CalculateRecurring.Calculate(settings);
            //Assert
            settings.NextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_second_weekend_day()
        {
            //Arrange
            var settings = new Settings
            {
                CurrentDate = new System.DateTime(2022, 06, 09, 8, 10, 0),
                Occurs = 1,
                MonthlyFreq = 1, //second
                DailyFreq = 9, //WeekendDay
                Monthly2Freq = 2, //Num Months
                The = true,
                OccursEveryFreq = 1,
                Freq = 0,
                StartingHour = new System.DateTime(2000, 01, 01, 10, 0, 0),
                EndingHour = new System.DateTime(2000, 01, 01, 16, 0, 0),
                StartingLimit = new System.DateTime(2022, 1, 1, 0, 0, 0),
                EndingLimit = new System.DateTime(2022, 12, 31, 0, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 08, 07, 10, 0, 0);
            //Act
            CalculateRecurring.Calculate(settings);
            //Assert
            settings.NextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        //-------------------------------- THIRD TESTS -----------------------------------//
        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_third_monday()
        {
            //Arrange
            var settings = new Settings
            {
                CurrentDate = new System.DateTime(2022, 06, 09, 8, 10, 0),
                Occurs = 1,
                MonthlyFreq = 2, //Third
                DailyFreq = 0, //Monday
                Monthly2Freq = 2, //Num Months
                The = true,
                OccursEveryFreq = 1,
                Freq = 0,
                StartingHour = new System.DateTime(2000, 01, 01, 10, 0, 0),
                EndingHour = new System.DateTime(2000, 01, 01, 16, 0, 0),
                StartingLimit = new System.DateTime(2022, 1, 1, 0, 0, 0),
                EndingLimit = new System.DateTime(2022, 12, 31, 0, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 06, 20, 10, 0, 0);
            //Act
            CalculateRecurring.Calculate(settings);
            //Assert
            settings.NextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_third_tuesday()
        {
            //Arrange
            var settings = new Settings
            {
                CurrentDate = new System.DateTime(2022, 06, 09, 8, 10, 0),
                Occurs = 1,
                MonthlyFreq = 2, //Third
                DailyFreq = 1, //Tuesday
                Monthly2Freq = 2, //Num Months
                The = true,
                OccursEveryFreq = 1,
                Freq = 0,
                StartingHour = new System.DateTime(2000, 01, 01, 10, 0, 0),
                EndingHour = new System.DateTime(2000, 01, 01, 16, 0, 0),
                StartingLimit = new System.DateTime(2022, 1, 1, 0, 0, 0),
                EndingLimit = new System.DateTime(2022, 12, 31, 0, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 06, 21, 10, 0, 0);
            //Act
            CalculateRecurring.Calculate(settings);
            //Assert
            settings.NextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_third_wednesday()
        {
            //Arrange
            var settings = new Settings
            {
                CurrentDate = new System.DateTime(2022, 06, 09, 8, 10, 0),
                Occurs = 1,
                MonthlyFreq = 2, //Third
                DailyFreq = 2, //Wednesday
                Monthly2Freq = 2, //Num Months
                The = true,
                OccursEveryFreq = 1,
                Freq = 0,
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
        public void Validate_calculated_date_type_recurring_monthly_third_thursday()
        {
            //Arrange
            var settings = new Settings
            {
                CurrentDate = new System.DateTime(2022, 06, 09, 8, 10, 0),
                Occurs = 1,
                MonthlyFreq = 2, //Third
                DailyFreq = 3, //Thursday
                Monthly2Freq = 2, //Num Months
                The = true,
                OccursEveryFreq = 1,
                Freq = 0,
                StartingHour = new System.DateTime(2000, 01, 01, 10, 0, 0),
                EndingHour = new System.DateTime(2000, 01, 01, 16, 0, 0),
                StartingLimit = new System.DateTime(2022, 1, 1, 0, 0, 0),
                EndingLimit = new System.DateTime(2022, 12, 31, 0, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 06, 16, 10, 0, 0);
            //Act
            CalculateRecurring.Calculate(settings);
            //Assert
            settings.NextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_third_friday()
        {
            //Arrange
            var settings = new Settings
            {
                CurrentDate = new System.DateTime(2022, 06, 09, 8, 10, 0),
                Occurs = 1,
                MonthlyFreq = 2, //Third
                DailyFreq = 4, //Friday
                Monthly2Freq = 2, //Num Months
                The = true,
                OccursEveryFreq = 1,
                Freq = 0,
                StartingHour = new System.DateTime(2000, 01, 01, 10, 0, 0),
                EndingHour = new System.DateTime(2000, 01, 01, 16, 0, 0),
                StartingLimit = new System.DateTime(2022, 1, 1, 0, 0, 0),
                EndingLimit = new System.DateTime(2022, 12, 31, 0, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 06, 17, 10, 0, 0);
            //Act
            CalculateRecurring.Calculate(settings);
            //Assert
            settings.NextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_third_saturday()
        {
            //Arrange
            var settings = new Settings
            {
                CurrentDate = new System.DateTime(2022, 06, 09, 8, 10, 0),
                Occurs = 1,
                MonthlyFreq = 2, //Third
                DailyFreq = 5, //Saturday
                Monthly2Freq = 2, //Num Months
                The = true,
                OccursEveryFreq = 1,
                Freq = 0,
                StartingHour = new System.DateTime(2000, 01, 01, 10, 0, 0),
                EndingHour = new System.DateTime(2000, 01, 01, 16, 0, 0),
                StartingLimit = new System.DateTime(2022, 1, 1, 0, 0, 0),
                EndingLimit = new System.DateTime(2022, 12, 31, 0, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 06, 18, 10, 0, 0);
            //Act
            CalculateRecurring.Calculate(settings);
            //Assert
            settings.NextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_third_sunday()
        {
            //Arrange
            var settings = new Settings
            {
                CurrentDate = new System.DateTime(2022, 06, 09, 8, 10, 0),
                Occurs = 1,
                MonthlyFreq = 2, //Third
                DailyFreq = 6, //Sunday
                Monthly2Freq = 2, //Num Months
                The = true,
                OccursEveryFreq = 1,
                Freq = 0,
                StartingHour = new System.DateTime(2000, 01, 01, 10, 0, 0),
                EndingHour = new System.DateTime(2000, 01, 01, 16, 0, 0),
                StartingLimit = new System.DateTime(2022, 1, 1, 0, 0, 0),
                EndingLimit = new System.DateTime(2022, 12, 31, 0, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 06, 19, 10, 0, 0);
            //Act
            CalculateRecurring.Calculate(settings);
            //Assert
            settings.NextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_third_day()
        {
            //Arrange
            var settings = new Settings
            {
                CurrentDate = new System.DateTime(2022, 06, 09, 8, 10, 0),
                Occurs = 1,
                MonthlyFreq = 2, //Third
                DailyFreq = 7, //Day
                Monthly2Freq = 2, //Num Months
                The = true,
                OccursEveryFreq = 1,
                Freq = 0,
                StartingHour = new System.DateTime(2000, 01, 01, 10, 0, 0),
                EndingHour = new System.DateTime(2000, 01, 01, 16, 0, 0),
                StartingLimit = new System.DateTime(2022, 1, 1, 0, 0, 0),
                EndingLimit = new System.DateTime(2022, 12, 31, 0, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 08, 03, 10, 0, 0);
            //Act
            CalculateRecurring.Calculate(settings);
            //Assert
            settings.NextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_third_weekday()
        {
            //Arrange
            var settings = new Settings
            {
                CurrentDate = new System.DateTime(2022, 06, 09, 8, 10, 0),
                Occurs = 1,
                MonthlyFreq = 2, //Third
                DailyFreq = 8, //WeekDay
                Monthly2Freq = 2, //Num Months
                The = true,
                OccursEveryFreq = 1,
                Freq = 0,
                StartingHour = new System.DateTime(2000, 01, 01, 10, 0, 0),
                EndingHour = new System.DateTime(2000, 01, 01, 16, 0, 0),
                StartingLimit = new System.DateTime(2022, 1, 1, 0, 0, 0),
                EndingLimit = new System.DateTime(2022, 12, 31, 0, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 08, 03, 10, 0, 0);
            //Act
            CalculateRecurring.Calculate(settings);
            //Assert
            settings.NextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_third_weekend_day()
        {
            //Arrange
            var settings = new Settings
            {
                CurrentDate = new System.DateTime(2022, 06, 09, 8, 10, 0),
                Occurs = 1,
                MonthlyFreq = 2, //Third
                DailyFreq = 9, //WeekendDay
                Monthly2Freq = 2, //Num Months
                The = true,
                OccursEveryFreq = 1,
                Freq = 0,
                StartingHour = new System.DateTime(2000, 01, 01, 10, 0, 0),
                EndingHour = new System.DateTime(2000, 01, 01, 16, 0, 0),
                StartingLimit = new System.DateTime(2022, 1, 1, 0, 0, 0),
                EndingLimit = new System.DateTime(2022, 12, 31, 0, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 06, 11, 10, 0, 0);
            //Act
            CalculateRecurring.Calculate(settings);
            //Assert
            settings.NextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        //-------------------------------- FOURTH TESTS -----------------------------------//
        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_fourth_monday()
        {
            //Arrange
            var settings = new Settings
            {
                CurrentDate = new System.DateTime(2022, 06, 09, 8, 10, 0),
                Occurs = 1,
                MonthlyFreq = 3, //Fourth
                DailyFreq = 0, //Monday
                Monthly2Freq = 2, //Num Months
                The = true,
                OccursEveryFreq = 1,
                Freq = 0,
                StartingHour = new System.DateTime(2000, 01, 01, 10, 0, 0),
                EndingHour = new System.DateTime(2000, 01, 01, 16, 0, 0),
                StartingLimit = new System.DateTime(2022, 1, 1, 0, 0, 0),
                EndingLimit = new System.DateTime(2022, 12, 31, 0, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 06, 27, 10, 0, 0);
            //Act
            CalculateRecurring.Calculate(settings);
            //Assert
            settings.NextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_fourth_tuesday()
        {
            //Arrange
            var settings = new Settings
            {
                CurrentDate = new System.DateTime(2022, 06, 09, 8, 10, 0),
                Occurs = 1,
                MonthlyFreq = 3, //Fourth
                DailyFreq = 1, //Tuesday
                Monthly2Freq = 2, //Num Months
                The = true,
                OccursEveryFreq = 1,
                Freq = 0,
                StartingHour = new System.DateTime(2000, 01, 01, 10, 0, 0),
                EndingHour = new System.DateTime(2000, 01, 01, 16, 0, 0),
                StartingLimit = new System.DateTime(2022, 1, 1, 0, 0, 0),
                EndingLimit = new System.DateTime(2022, 12, 31, 0, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 06, 28, 10, 0, 0);
            //Act
            CalculateRecurring.Calculate(settings);
            //Assert
            settings.NextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_fourth_wednesday()
        {
            //Arrange
            var settings = new Settings
            {
                CurrentDate = new System.DateTime(2022, 06, 09, 8, 10, 0),
                Occurs = 1,
                MonthlyFreq = 3, //Fourth
                DailyFreq = 2, //Wednesday
                Monthly2Freq = 2, //Num Months
                The = true,
                OccursEveryFreq = 1,
                Freq = 0,
                StartingHour = new System.DateTime(2000, 01, 01, 10, 0, 0),
                EndingHour = new System.DateTime(2000, 01, 01, 16, 0, 0),
                StartingLimit = new System.DateTime(2022, 1, 1, 0, 0, 0),
                EndingLimit = new System.DateTime(2022, 12, 31, 0, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 06, 22, 10, 0, 0);
            //Act
            CalculateRecurring.Calculate(settings);
            //Assert
            settings.NextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_fourth_thursday()
        {
            //Arrange
            var settings = new Settings
            {
                CurrentDate = new System.DateTime(2022, 06, 09, 8, 10, 0),
                Occurs = 1,
                MonthlyFreq = 3, //Fourth
                DailyFreq = 3, //Thursday
                Monthly2Freq = 2, //Num Months
                The = true,
                OccursEveryFreq = 1,
                Freq = 0,
                StartingHour = new System.DateTime(2000, 01, 01, 10, 0, 0),
                EndingHour = new System.DateTime(2000, 01, 01, 16, 0, 0),
                StartingLimit = new System.DateTime(2022, 1, 1, 0, 0, 0),
                EndingLimit = new System.DateTime(2022, 12, 31, 0, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 06, 23, 10, 0, 0);
            //Act
            CalculateRecurring.Calculate(settings);
            //Assert
            settings.NextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_fourth_friday()
        {
            //Arrange
            var settings = new Settings
            {
                CurrentDate = new System.DateTime(2022, 06, 09, 8, 10, 0),
                Occurs = 1,
                MonthlyFreq = 3, //Fourth
                DailyFreq = 4, //Friday
                Monthly2Freq = 2, //Num Months
                The = true,
                OccursEveryFreq = 1,
                Freq = 0,
                StartingHour = new System.DateTime(2000, 01, 01, 10, 0, 0),
                EndingHour = new System.DateTime(2000, 01, 01, 16, 0, 0),
                StartingLimit = new System.DateTime(2022, 1, 1, 0, 0, 0),
                EndingLimit = new System.DateTime(2022, 12, 31, 0, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 06, 24, 10, 0, 0);
            //Act
            CalculateRecurring.Calculate(settings);
            //Assert
            settings.NextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_fourth_saturday()
        {
            //Arrange
            var settings = new Settings
            {
                CurrentDate = new System.DateTime(2022, 06, 09, 8, 10, 0),
                Occurs = 1,
                MonthlyFreq = 3, //Fourth
                DailyFreq = 5, //Saturday
                Monthly2Freq = 2, //Num Months
                The = true,
                OccursEveryFreq = 1,
                Freq = 0,
                StartingHour = new System.DateTime(2000, 01, 01, 10, 0, 0),
                EndingHour = new System.DateTime(2000, 01, 01, 16, 0, 0),
                StartingLimit = new System.DateTime(2022, 1, 1, 0, 0, 0),
                EndingLimit = new System.DateTime(2022, 12, 31, 0, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 06, 25, 10, 0, 0);
            //Act
            CalculateRecurring.Calculate(settings);
            //Assert
            settings.NextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_fourth_sunday()
        {
            //Arrange
            var settings = new Settings
            {
                CurrentDate = new System.DateTime(2022, 06, 09, 8, 10, 0),
                Occurs = 1,
                MonthlyFreq = 3, //Fourth
                DailyFreq = 6, //Sunday
                Monthly2Freq = 2, //Num Months
                The = true,
                OccursEveryFreq = 1,
                Freq = 0,
                StartingHour = new System.DateTime(2000, 01, 01, 10, 0, 0),
                EndingHour = new System.DateTime(2000, 01, 01, 16, 0, 0),
                StartingLimit = new System.DateTime(2022, 1, 1, 0, 0, 0),
                EndingLimit = new System.DateTime(2022, 12, 31, 0, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 06, 26, 10, 0, 0);
            //Act
            CalculateRecurring.Calculate(settings);
            //Assert
            settings.NextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_fourth_day()
        {
            //Arrange
            var settings = new Settings
            {
                CurrentDate = new System.DateTime(2022, 06, 09, 8, 10, 0),
                Occurs = 1,
                MonthlyFreq = 3, //Fourth
                DailyFreq = 7, //Day
                Monthly2Freq = 2, //Num Months
                The = true,
                OccursEveryFreq = 1,
                Freq = 0,
                StartingHour = new System.DateTime(2000, 01, 01, 10, 0, 0),
                EndingHour = new System.DateTime(2000, 01, 01, 16, 0, 0),
                StartingLimit = new System.DateTime(2022, 1, 1, 0, 0, 0),
                EndingLimit = new System.DateTime(2022, 12, 31, 0, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 08, 04, 10, 0, 0);
            //Act
            CalculateRecurring.Calculate(settings);
            //Assert
            settings.NextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_fourth_weekday()
        {
            //Arrange
            var settings = new Settings
            {
                CurrentDate = new System.DateTime(2022, 06, 09, 8, 10, 0),
                Occurs = 1,
                MonthlyFreq = 3, //Fourth
                DailyFreq = 8, //WeekDay
                Monthly2Freq = 2, //Num Months
                The = true,
                OccursEveryFreq = 1,
                Freq = 0,
                StartingHour = new System.DateTime(2000, 01, 01, 10, 0, 0),
                EndingHour = new System.DateTime(2000, 01, 01, 16, 0, 0),
                StartingLimit = new System.DateTime(2022, 1, 1, 0, 0, 0),
                EndingLimit = new System.DateTime(2022, 12, 31, 0, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 08, 04, 10, 0, 0);
            //Act
            CalculateRecurring.Calculate(settings);
            //Assert
            settings.NextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_fourth_weekend_day()
        {
            //Arrange
            var settings = new Settings
            {
                CurrentDate = new System.DateTime(2022, 06, 09, 8, 10, 0),
                Occurs = 1,
                MonthlyFreq = 3, //Fourth
                DailyFreq = 9, //WeekendDay
                Monthly2Freq = 2, //Num Months
                The = true,
                OccursEveryFreq = 1,
                Freq = 0,
                StartingHour = new System.DateTime(2000, 01, 01, 10, 0, 0),
                EndingHour = new System.DateTime(2000, 01, 01, 16, 0, 0),
                StartingLimit = new System.DateTime(2022, 1, 1, 0, 0, 0),
                EndingLimit = new System.DateTime(2022, 12, 31, 0, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 06, 12, 10, 0, 0);
            //Act
            CalculateRecurring.Calculate(settings);
            //Assert
            settings.NextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        //-------------------------------- LAST TESTS -----------------------------------//
        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_last_monday()
        {
            //Arrange
            var settings = new Settings
            {
                CurrentDate = new System.DateTime(2022, 06, 09, 8, 10, 0),
                Occurs = 1,
                MonthlyFreq = 4, //Last
                DailyFreq = 0, //Monday
                Monthly2Freq = 2, //Num Months
                The = true,
                OccursEveryFreq = 1,
                Freq = 0,
                StartingHour = new System.DateTime(2000, 01, 01, 10, 0, 0),
                EndingHour = new System.DateTime(2000, 01, 01, 16, 0, 0),
                StartingLimit = new System.DateTime(2022, 1, 1, 0, 0, 0),
                EndingLimit = new System.DateTime(2022, 12, 31, 0, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 06, 27, 10, 0, 0);
            //Act
            CalculateRecurring.Calculate(settings);
            //Assert
            settings.NextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_last_tuesday()
        {
            //Arrange
            var settings = new Settings
            {
                CurrentDate = new System.DateTime(2022, 06, 09, 8, 10, 0),
                Occurs = 1,
                MonthlyFreq = 4, //Last
                DailyFreq = 1, //Tuesday
                Monthly2Freq = 2, //Num Months
                The = true,
                OccursEveryFreq = 1,
                Freq = 0,
                StartingHour = new System.DateTime(2000, 01, 01, 10, 0, 0),
                EndingHour = new System.DateTime(2000, 01, 01, 16, 0, 0),
                StartingLimit = new System.DateTime(2022, 1, 1, 0, 0, 0),
                EndingLimit = new System.DateTime(2022, 12, 31, 0, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 06, 28, 10, 0, 0);
            //Act
            CalculateRecurring.Calculate(settings);
            //Assert
            settings.NextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_last_wednesday()
        {
            //Arrange
            var settings = new Settings
            {
                CurrentDate = new System.DateTime(2022, 06, 09, 8, 10, 0),
                Occurs = 1,
                MonthlyFreq = 4, //Last
                DailyFreq = 2, //Wednesday
                Monthly2Freq = 2, //Num Months
                The = true,
                OccursEveryFreq = 1,
                Freq = 0,
                StartingHour = new System.DateTime(2000, 01, 01, 10, 0, 0),
                EndingHour = new System.DateTime(2000, 01, 01, 16, 0, 0),
                StartingLimit = new System.DateTime(2022, 1, 1, 0, 0, 0),
                EndingLimit = new System.DateTime(2022, 12, 31, 0, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 06, 29, 10, 0, 0);
            //Act
            CalculateRecurring.Calculate(settings);
            //Assert
            settings.NextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_last_thursday()
        {
            //Arrange
            var settings = new Settings
            {
                CurrentDate = new System.DateTime(2022, 06, 09, 8, 10, 0),
                Occurs = 1,
                MonthlyFreq = 4, //Last
                DailyFreq = 3, //Thursday
                Monthly2Freq = 2, //Num Months
                The = true,
                OccursEveryFreq = 1,
                Freq = 0,
                StartingHour = new System.DateTime(2000, 01, 01, 10, 0, 0),
                EndingHour = new System.DateTime(2000, 01, 01, 16, 0, 0),
                StartingLimit = new System.DateTime(2022, 1, 1, 0, 0, 0),
                EndingLimit = new System.DateTime(2022, 12, 31, 0, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 06, 30, 10, 0, 0);
            //Act
            CalculateRecurring.Calculate(settings);
            //Assert
            settings.NextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_last_friday()
        {
            //Arrange
            var settings = new Settings
            {
                CurrentDate = new System.DateTime(2022, 06, 09, 8, 10, 0),
                Occurs = 1,
                MonthlyFreq = 4, //Last
                DailyFreq = 4, //Friday
                Monthly2Freq = 2, //Num Months
                The = true,
                OccursEveryFreq = 1,
                Freq = 0,
                StartingHour = new System.DateTime(2000, 01, 01, 10, 0, 0),
                EndingHour = new System.DateTime(2000, 01, 01, 16, 0, 0),
                StartingLimit = new System.DateTime(2022, 1, 1, 0, 0, 0),
                EndingLimit = new System.DateTime(2022, 12, 31, 0, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 06, 24, 10, 0, 0);
            //Act
            CalculateRecurring.Calculate(settings);
            //Assert
            settings.NextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_last_saturday()
        {
            //Arrange
            var settings = new Settings
            {
                CurrentDate = new System.DateTime(2022, 06, 09, 8, 10, 0),
                Occurs = 1,
                MonthlyFreq = 4, //Last
                DailyFreq = 5, //Saturday
                Monthly2Freq = 2, //Num Months
                The = true,
                OccursEveryFreq = 1,
                Freq = 0,
                StartingHour = new System.DateTime(2000, 01, 01, 10, 0, 0),
                EndingHour = new System.DateTime(2000, 01, 01, 16, 0, 0),
                StartingLimit = new System.DateTime(2022, 1, 1, 0, 0, 0),
                EndingLimit = new System.DateTime(2022, 12, 31, 0, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 06, 25, 10, 0, 0);
            //Act
            CalculateRecurring.Calculate(settings);
            //Assert
            settings.NextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_last_sunday()
        {
            //Arrange
            var settings = new Settings
            {
                CurrentDate = new System.DateTime(2022, 06, 09, 8, 10, 0),
                Occurs = 1,
                MonthlyFreq = 4, //Last
                DailyFreq = 6, //Sunday
                Monthly2Freq = 2, //Num Months
                The = true,
                OccursEveryFreq = 1,
                Freq = 0,
                StartingHour = new System.DateTime(2000, 01, 01, 10, 0, 0),
                EndingHour = new System.DateTime(2000, 01, 01, 16, 0, 0),
                StartingLimit = new System.DateTime(2022, 1, 1, 0, 0, 0),
                EndingLimit = new System.DateTime(2022, 12, 31, 0, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 06, 26, 10, 0, 0);
            //Act
            CalculateRecurring.Calculate(settings);
            //Assert
            settings.NextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_last_day()
        {
            //Arrange
            var settings = new Settings
            {
                CurrentDate = new System.DateTime(2022, 06, 09, 8, 10, 0),
                Occurs = 1,
                MonthlyFreq = 4, //Fourth
                DailyFreq = 7, //Day
                Monthly2Freq = 2, //Num Months
                The = true,
                OccursEveryFreq = 1,
                Freq = 0,
                StartingHour = new System.DateTime(2000, 01, 01, 10, 0, 0),
                EndingHour = new System.DateTime(2000, 01, 01, 16, 0, 0),
                StartingLimit = new System.DateTime(2022, 1, 1, 0, 0, 0),
                EndingLimit = new System.DateTime(2022, 12, 31, 0, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 06, 30, 10, 0, 0);
            //Act
            CalculateRecurring.Calculate(settings);
            //Assert
            settings.NextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_last_weekday()
        {
            //Arrange
            var settings = new Settings
            {
                CurrentDate = new System.DateTime(2022, 06, 09, 8, 10, 0),
                Occurs = 1,
                MonthlyFreq = 4, //Last
                DailyFreq = 8, //WeekDay
                Monthly2Freq = 2, //Num Months
                The = true,
                OccursEveryFreq = 1,
                Freq = 0,
                StartingHour = new System.DateTime(2000, 01, 01, 10, 0, 0),
                EndingHour = new System.DateTime(2000, 01, 01, 10, 0, 0),
                StartingLimit = new System.DateTime(2022, 1, 1, 0, 0, 0),
                EndingLimit = new System.DateTime(2022, 12, 31, 0, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 06, 30, 10, 0, 0);
            //Act
            CalculateRecurring.Calculate(settings);
            //Assert
            settings.NextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_last_weekend_day()
        {
            //Arrange
            var settings = new Settings
            {
                CurrentDate = new System.DateTime(2022, 06, 09, 8, 10, 0),
                Occurs = 1,
                MonthlyFreq = 4, //Last
                DailyFreq = 9, //WeekendDay
                Monthly2Freq = 2, //Num Months
                The = true,
                OccursEveryFreq = 1,
                Freq = 0,
                StartingHour = new System.DateTime(2000, 01, 01, 10, 0, 0),
                EndingHour = new System.DateTime(2000, 01, 01, 16, 0, 0),
                StartingLimit = new System.DateTime(2022, 1, 1, 0, 0, 0),
                EndingLimit = new System.DateTime(2022, 12, 31, 0, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 06, 26, 10, 0, 0);
            //Act
            CalculateRecurring.Calculate(settings);
            //Assert
            settings.NextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }
    }
}

