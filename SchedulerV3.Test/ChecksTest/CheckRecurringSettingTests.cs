using Xunit;
using FluentAssertions;

namespace SchedulerV3.Test
{
    public class CheckRecurringSettingTests
    {
        [Fact]
        public void Validate_correct_month_frequency_checker()
        {
            //Arrange
            var settings = new Settings
            {
                monthlyFreq = 1
               
            };
            //Act
            bool result = MonthFrequencyChecker.CheckMonthFrequency(settings.monthlyFreq);
            //Assert
            result.Should().BeTrue();
        }

        [Fact]
        public void Validate_incorrect_month_frequency_checker()
        {
            //Arrange
            var settings = new Settings
            {
                monthlyFreq = -1

            };
            //Act
            bool result = MonthFrequencyChecker.CheckMonthFrequency(settings.monthlyFreq);
            //Assert
            result.Should().BeFalse();
        }

        [Fact]
        public void Validate_correct_day_frequency_checker()
        {
            //Arrange
            var settings = new Settings
            {
                dailyFreq = 1

            };
            //Act
            bool result = DayFrequencyChecker.CheckDayFrequency(settings.dailyFreq);
            //Assert
            result.Should().BeTrue();
        }

        [Fact]
        public void Validate_incorrect_day_frequency_checker()
        {
            //Arrange
            var settings = new Settings
            {
                dailyFreq = -1

            };
            //Act
            bool result = DayFrequencyChecker.CheckDayFrequency(settings.dailyFreq);
            //Assert
            result.Should().BeFalse();
        }

        [Fact]
        public void Validate_correct_occurs_once_at_checker()
        {
            //Arrange
            var settings = new Settings
            {
                currentDate = new System.DateTime(2022, 05, 20, 15, 0, 0),
                occursOnceAtHour = new System.DateTime(2022, 05, 30, 15, 0, 0)
            };
            //Act
            bool result = NeedToAddDaysChecker.CheckNeedToAddDays(settings.currentDate,settings.occursOnceAtHour);
            //Assert
            result.Should().BeFalse();
        }

        [Fact]
        public void Validate_incorrect_occurs_once_at_checker()
        {
            //Arrange
            var settings = new Settings
            {
                currentDate = new System.DateTime(2022, 05, 20, 15, 0, 0),
                occursOnceAtHour = new System.DateTime(2022, 05, 10, 13, 0, 0)
            };
            //Act
            bool result = NeedToAddDaysChecker.CheckNeedToAddDays(settings.currentDate, settings.occursOnceAtHour);
            //Assert
            result.Should().BeTrue();
        }

        [Fact]
        public void Validate_correct_time_limits_checker()
        {
            //Arrange
            var settings = new Settings
            {
                startingLimit = new System.DateTime(2022, 05, 10, 0, 0, 0),
                endingLimit = new System.DateTime(2022, 05, 30, 0, 0, 0)
            };
            //Act
            bool result = RecurringLimitsChecker.CheckLimits(settings.startingLimit, settings.endingLimit);
            //Assert
            result.Should().BeTrue();
        }

        [Fact]
        public void Validate_incorrect_time_limits_checker()
        {
            //Arrange
            var settings = new Settings
            {
                startingLimit = new System.DateTime(2022, 05, 30, 0, 0, 0),
                endingLimit = new System.DateTime(2022, 05, 10, 0, 0, 0)
            };
            //Act
            bool result = RecurringLimitsChecker.CheckLimits(settings.startingLimit, settings.endingLimit);
            //Assert
            result.Should().BeFalse();
        }

        [Fact]
        public void Validate_correct_time_limits_with_current_date_checker()
        {
            //Arrange
            var settings = new Settings
            {
                currentDate = new System.DateTime(2022, 05, 20, 0, 0, 0),
                startingLimit = new System.DateTime(2022, 05, 10, 0, 0, 0),
                endingLimit = new System.DateTime(2022, 05, 30, 0, 0, 0)
            };
            //Act
            bool result = RecurringLimitsChecker.CheckLimitsWithCurrentDate(settings.startingLimit, settings.endingLimit, settings.currentDate);
            //Assert
            result.Should().BeTrue();
        }

        [Fact]
        public void Validate_incorrect_time_limits_with_current_date_pre_limits_checker()
        {
            //Arrange
            var settings = new Settings
            {
                currentDate = new System.DateTime(2022, 05, 05, 0, 0, 0),
                startingLimit = new System.DateTime(2022, 05, 30, 0, 0, 0),
                endingLimit = new System.DateTime(2022, 05, 10, 0, 0, 0)
            };
            //Act
            bool result = RecurringLimitsChecker.CheckLimits(settings.startingLimit, settings.endingLimit);
            //Assert
            result.Should().BeFalse();
        }

        [Fact]
        public void Validate_incorrect_time_limits_with_current_date_post_limits_checker()
        {
            //Arrange
            var settings = new Settings
            {
                currentDate = new System.DateTime(2022, 06, 05, 0, 0, 0),
                startingLimit = new System.DateTime(2022, 05, 30, 0, 0, 0),
                endingLimit = new System.DateTime(2022, 05, 10, 0, 0, 0)
            };
            //Act
            bool result = RecurringLimitsChecker.CheckLimits(settings.startingLimit, settings.endingLimit);
            //Assert
            result.Should().BeFalse();
        }

        [Fact]
        public void Validate_correct_every_combobox()
        {
            //Arrange
            var settings = new Settings
            {
                occursEveryFreq = 0
            };
            //Act
            bool result = OccursEveryChecker.CheckOccursEveryComboBox(settings.occursEveryFreq);
            //Assert
            result.Should().BeTrue();
        }

        [Fact]
        public void Validate_incorrect_every_combobox()
        {
            //Arrange
            var settings = new Settings
            {
                occursEveryFreq = -1
            };
            //Act
            bool result = OccursEveryChecker.CheckOccursEveryComboBox(settings.occursEveryFreq);
            //Assert
            result.Should().BeFalse();
        }

        [Fact]
        public void Validate_correct_occurs_limits()
        {
            //Arrange
            var settings = new Settings
            {
                startingHour = new System.DateTime(2022, 06, 05, 10, 0, 0),
                endingHour = new System.DateTime(2022, 06, 05, 15, 0, 0)
            };
            //Act
            bool result = OccursEveryChecker.CheckOccursEveryLimits(settings.startingHour, settings.endingHour);
            //Assert
            result.Should().BeTrue();
        }

        [Fact]
        public void Validate_incorrect_occurs_limits()
        {
            //Arrange
            var settings = new Settings
            {
                startingHour = new System.DateTime(2022, 06, 05, 16, 0, 0),
                endingHour = new System.DateTime(2022, 06, 05, 15, 0, 0)
            };
            //Act
            bool result = OccursEveryChecker.CheckOccursEveryLimits(settings.startingHour, settings.endingHour);
            //Assert
            result.Should().BeFalse();
        }
    }
}
