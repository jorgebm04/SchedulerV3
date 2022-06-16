using FluentAssertions;
using SchedulerV3.Checks;
using Xunit;

namespace SchedulerV3.Test.Checks_Test
{
    public class CheckRecurringSettingTests
    {
        [Fact]
        public void Validate_correct_month_frequency_checker()
        {
            //Arrange
            var settings = new Settings
            {
                MonthlyFreq = 1
               
            };
            //Act
            bool result = MonthFrequencyChecker.CheckMonthFrequency(settings.MonthlyFreq);
            //Assert
            result.Should().BeTrue();
        }

        [Fact]
        public void Validate_incorrect_month_frequency_checker()
        {
            //Arrange
            var settings = new Settings
            {
                MonthlyFreq = -1

            };
            //Act
            bool result = MonthFrequencyChecker.CheckMonthFrequency(settings.MonthlyFreq);
            //Assert
            result.Should().BeFalse();
        }

        [Fact]
        public void Validate_correct_day_frequency_checker()
        {
            //Arrange
            var settings = new Settings
            {
                DailyFreq = 1

            };
            //Act
            bool result = DayFrequencyChecker.CheckDayFrequency(settings.DailyFreq);
            //Assert
            result.Should().BeTrue();
        }

        [Fact]
        public void Validate_incorrect_day_frequency_checker()
        {
            //Arrange
            var settings = new Settings
            {
                DailyFreq = -1

            };
            //Act
            bool result = DayFrequencyChecker.CheckDayFrequency(settings.DailyFreq);
            //Assert
            result.Should().BeFalse();
        }

        [Fact]
        public void Validate_correct_occurs_once_at_checker()
        {
            //Arrange
            var settings = new Settings
            {
                CurrentDate = new System.DateTime(2022, 05, 20, 15, 0, 0),
                OccursOnceAtHour = new System.DateTime(2022, 05, 30, 15, 0, 0)
            };
            //Act
            bool result = NeedToAddDaysChecker.CheckNeedToAddDays(settings.CurrentDate,settings.OccursOnceAtHour);
            //Assert
            result.Should().BeFalse();
        }

        [Fact]
        public void Validate_incorrect_occurs_once_at_checker()
        {
            //Arrange
            var settings = new Settings
            {
                CurrentDate = new System.DateTime(2022, 05, 20, 15, 0, 0),
                OccursOnceAtHour = new System.DateTime(2022, 05, 10, 13, 0, 0)
            };
            //Act
            bool result = NeedToAddDaysChecker.CheckNeedToAddDays(settings.CurrentDate, settings.OccursOnceAtHour);
            //Assert
            result.Should().BeTrue();
        }

        [Fact]
        public void Validate_correct_time_limits_checker()
        {
            //Arrange
            var settings = new Settings
            {
                StartingLimit = new System.DateTime(2022, 05, 10, 0, 0, 0),
                EndingLimit = new System.DateTime(2022, 05, 30, 0, 0, 0)
            };
            //Act
            bool result = RecurringLimitsChecker.CheckLimits(settings.StartingLimit, settings.EndingLimit);
            //Assert
            result.Should().BeTrue();
        }

        [Fact]
        public void Validate_incorrect_time_limits_checker()
        {
            //Arrange
            var settings = new Settings
            {
                StartingLimit = new System.DateTime(2022, 05, 30, 0, 0, 0),
                EndingLimit = new System.DateTime(2022, 05, 10, 0, 0, 0)
            };
            //Act
            bool result = RecurringLimitsChecker.CheckLimits(settings.StartingLimit, settings.EndingLimit);
            //Assert
            result.Should().BeFalse();
        }

        [Fact]
        public void Validate_correct_time_limits_with_current_date_checker()
        {
            //Arrange
            var settings = new Settings
            {
                CurrentDate = new System.DateTime(2022, 05, 20, 0, 0, 0),
                StartingLimit = new System.DateTime(2022, 05, 10, 0, 0, 0),
                EndingLimit = new System.DateTime(2022, 05, 30, 0, 0, 0)
            };
            //Act
            bool result = RecurringLimitsChecker.CheckLimitsWithCurrentDate(settings.StartingLimit, settings.EndingLimit, settings.CurrentDate);
            //Assert
            result.Should().BeTrue();
        }

        [Fact]
        public void Validate_incorrect_time_limits_with_current_date_pre_limits_checker()
        {
            //Arrange
            var settings = new Settings
            {
                CurrentDate = new System.DateTime(2022, 05, 05, 0, 0, 0),
                StartingLimit = new System.DateTime(2022, 05, 30, 0, 0, 0),
                EndingLimit = new System.DateTime(2022, 05, 10, 0, 0, 0)
            };
            //Act
            bool result = RecurringLimitsChecker.CheckLimits(settings.StartingLimit, settings.EndingLimit);
            //Assert
            result.Should().BeFalse();
        }

        [Fact]
        public void Validate_incorrect_time_limits_with_current_date_post_limits_checker()
        {
            //Arrange
            var settings = new Settings
            {
                CurrentDate = new System.DateTime(2022, 06, 05, 0, 0, 0),
                StartingLimit = new System.DateTime(2022, 05, 30, 0, 0, 0),
                EndingLimit = new System.DateTime(2022, 05, 10, 0, 0, 0)
            };
            //Act
            bool result = RecurringLimitsChecker.CheckLimits(settings.StartingLimit, settings.EndingLimit);
            //Assert
            result.Should().BeFalse();
        }

        [Fact]
        public void Validate_correct_every_combobox()
        {
            //Arrange
            var settings = new Settings
            {
                OccursEveryFreq = 0
            };
            //Act
            bool result = OccursEveryChecker.CheckOccursEveryComboBox(settings.OccursEveryFreq);
            //Assert
            result.Should().BeTrue();
        }

        [Fact]
        public void Validate_incorrect_every_combobox()
        {
            //Arrange
            var settings = new Settings
            {
                OccursEveryFreq = -1
            };
            //Act
            bool result = OccursEveryChecker.CheckOccursEveryComboBox(settings.OccursEveryFreq);
            //Assert
            result.Should().BeFalse();
        }

        [Fact]
        public void Validate_correct_occurs_limits()
        {
            //Arrange
            var settings = new Settings
            {
                StartingHour = new System.DateTime(2022, 06, 05, 10, 0, 0),
                EndingHour = new System.DateTime(2022, 06, 05, 15, 0, 0)
            };
            //Act
            bool result = OccursEveryChecker.CheckOccursEveryLimits(settings.StartingHour, settings.EndingHour);
            //Assert
            result.Should().BeTrue();
        }

        [Fact]
        public void Validate_incorrect_occurs_limits()
        {
            //Arrange
            var settings = new Settings
            {
                StartingHour = new System.DateTime(2022, 06, 05, 16, 0, 0),
                EndingHour = new System.DateTime(2022, 06, 05, 15, 0, 0)
            };
            //Act
            bool result = OccursEveryChecker.CheckOccursEveryLimits(settings.StartingHour, settings.EndingHour);
            //Assert
            result.Should().BeFalse();
        }
    }
}
