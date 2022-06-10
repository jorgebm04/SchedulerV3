using Xunit;
using FluentAssertions;

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
                currentDate = new System.DateTime(2022, 06, 09, 8, 10, 0),
                occurs = 1,
                monthlyFreq = 0, //First
                dailyFreq = 0, //Monday
                monthly2Freq = 2, //Num Months
                the = true,
                occursEvery = true,
                occursEveryFreq = 1,
                freq = 0,
                startingHour = new System.DateTime(2000, 01, 01, 10, 0, 0),
                endingHour = new System.DateTime(2000, 01, 01, 16, 0, 0),
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
        public void Validate_calculated_date_type_recurring_monthly_not_in_months()
        {
            //Arrange
            var settings = new Settings
            {
                currentDate = new System.DateTime(2022, 06, 09, 8, 10, 0),
                occurs = 1,
                monthlyFreq = 0, //First
                dailyFreq = 0, //Monday
                monthly2Freq = 4, //Num Months
                the = true,
                occursEvery = true,
                occursEveryFreq = 1,
                freq = 0,
                startingHour = new System.DateTime(2000, 01, 01, 10, 0, 0),
                endingHour = new System.DateTime(2000, 01, 01, 16, 0, 0),
                startingLimit = new System.DateTime(2022, 1, 1, 0, 0, 0),
                endingLimit = new System.DateTime(2022, 12, 31, 0, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 08, 01, 10, 0, 0);
            //Act
            CalculateRecurring.calculate(settings);
            //Assert
            settings.nextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }
        //-------------------------------- FIRST TESTS -----------------------------------//
        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_first_monday()
        {
            //Arrange
            var settings = new Settings
            {
                currentDate = new System.DateTime(2022, 06, 09, 8, 10, 0),
                occurs = 1,
                monthlyFreq = 0, //First
                dailyFreq = 0, //Monday
                monthly2Freq = 2, //Num Months
                the = true,
                occursEvery = true,
                occursEveryFreq = 1,
                freq = 0,
                startingHour = new System.DateTime(2000, 01, 01, 10, 0, 0),
                endingHour = new System.DateTime(2000, 01, 01, 16, 0, 0),
                startingLimit = new System.DateTime(2022, 1, 1, 0, 0, 0),
                endingLimit = new System.DateTime(2022, 12, 31, 0, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 08, 01, 10, 0, 0);
            //Act
            CalculateRecurring.calculate(settings);
            //Assert
            settings.nextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_first_tuesday()
        {
            //Arrange
            var settings = new Settings
            {
                currentDate = new System.DateTime(2022, 06, 09, 8, 10, 0),
                occurs = 1,
                monthlyFreq = 0, //First
                dailyFreq = 1, //Tuesday
                monthly2Freq = 2, //Num Months
                occursEvery = true,
                the = true,
                occursEveryFreq = 1,
                freq = 0,
                startingHour = new System.DateTime(2000, 01, 01, 10, 0, 0),
                endingHour = new System.DateTime(2000, 01, 01, 16, 0, 0),
                startingLimit = new System.DateTime(2022, 1, 1, 0, 0, 0),
                endingLimit = new System.DateTime(2022, 12, 31, 0, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 08, 02, 10, 0, 0);
            //Act
            CalculateRecurring.calculate(settings);
            //Assert
            settings.nextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_first_wednesday()
        {
            //Arrange
            var settings = new Settings
            {
                currentDate = new System.DateTime(2022, 06, 09, 8, 10, 0),
                occurs = 1,
                monthlyFreq = 0, //First
                dailyFreq = 2, //Wednesday
                monthly2Freq = 2, //Num Months
                the = true,
                occursEveryFreq = 1,
                freq = 0,
                startingHour = new System.DateTime(2000, 01, 01, 10, 0, 0),
                endingHour = new System.DateTime(2000, 01, 01, 16, 0, 0),
                startingLimit = new System.DateTime(2022, 1, 1, 0, 0, 0),
                endingLimit = new System.DateTime(2022, 12, 31, 0, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 08, 03, 10, 0, 0);
            //Act
            CalculateRecurring.calculate(settings);
            //Assert
            settings.nextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_first_thursday()
        {
            //Arrange
            var settings = new Settings
            {
                currentDate = new System.DateTime(2022, 06, 09, 8, 10, 0),
                occurs = 1,
                monthlyFreq = 0, //First
                dailyFreq = 3, //Thursday
                monthly2Freq = 2, //Num Months
                the = true,
                occursEveryFreq = 1,
                freq = 0,
                startingHour = new System.DateTime(2000, 01, 01, 10, 0, 0),
                endingHour = new System.DateTime(2000, 01, 01, 16, 0, 0),
                startingLimit = new System.DateTime(2022, 1, 1, 0, 0, 0),
                endingLimit = new System.DateTime(2022, 12, 31, 0, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 08, 04, 10, 0, 0);
            //Act
            CalculateRecurring.calculate(settings);
            //Assert
            settings.nextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_first_friday()
        {
            //Arrange
            var settings = new Settings
            {
                currentDate = new System.DateTime(2022, 06, 09, 8, 10, 0),
                occurs = 1,
                monthlyFreq = 0, //First
                dailyFreq = 4, //Friday
                monthly2Freq = 2, //Num Months
                the = true,
                occursEveryFreq = 1,
                freq = 0,
                startingHour = new System.DateTime(2000, 01, 01, 10, 0, 0),
                endingHour = new System.DateTime(2000, 01, 01, 16, 0, 0),
                startingLimit = new System.DateTime(2022, 1, 1, 0, 0, 0),
                endingLimit = new System.DateTime(2022, 12, 31, 0, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 08, 05, 10, 0, 0);
            //Act
            CalculateRecurring.calculate(settings);
            //Assert
            settings.nextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_first_saturday()
        {
            //Arrange
            var settings = new Settings
            {
                currentDate = new System.DateTime(2022, 06, 09, 8, 10, 0),
                occurs = 1,
                monthlyFreq = 0, //First
                dailyFreq = 5, //Saturday
                monthly2Freq = 2, //Num Months
                the = true,
                occursEveryFreq = 1,
                freq = 0,
                startingHour = new System.DateTime(2000, 01, 01, 10, 0, 0),
                endingHour = new System.DateTime(2000, 01, 01, 16, 0, 0),
                startingLimit = new System.DateTime(2022, 1, 1, 0, 0, 0),
                endingLimit = new System.DateTime(2022, 12, 31, 0, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 08, 06, 10, 0, 0);
            //Act
            CalculateRecurring.calculate(settings);
            //Assert
            settings.nextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_first_sunday()
        {
            //Arrange
            var settings = new Settings
            {
                currentDate = new System.DateTime(2022, 06, 09, 8, 10, 0),
                occurs = 1,
                monthlyFreq = 0, //First
                dailyFreq = 6, //Sunday
                monthly2Freq = 2, //Num Months
                the = true,
                occursEveryFreq = 1,
                freq = 0,
                startingHour = new System.DateTime(2000, 01, 01, 10, 0, 0),
                endingHour = new System.DateTime(2000, 01, 01, 16, 0, 0),
                startingLimit = new System.DateTime(2022, 1, 1, 0, 0, 0),
                endingLimit = new System.DateTime(2022, 12, 31, 0, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 08, 07, 10, 0, 0);
            //Act
            CalculateRecurring.calculate(settings);
            //Assert
            settings.nextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_first_day()
        {
            //Arrange
            var settings = new Settings
            {
                currentDate = new System.DateTime(2022, 06, 09, 8, 10, 0),
                occurs = 1,
                monthlyFreq = 0, //First
                dailyFreq = 7, //Day
                monthly2Freq = 2, //Num Months
                the = true,
                occursEveryFreq = 1,
                freq = 0,
                startingHour = new System.DateTime(2000, 01, 01, 10, 0, 0),
                endingHour = new System.DateTime(2000, 01, 01, 16, 0, 0),
                startingLimit = new System.DateTime(2022, 1, 1, 0, 0, 0),
                endingLimit = new System.DateTime(2022, 12, 31, 0, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 08, 01, 10, 0, 0);
            //Act
            CalculateRecurring.calculate(settings);
            //Assert
            settings.nextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_first_weekday()
        {
            //Arrange
            var settings = new Settings
            {
                currentDate = new System.DateTime(2022, 06, 09, 8, 10, 0),
                occurs = 1,
                monthlyFreq = 0, //First
                dailyFreq = 8, //WeekDay
                monthly2Freq = 2, //Num Months
                the = true,
                occursEveryFreq = 1,
                freq = 0,
                startingHour = new System.DateTime(2000, 01, 01, 10, 0, 0),
                endingHour = new System.DateTime(2000, 01, 01, 16, 0, 0),
                startingLimit = new System.DateTime(2022, 1, 1, 0, 0, 0),
                endingLimit = new System.DateTime(2022, 12, 31, 0, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 08, 01, 10, 0, 0);
            //Act
            CalculateRecurring.calculate(settings);
            //Assert
            settings.nextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_first_weekendday()
        {
            //Arrange
            var settings = new Settings
            {
                currentDate = new System.DateTime(2022, 06, 09, 8, 10, 0),
                occurs = 1,
                monthlyFreq = 0, //First
                dailyFreq = 9, //WeekendDay
                monthly2Freq = 2, //Num Months
                the = true,
                occursEveryFreq = 1,
                freq = 0,
                startingHour = new System.DateTime(2000, 01, 01, 10, 0, 0),
                endingHour = new System.DateTime(2000, 01, 01, 16, 0, 0),
                startingLimit = new System.DateTime(2022, 1, 1, 0, 0, 0),
                endingLimit = new System.DateTime(2022, 12, 31, 0, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 08, 06, 10, 0, 0);
            //Act
            CalculateRecurring.calculate(settings);
            //Assert
            settings.nextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        //-------------------------------- SECOND TESTS -----------------------------------//
        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_second_monday()
        {
            //Arrange
            var settings = new Settings
            {
                currentDate = new System.DateTime(2022, 06, 09, 8, 10, 0),
                occurs = 1,
                monthlyFreq = 1, //Second
                dailyFreq = 0, //Monday
                monthly2Freq = 2, //Num Months
                the = true,
                occursEveryFreq = 1,
                freq = 0,
                startingHour = new System.DateTime(2000, 01, 01, 10, 0, 0),
                endingHour = new System.DateTime(2000, 01, 01, 16, 0, 0),
                startingLimit = new System.DateTime(2022, 1, 1, 0, 0, 0),
                endingLimit = new System.DateTime(2022, 12, 31, 0, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 06, 13, 10, 0, 0);
            //Act
            CalculateRecurring.calculate(settings);
            //Assert
            settings.nextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_second_tuesday()
        {
            //Arrange
            var settings = new Settings
            {
                currentDate = new System.DateTime(2022, 06, 09, 8, 10, 0),
                occurs = 1,
                monthlyFreq = 1, //Second
                dailyFreq = 1, //Tuesday
                monthly2Freq = 2, //Num Months
                the = true,
                occursEveryFreq = 1,
                freq = 0,
                startingHour = new System.DateTime(2000, 01, 01, 10, 0, 0),
                endingHour = new System.DateTime(2000, 01, 01, 16, 0, 0),
                startingLimit = new System.DateTime(2022, 1, 1, 0, 0, 0),
                endingLimit = new System.DateTime(2022, 12, 31, 0, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 06, 14, 10, 0, 0);
            //Act
            CalculateRecurring.calculate(settings);
            //Assert
            settings.nextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_second_wednesday()
        {
            //Arrange
            var settings = new Settings
            {
                currentDate = new System.DateTime(2022, 06, 09, 8, 10, 0),
                occurs = 1,
                monthlyFreq = 1, //second
                dailyFreq = 2, //Wednesday
                monthly2Freq = 2, //Num Months
                the = true,
                occursEveryFreq = 1,
                freq = 0,
                startingHour = new System.DateTime(2000, 01, 01, 10, 0, 0),
                endingHour = new System.DateTime(2000, 01, 01, 16, 0, 0),
                startingLimit = new System.DateTime(2022, 1, 1, 0, 0, 0),
                endingLimit = new System.DateTime(2022, 12, 31, 0, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 08, 10, 10, 0, 0);
            //Act
            CalculateRecurring.calculate(settings);
            //Assert
            settings.nextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_second_thursday()
        {
            //Arrange
            var settings = new Settings
            {
                currentDate = new System.DateTime(2022, 06, 09, 8, 10, 0),
                occurs = 1,
                monthlyFreq = 1, //second
                dailyFreq = 3, //Thursday
                monthly2Freq = 2, //Num Months
                the = true,
                occursEveryFreq = 1,
                freq = 0,
                startingHour = new System.DateTime(2000, 01, 01, 10, 0, 0),
                endingHour = new System.DateTime(2000, 01, 01, 16, 0, 0),
                startingLimit = new System.DateTime(2022, 1, 1, 0, 0, 0),
                endingLimit = new System.DateTime(2022, 12, 31, 0, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 06, 09, 10, 0, 0);
            //Act
            CalculateRecurring.calculate(settings);
            //Assert
            settings.nextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
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
                currentDate = new System.DateTime(2022, 06, 09, 8, 10, 0),
                occurs = 1,
                monthlyFreq = 1, //second
                dailyFreq = 3, //Thursday
                monthly2Freq = 2, //Num Months
                the = true,
                occursEveryFreq = 1,
                freq = 0,
                startingHour = new System.DateTime(2000, 01, 01, 8, 0, 0),
                endingHour = new System.DateTime(2000, 01, 01, 16, 0, 0),
                startingLimit = new System.DateTime(2022, 1, 1, 0, 0, 0),
                endingLimit = new System.DateTime(2022, 12, 31, 0, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 06, 9, 9, 0, 0);
            //Act
            CalculateRecurring.calculate(settings);
            //Assert
            settings.nextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_second_thursday_over_time_in_hours()
        {
            //Arrange
            var settings = new Settings
            {
                currentDate = new System.DateTime(2022, 06, 09, 8, 10, 0),
                occurs = 1,
                monthlyFreq = 1, //second
                dailyFreq = 3, //Thursday
                monthly2Freq = 2, //Num Months
                the = true,
                occursEveryFreq = 1,
                freq = 0,
                startingHour = new System.DateTime(2000, 01, 01, 8, 0, 0),
                endingHour = new System.DateTime(2000, 01, 01, 8, 30, 0),
                startingLimit = new System.DateTime(2022, 1, 1, 0, 0, 0),
                endingLimit = new System.DateTime(2022, 12, 31, 0, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 06, 9, 8, 30, 0);
            //Act
            CalculateRecurring.calculate(settings);
            //Assert
            settings.nextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_second_thursday_over_time_over_hours()
        {
            //Arrange
            var settings = new Settings
            {
                currentDate = new System.DateTime(2022, 06, 09, 8, 10, 0),
                occurs = 1,
                monthlyFreq = 1, //second
                dailyFreq = 3, //Thursday
                monthly2Freq = 2, //Num Months
                the = true,
                occursEveryFreq = 1,
                freq = 0,
                startingHour = new System.DateTime(2000, 01, 01, 8, 0, 0),
                endingHour = new System.DateTime(2000, 01, 01, 8, 5, 0),
                startingLimit = new System.DateTime(2022, 1, 1, 0, 0, 0),
                endingLimit = new System.DateTime(2022, 12, 31, 0, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 08, 11, 8, 0, 0);
            //Act
            CalculateRecurring.calculate(settings);
            //Assert
            settings.nextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_second_friday()
        {
            //Arrange
            var settings = new Settings
            {
                currentDate = new System.DateTime(2022, 06, 09, 8, 10, 0),
                occurs = 1,
                monthlyFreq = 1, //second
                dailyFreq = 4, //Friday
                monthly2Freq = 2, //Num Months
                the = true,
                occursEveryFreq = 1,
                freq = 0,
                startingHour = new System.DateTime(2000, 01, 01, 10, 0, 0),
                endingHour = new System.DateTime(2000, 01, 01, 16, 0, 0),
                startingLimit = new System.DateTime(2022, 1, 1, 0, 0, 0),
                endingLimit = new System.DateTime(2022, 12, 31, 0, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 06, 10, 10, 0, 0);
            //Act
            CalculateRecurring.calculate(settings);
            //Assert
            settings.nextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_second_saturday()
        {
            //Arrange
            var settings = new Settings
            {
                currentDate = new System.DateTime(2022, 06, 09, 8, 10, 0),
                occurs = 1,
                monthlyFreq = 1, //second
                dailyFreq = 5, //Saturday
                monthly2Freq = 2, //Num Months
                the = true,
                occursEveryFreq = 1,
                freq = 0,
                startingHour = new System.DateTime(2000, 01, 01, 10, 0, 0),
                endingHour = new System.DateTime(2000, 01, 01, 16, 0, 0),
                startingLimit = new System.DateTime(2022, 1, 1, 0, 0, 0),
                endingLimit = new System.DateTime(2022, 12, 31, 0, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 06, 11, 10, 0, 0);
            //Act
            CalculateRecurring.calculate(settings);
            //Assert
            settings.nextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_second_sunday()
        {
            //Arrange
            var settings = new Settings
            {
                currentDate = new System.DateTime(2022, 06, 09, 8, 10, 0),
                occurs = 1,
                monthlyFreq = 1, //second
                dailyFreq = 6, //Sunday
                monthly2Freq = 2, //Num Months
                the = true,
                occursEveryFreq = 1,
                freq = 0,
                startingHour = new System.DateTime(2000, 01, 01, 10, 0, 0),
                endingHour = new System.DateTime(2000, 01, 01, 16, 0, 0),
                startingLimit = new System.DateTime(2022, 1, 1, 0, 0, 0),
                endingLimit = new System.DateTime(2022, 12, 31, 0, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 06, 12, 10, 0, 0);
            //Act
            CalculateRecurring.calculate(settings);
            //Assert
            settings.nextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_second_day()
        {
            //Arrange
            var settings = new Settings
            {
                currentDate = new System.DateTime(2022, 06, 09, 8, 10, 0),
                occurs = 1,
                monthlyFreq = 1, //second
                dailyFreq = 7, //Day
                monthly2Freq = 2, //Num Months
                the = true,
                occursEveryFreq = 1,
                freq = 0,
                startingHour = new System.DateTime(2000, 01, 01, 10, 0, 0),
                endingHour = new System.DateTime(2000, 01, 01, 16, 0, 0),
                startingLimit = new System.DateTime(2022, 1, 1, 0, 0, 0),
                endingLimit = new System.DateTime(2022, 12, 31, 0, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 08, 02, 10, 0, 0);
            //Act
            CalculateRecurring.calculate(settings);
            //Assert
            settings.nextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_second_weekday()
        {
            //Arrange
            var settings = new Settings
            {
                currentDate = new System.DateTime(2022, 06, 09, 8, 10, 0),
                occurs = 1,
                monthlyFreq = 1, //second
                dailyFreq = 8, //WeekDay
                monthly2Freq = 2, //Num Months
                the = true,
                occursEveryFreq = 1,
                freq = 0,
                startingHour = new System.DateTime(2000, 01, 01, 10, 0, 0),
                endingHour = new System.DateTime(2000, 01, 01, 16, 0, 0),
                startingLimit = new System.DateTime(2022, 1, 1, 0, 0, 0),
                endingLimit = new System.DateTime(2022, 12, 31, 0, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 08, 02, 10, 0, 0);
            //Act
            CalculateRecurring.calculate(settings);
            //Assert
            settings.nextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_second_weekendday()
        {
            //Arrange
            var settings = new Settings
            {
                currentDate = new System.DateTime(2022, 06, 09, 8, 10, 0),
                occurs = 1,
                monthlyFreq = 1, //second
                dailyFreq = 9, //WeekendDay
                monthly2Freq = 2, //Num Months
                the = true,
                occursEveryFreq = 1,
                freq = 0,
                startingHour = new System.DateTime(2000, 01, 01, 10, 0, 0),
                endingHour = new System.DateTime(2000, 01, 01, 16, 0, 0),
                startingLimit = new System.DateTime(2022, 1, 1, 0, 0, 0),
                endingLimit = new System.DateTime(2022, 12, 31, 0, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 08, 07, 10, 0, 0);
            //Act
            CalculateRecurring.calculate(settings);
            //Assert
            settings.nextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        //-------------------------------- THIRD TESTS -----------------------------------//
        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_third_monday()
        {
            //Arrange
            var settings = new Settings
            {
                currentDate = new System.DateTime(2022, 06, 09, 8, 10, 0),
                occurs = 1,
                monthlyFreq = 2, //Third
                dailyFreq = 0, //Monday
                monthly2Freq = 2, //Num Months
                the = true,
                occursEveryFreq = 1,
                freq = 0,
                startingHour = new System.DateTime(2000, 01, 01, 10, 0, 0),
                endingHour = new System.DateTime(2000, 01, 01, 16, 0, 0),
                startingLimit = new System.DateTime(2022, 1, 1, 0, 0, 0),
                endingLimit = new System.DateTime(2022, 12, 31, 0, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 06, 20, 10, 0, 0);
            //Act
            CalculateRecurring.calculate(settings);
            //Assert
            settings.nextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_third_tuesday()
        {
            //Arrange
            var settings = new Settings
            {
                currentDate = new System.DateTime(2022, 06, 09, 8, 10, 0),
                occurs = 1,
                monthlyFreq = 2, //Third
                dailyFreq = 1, //Tuesday
                monthly2Freq = 2, //Num Months
                the = true,
                occursEveryFreq = 1,
                freq = 0,
                startingHour = new System.DateTime(2000, 01, 01, 10, 0, 0),
                endingHour = new System.DateTime(2000, 01, 01, 16, 0, 0),
                startingLimit = new System.DateTime(2022, 1, 1, 0, 0, 0),
                endingLimit = new System.DateTime(2022, 12, 31, 0, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 06, 21, 10, 0, 0);
            //Act
            CalculateRecurring.calculate(settings);
            //Assert
            settings.nextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_third_wednesday()
        {
            //Arrange
            var settings = new Settings
            {
                currentDate = new System.DateTime(2022, 06, 09, 8, 10, 0),
                occurs = 1,
                monthlyFreq = 2, //Third
                dailyFreq = 2, //Wednesday
                monthly2Freq = 2, //Num Months
                the = true,
                occursEveryFreq = 1,
                freq = 0,
                startingHour = new System.DateTime(2000, 01, 01, 10, 0, 0),
                endingHour = new System.DateTime(2000, 01, 01, 16, 0, 0),
                startingLimit = new System.DateTime(2022, 1, 1, 0, 0, 0),
                endingLimit = new System.DateTime(2022, 12, 31, 0, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 06, 15, 10, 0, 0);
            //Act
            CalculateRecurring.calculate(settings);
            //Assert
            settings.nextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_third_thursday()
        {
            //Arrange
            var settings = new Settings
            {
                currentDate = new System.DateTime(2022, 06, 09, 8, 10, 0),
                occurs = 1,
                monthlyFreq = 2, //Third
                dailyFreq = 3, //Thursday
                monthly2Freq = 2, //Num Months
                the = true,
                occursEveryFreq = 1,
                freq = 0,
                startingHour = new System.DateTime(2000, 01, 01, 10, 0, 0),
                endingHour = new System.DateTime(2000, 01, 01, 16, 0, 0),
                startingLimit = new System.DateTime(2022, 1, 1, 0, 0, 0),
                endingLimit = new System.DateTime(2022, 12, 31, 0, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 06, 16, 10, 0, 0);
            //Act
            CalculateRecurring.calculate(settings);
            //Assert
            settings.nextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_third_friday()
        {
            //Arrange
            var settings = new Settings
            {
                currentDate = new System.DateTime(2022, 06, 09, 8, 10, 0),
                occurs = 1,
                monthlyFreq = 2, //Third
                dailyFreq = 4, //Friday
                monthly2Freq = 2, //Num Months
                the = true,
                occursEveryFreq = 1,
                freq = 0,
                startingHour = new System.DateTime(2000, 01, 01, 10, 0, 0),
                endingHour = new System.DateTime(2000, 01, 01, 16, 0, 0),
                startingLimit = new System.DateTime(2022, 1, 1, 0, 0, 0),
                endingLimit = new System.DateTime(2022, 12, 31, 0, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 06, 17, 10, 0, 0);
            //Act
            CalculateRecurring.calculate(settings);
            //Assert
            settings.nextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_third_saturday()
        {
            //Arrange
            var settings = new Settings
            {
                currentDate = new System.DateTime(2022, 06, 09, 8, 10, 0),
                occurs = 1,
                monthlyFreq = 2, //Third
                dailyFreq = 5, //Saturday
                monthly2Freq = 2, //Num Months
                the = true,
                occursEveryFreq = 1,
                freq = 0,
                startingHour = new System.DateTime(2000, 01, 01, 10, 0, 0),
                endingHour = new System.DateTime(2000, 01, 01, 16, 0, 0),
                startingLimit = new System.DateTime(2022, 1, 1, 0, 0, 0),
                endingLimit = new System.DateTime(2022, 12, 31, 0, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 06, 18, 10, 0, 0);
            //Act
            CalculateRecurring.calculate(settings);
            //Assert
            settings.nextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_third_sunday()
        {
            //Arrange
            var settings = new Settings
            {
                currentDate = new System.DateTime(2022, 06, 09, 8, 10, 0),
                occurs = 1,
                monthlyFreq = 2, //Third
                dailyFreq = 6, //Sunday
                monthly2Freq = 2, //Num Months
                the = true,
                occursEveryFreq = 1,
                freq = 0,
                startingHour = new System.DateTime(2000, 01, 01, 10, 0, 0),
                endingHour = new System.DateTime(2000, 01, 01, 16, 0, 0),
                startingLimit = new System.DateTime(2022, 1, 1, 0, 0, 0),
                endingLimit = new System.DateTime(2022, 12, 31, 0, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 06, 19, 10, 0, 0);
            //Act
            CalculateRecurring.calculate(settings);
            //Assert
            settings.nextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_third_day()
        {
            //Arrange
            var settings = new Settings
            {
                currentDate = new System.DateTime(2022, 06, 09, 8, 10, 0),
                occurs = 1,
                monthlyFreq = 2, //Third
                dailyFreq = 7, //Day
                monthly2Freq = 2, //Num Months
                the = true,
                occursEveryFreq = 1,
                freq = 0,
                startingHour = new System.DateTime(2000, 01, 01, 10, 0, 0),
                endingHour = new System.DateTime(2000, 01, 01, 16, 0, 0),
                startingLimit = new System.DateTime(2022, 1, 1, 0, 0, 0),
                endingLimit = new System.DateTime(2022, 12, 31, 0, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 08, 03, 10, 0, 0);
            //Act
            CalculateRecurring.calculate(settings);
            //Assert
            settings.nextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_third_weekday()
        {
            //Arrange
            var settings = new Settings
            {
                currentDate = new System.DateTime(2022, 06, 09, 8, 10, 0),
                occurs = 1,
                monthlyFreq = 2, //Third
                dailyFreq = 8, //WeekDay
                monthly2Freq = 2, //Num Months
                the = true,
                occursEveryFreq = 1,
                freq = 0,
                startingHour = new System.DateTime(2000, 01, 01, 10, 0, 0),
                endingHour = new System.DateTime(2000, 01, 01, 16, 0, 0),
                startingLimit = new System.DateTime(2022, 1, 1, 0, 0, 0),
                endingLimit = new System.DateTime(2022, 12, 31, 0, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 08, 03, 10, 0, 0);
            //Act
            CalculateRecurring.calculate(settings);
            //Assert
            settings.nextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_third_weekendday()
        {
            //Arrange
            var settings = new Settings
            {
                currentDate = new System.DateTime(2022, 06, 09, 8, 10, 0),
                occurs = 1,
                monthlyFreq = 2, //Third
                dailyFreq = 9, //WeekendDay
                monthly2Freq = 2, //Num Months
                the = true,
                occursEveryFreq = 1,
                freq = 0,
                startingHour = new System.DateTime(2000, 01, 01, 10, 0, 0),
                endingHour = new System.DateTime(2000, 01, 01, 16, 0, 0),
                startingLimit = new System.DateTime(2022, 1, 1, 0, 0, 0),
                endingLimit = new System.DateTime(2022, 12, 31, 0, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 06, 11, 10, 0, 0);
            //Act
            CalculateRecurring.calculate(settings);
            //Assert
            settings.nextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        //-------------------------------- FOURTH TESTS -----------------------------------//
        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_fourth_monday()
        {
            //Arrange
            var settings = new Settings
            {
                currentDate = new System.DateTime(2022, 06, 09, 8, 10, 0),
                occurs = 1,
                monthlyFreq = 3, //Fourth
                dailyFreq = 0, //Monday
                monthly2Freq = 2, //Num Months
                the = true,
                occursEveryFreq = 1,
                freq = 0,
                startingHour = new System.DateTime(2000, 01, 01, 10, 0, 0),
                endingHour = new System.DateTime(2000, 01, 01, 16, 0, 0),
                startingLimit = new System.DateTime(2022, 1, 1, 0, 0, 0),
                endingLimit = new System.DateTime(2022, 12, 31, 0, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 06, 27, 10, 0, 0);
            //Act
            CalculateRecurring.calculate(settings);
            //Assert
            settings.nextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_fourth_tuesday()
        {
            //Arrange
            var settings = new Settings
            {
                currentDate = new System.DateTime(2022, 06, 09, 8, 10, 0),
                occurs = 1,
                monthlyFreq = 3, //Fourth
                dailyFreq = 1, //Tuesday
                monthly2Freq = 2, //Num Months
                the = true,
                occursEveryFreq = 1,
                freq = 0,
                startingHour = new System.DateTime(2000, 01, 01, 10, 0, 0),
                endingHour = new System.DateTime(2000, 01, 01, 16, 0, 0),
                startingLimit = new System.DateTime(2022, 1, 1, 0, 0, 0),
                endingLimit = new System.DateTime(2022, 12, 31, 0, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 06, 28, 10, 0, 0);
            //Act
            CalculateRecurring.calculate(settings);
            //Assert
            settings.nextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_fourth_wednesday()
        {
            //Arrange
            var settings = new Settings
            {
                currentDate = new System.DateTime(2022, 06, 09, 8, 10, 0),
                occurs = 1,
                monthlyFreq = 3, //Fourth
                dailyFreq = 2, //Wednesday
                monthly2Freq = 2, //Num Months
                the = true,
                occursEveryFreq = 1,
                freq = 0,
                startingHour = new System.DateTime(2000, 01, 01, 10, 0, 0),
                endingHour = new System.DateTime(2000, 01, 01, 16, 0, 0),
                startingLimit = new System.DateTime(2022, 1, 1, 0, 0, 0),
                endingLimit = new System.DateTime(2022, 12, 31, 0, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 06, 22, 10, 0, 0);
            //Act
            CalculateRecurring.calculate(settings);
            //Assert
            settings.nextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_fourth_thursday()
        {
            //Arrange
            var settings = new Settings
            {
                currentDate = new System.DateTime(2022, 06, 09, 8, 10, 0),
                occurs = 1,
                monthlyFreq = 3, //Fourth
                dailyFreq = 3, //Thursday
                monthly2Freq = 2, //Num Months
                the = true,
                occursEveryFreq = 1,
                freq = 0,
                startingHour = new System.DateTime(2000, 01, 01, 10, 0, 0),
                endingHour = new System.DateTime(2000, 01, 01, 16, 0, 0),
                startingLimit = new System.DateTime(2022, 1, 1, 0, 0, 0),
                endingLimit = new System.DateTime(2022, 12, 31, 0, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 06, 23, 10, 0, 0);
            //Act
            CalculateRecurring.calculate(settings);
            //Assert
            settings.nextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_fourth_friday()
        {
            //Arrange
            var settings = new Settings
            {
                currentDate = new System.DateTime(2022, 06, 09, 8, 10, 0),
                occurs = 1,
                monthlyFreq = 3, //Fourth
                dailyFreq = 4, //Friday
                monthly2Freq = 2, //Num Months
                the = true,
                occursEveryFreq = 1,
                freq = 0,
                startingHour = new System.DateTime(2000, 01, 01, 10, 0, 0),
                endingHour = new System.DateTime(2000, 01, 01, 16, 0, 0),
                startingLimit = new System.DateTime(2022, 1, 1, 0, 0, 0),
                endingLimit = new System.DateTime(2022, 12, 31, 0, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 06, 24, 10, 0, 0);
            //Act
            CalculateRecurring.calculate(settings);
            //Assert
            settings.nextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_fourth_saturday()
        {
            //Arrange
            var settings = new Settings
            {
                currentDate = new System.DateTime(2022, 06, 09, 8, 10, 0),
                occurs = 1,
                monthlyFreq = 3, //Fourth
                dailyFreq = 5, //Saturday
                monthly2Freq = 2, //Num Months
                the = true,
                occursEveryFreq = 1,
                freq = 0,
                startingHour = new System.DateTime(2000, 01, 01, 10, 0, 0),
                endingHour = new System.DateTime(2000, 01, 01, 16, 0, 0),
                startingLimit = new System.DateTime(2022, 1, 1, 0, 0, 0),
                endingLimit = new System.DateTime(2022, 12, 31, 0, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 06, 25, 10, 0, 0);
            //Act
            CalculateRecurring.calculate(settings);
            //Assert
            settings.nextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_fourth_sunday()
        {
            //Arrange
            var settings = new Settings
            {
                currentDate = new System.DateTime(2022, 06, 09, 8, 10, 0),
                occurs = 1,
                monthlyFreq = 3, //Fourth
                dailyFreq = 6, //Sunday
                monthly2Freq = 2, //Num Months
                the = true,
                occursEveryFreq = 1,
                freq = 0,
                startingHour = new System.DateTime(2000, 01, 01, 10, 0, 0),
                endingHour = new System.DateTime(2000, 01, 01, 16, 0, 0),
                startingLimit = new System.DateTime(2022, 1, 1, 0, 0, 0),
                endingLimit = new System.DateTime(2022, 12, 31, 0, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 06, 26, 10, 0, 0);
            //Act
            CalculateRecurring.calculate(settings);
            //Assert
            settings.nextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_fourth_day()
        {
            //Arrange
            var settings = new Settings
            {
                currentDate = new System.DateTime(2022, 06, 09, 8, 10, 0),
                occurs = 1,
                monthlyFreq = 3, //Fourth
                dailyFreq = 7, //Day
                monthly2Freq = 2, //Num Months
                the = true,
                occursEveryFreq = 1,
                freq = 0,
                startingHour = new System.DateTime(2000, 01, 01, 10, 0, 0),
                endingHour = new System.DateTime(2000, 01, 01, 16, 0, 0),
                startingLimit = new System.DateTime(2022, 1, 1, 0, 0, 0),
                endingLimit = new System.DateTime(2022, 12, 31, 0, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 08, 04, 10, 0, 0);
            //Act
            CalculateRecurring.calculate(settings);
            //Assert
            settings.nextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_fourth_weekday()
        {
            //Arrange
            var settings = new Settings
            {
                currentDate = new System.DateTime(2022, 06, 09, 8, 10, 0),
                occurs = 1,
                monthlyFreq = 3, //Fourth
                dailyFreq = 8, //WeekDay
                monthly2Freq = 2, //Num Months
                the = true,
                occursEveryFreq = 1,
                freq = 0,
                startingHour = new System.DateTime(2000, 01, 01, 10, 0, 0),
                endingHour = new System.DateTime(2000, 01, 01, 16, 0, 0),
                startingLimit = new System.DateTime(2022, 1, 1, 0, 0, 0),
                endingLimit = new System.DateTime(2022, 12, 31, 0, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 08, 04, 10, 0, 0);
            //Act
            CalculateRecurring.calculate(settings);
            //Assert
            settings.nextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_fourth_weekendday()
        {
            //Arrange
            var settings = new Settings
            {
                currentDate = new System.DateTime(2022, 06, 09, 8, 10, 0),
                occurs = 1,
                monthlyFreq = 3, //Fourth
                dailyFreq = 9, //WeekendDay
                monthly2Freq = 2, //Num Months
                the = true,
                occursEveryFreq = 1,
                freq = 0,
                startingHour = new System.DateTime(2000, 01, 01, 10, 0, 0),
                endingHour = new System.DateTime(2000, 01, 01, 16, 0, 0),
                startingLimit = new System.DateTime(2022, 1, 1, 0, 0, 0),
                endingLimit = new System.DateTime(2022, 12, 31, 0, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 06, 12, 10, 0, 0);
            //Act
            CalculateRecurring.calculate(settings);
            //Assert
            settings.nextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        //-------------------------------- LAST TESTS -----------------------------------//
        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_last_monday()
        {
            //Arrange
            var settings = new Settings
            {
                currentDate = new System.DateTime(2022, 06, 09, 8, 10, 0),
                occurs = 1,
                monthlyFreq = 4, //Last
                dailyFreq = 0, //Monday
                monthly2Freq = 2, //Num Months
                the = true,
                occursEveryFreq = 1,
                freq = 0,
                startingHour = new System.DateTime(2000, 01, 01, 10, 0, 0),
                endingHour = new System.DateTime(2000, 01, 01, 16, 0, 0),
                startingLimit = new System.DateTime(2022, 1, 1, 0, 0, 0),
                endingLimit = new System.DateTime(2022, 12, 31, 0, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 06, 27, 10, 0, 0);
            //Act
            CalculateRecurring.calculate(settings);
            //Assert
            settings.nextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_last_tuesday()
        {
            //Arrange
            var settings = new Settings
            {
                currentDate = new System.DateTime(2022, 06, 09, 8, 10, 0),
                occurs = 1,
                monthlyFreq = 4, //Last
                dailyFreq = 1, //Tuesday
                monthly2Freq = 2, //Num Months
                the = true,
                occursEveryFreq = 1,
                freq = 0,
                startingHour = new System.DateTime(2000, 01, 01, 10, 0, 0),
                endingHour = new System.DateTime(2000, 01, 01, 16, 0, 0),
                startingLimit = new System.DateTime(2022, 1, 1, 0, 0, 0),
                endingLimit = new System.DateTime(2022, 12, 31, 0, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 06, 28, 10, 0, 0);
            //Act
            CalculateRecurring.calculate(settings);
            //Assert
            settings.nextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_last_wednesday()
        {
            //Arrange
            var settings = new Settings
            {
                currentDate = new System.DateTime(2022, 06, 09, 8, 10, 0),
                occurs = 1,
                monthlyFreq = 4, //Last
                dailyFreq = 2, //Wednesday
                monthly2Freq = 2, //Num Months
                the = true,
                occursEveryFreq = 1,
                freq = 0,
                startingHour = new System.DateTime(2000, 01, 01, 10, 0, 0),
                endingHour = new System.DateTime(2000, 01, 01, 16, 0, 0),
                startingLimit = new System.DateTime(2022, 1, 1, 0, 0, 0),
                endingLimit = new System.DateTime(2022, 12, 31, 0, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 06, 29, 10, 0, 0);
            //Act
            CalculateRecurring.calculate(settings);
            //Assert
            settings.nextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_last_thursday()
        {
            //Arrange
            var settings = new Settings
            {
                currentDate = new System.DateTime(2022, 06, 09, 8, 10, 0),
                occurs = 1,
                monthlyFreq = 4, //Last
                dailyFreq = 3, //Thursday
                monthly2Freq = 2, //Num Months
                the = true,
                occursEveryFreq = 1,
                freq = 0,
                startingHour = new System.DateTime(2000, 01, 01, 10, 0, 0),
                endingHour = new System.DateTime(2000, 01, 01, 16, 0, 0),
                startingLimit = new System.DateTime(2022, 1, 1, 0, 0, 0),
                endingLimit = new System.DateTime(2022, 12, 31, 0, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 06, 30, 10, 0, 0);
            //Act
            CalculateRecurring.calculate(settings);
            //Assert
            settings.nextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_last_friday()
        {
            //Arrange
            var settings = new Settings
            {
                currentDate = new System.DateTime(2022, 06, 09, 8, 10, 0),
                occurs = 1,
                monthlyFreq = 4, //Last
                dailyFreq = 4, //Friday
                monthly2Freq = 2, //Num Months
                the = true,
                occursEveryFreq = 1,
                freq = 0,
                startingHour = new System.DateTime(2000, 01, 01, 10, 0, 0),
                endingHour = new System.DateTime(2000, 01, 01, 16, 0, 0),
                startingLimit = new System.DateTime(2022, 1, 1, 0, 0, 0),
                endingLimit = new System.DateTime(2022, 12, 31, 0, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 06, 24, 10, 0, 0);
            //Act
            CalculateRecurring.calculate(settings);
            //Assert
            settings.nextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_last_saturday()
        {
            //Arrange
            var settings = new Settings
            {
                currentDate = new System.DateTime(2022, 06, 09, 8, 10, 0),
                occurs = 1,
                monthlyFreq = 4, //Last
                dailyFreq = 5, //Saturday
                monthly2Freq = 2, //Num Months
                the = true,
                occursEveryFreq = 1,
                freq = 0,
                startingHour = new System.DateTime(2000, 01, 01, 10, 0, 0),
                endingHour = new System.DateTime(2000, 01, 01, 16, 0, 0),
                startingLimit = new System.DateTime(2022, 1, 1, 0, 0, 0),
                endingLimit = new System.DateTime(2022, 12, 31, 0, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 06, 25, 10, 0, 0);
            //Act
            CalculateRecurring.calculate(settings);
            //Assert
            settings.nextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_last_sunday()
        {
            //Arrange
            var settings = new Settings
            {
                currentDate = new System.DateTime(2022, 06, 09, 8, 10, 0),
                occurs = 1,
                monthlyFreq = 4, //Last
                dailyFreq = 6, //Sunday
                monthly2Freq = 2, //Num Months
                the = true,
                occursEveryFreq = 1,
                freq = 0,
                startingHour = new System.DateTime(2000, 01, 01, 10, 0, 0),
                endingHour = new System.DateTime(2000, 01, 01, 16, 0, 0),
                startingLimit = new System.DateTime(2022, 1, 1, 0, 0, 0),
                endingLimit = new System.DateTime(2022, 12, 31, 0, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 06, 26, 10, 0, 0);
            //Act
            CalculateRecurring.calculate(settings);
            //Assert
            settings.nextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_last_day()
        {
            //Arrange
            var settings = new Settings
            {
                currentDate = new System.DateTime(2022, 06, 09, 8, 10, 0),
                occurs = 1,
                monthlyFreq = 4, //Fourth
                dailyFreq = 7, //Day
                monthly2Freq = 2, //Num Months
                the = true,
                occursEveryFreq = 1,
                freq = 0,
                startingHour = new System.DateTime(2000, 01, 01, 10, 0, 0),
                endingHour = new System.DateTime(2000, 01, 01, 16, 0, 0),
                startingLimit = new System.DateTime(2022, 1, 1, 0, 0, 0),
                endingLimit = new System.DateTime(2022, 12, 31, 0, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 06, 30, 10, 0, 0);
            //Act
            CalculateRecurring.calculate(settings);
            //Assert
            settings.nextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_last_weekday()
        {
            //Arrange
            var settings = new Settings
            {
                currentDate = new System.DateTime(2022, 06, 09, 8, 10, 0),
                occurs = 1,
                monthlyFreq = 4, //Last
                dailyFreq = 8, //WeekDay
                monthly2Freq = 2, //Num Months
                the = true,
                occursEveryFreq = 1,
                freq = 0,
                startingHour = new System.DateTime(2000, 01, 01, 10, 0, 0),
                endingHour = new System.DateTime(2000, 01, 01, 10, 0, 0),
                startingLimit = new System.DateTime(2022, 1, 1, 0, 0, 0),
                endingLimit = new System.DateTime(2022, 12, 31, 0, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 06, 30, 10, 0, 0);
            //Act
            CalculateRecurring.calculate(settings);
            //Assert
            settings.nextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_monthly_last_weekendday()
        {
            //Arrange
            var settings = new Settings
            {
                currentDate = new System.DateTime(2022, 06, 09, 8, 10, 0),
                occurs = 1,
                monthlyFreq = 4, //Last
                dailyFreq = 9, //WeekendDay
                monthly2Freq = 2, //Num Months
                the = true,
                occursEveryFreq = 1,
                freq = 0,
                startingHour = new System.DateTime(2000, 01, 01, 10, 0, 0),
                endingHour = new System.DateTime(2000, 01, 01, 16, 0, 0),
                startingLimit = new System.DateTime(2022, 1, 1, 0, 0, 0),
                endingLimit = new System.DateTime(2022, 12, 31, 0, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 06, 26, 10, 0, 0);
            //Act
            CalculateRecurring.calculate(settings);
            //Assert
            settings.nextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }
    }
}

