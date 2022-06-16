using FluentAssertions;
using SchedulerV3.Checks;
using System;
using Xunit;

namespace SchedulerV3.Test.Checks_Test
{
    public  class CheckDailySettingsTests
    {
        [Fact]
        public void Validate_check_daily_settings_occurs_once_need_to_add_day()
        {
            //Arrange
            var settings = new Settings
            {
                CurrentDate = new DateTime(2022,06,16,10,0,0),
                OccursOnceAtHour = new DateTime(2022, 06, 19, 9, 0, 0),
                OccursOnceAt = true
            };
            //Act
            CheckDailySettings.CheckRecurringDailySettings(settings);
            //Assert
            settings.NeedToAddDay.Should().BeTrue();
        }

        [Fact]
        public void Validate_check_daily_settings_occurs_every_need_to_add_day_not_occurs()
        {
            //Arrange
            var settings = new Settings
            {
                CurrentDate = new DateTime(2022, 06, 16, 10, 0, 0),
                EndingHour = new DateTime(2022, 08, 16, 12, 0, 0),
                OccursEvery = true,
                Freq = -1
            };
            //Act
            CheckDailySettings.CheckRecurringDailySettings(settings);
            //Assert
            settings.NextExecutionTime.Should().Be("Select a frequency for the daily frequency");
        }

        [Fact]
        public void Validate_check_daily_settings_occurs_every_need_to_add_day_not_limits()
        {
            //Arrange
            var settings = new Settings
            {
                CurrentDate = new DateTime(2022, 06, 16, 10, 0, 0),
                StartingHour = new DateTime(2022,08,16,14,0,0,0),
                EndingHour = new DateTime(2022, 08, 16, 12, 0, 0),
                OccursEvery = true,
                Freq = 0
            };
            //Act
            CheckDailySettings.CheckRecurringDailySettings(settings);
            //Assert
            settings.NextExecutionTime.Should().Be("Limits in the daily frequency not correct");
        }

        [Fact]
        public void Validate_not_check_daily_settings_occurs_every()
        {
            //Arrange
            var settings = new Settings
            {
            };
            //Act
            CheckDailySettings.CheckRecurringDailySettings(settings);
            //Assert
            settings.NextExecutionTime.Should().Be("Select a type for daily frequency.");
        }

        [Fact]
        public void Validate_check_daily_settings_occurs_once_limits()
        {
            //Arrange
            var settings = new Settings
            {
                CurrentDate = new DateTime(2022, 06, 16, 10, 0, 0),
                OccursOnceAtHour = new DateTime(2022, 06, 19, 9, 0, 0),
                OccursOnceAt = true,
                StartingLimit = new DateTime(2022,12,31,0,0,0),
                EndingLimit = new DateTime(2022,1,1,0,0,0)
            };
            //Act
            CheckDailySettings.CheckRecurringDailySettings(settings);
            //Assert
            settings.NextExecutionTime.Should().Be("Not correct limits");
        }

        [Fact]
        public void Validate_check_daily_settings_occurs_once_out_limits()
        {
            //Arrange
            var settings = new Settings
            {
                CurrentDate = new DateTime(2021, 06, 16, 10, 0, 0),
                OccursOnceAtHour = new DateTime(2022, 06, 19, 9, 0, 0),
                OccursOnceAt = true,
                StartingLimit = new DateTime(2022, 1, 1, 0, 0, 0),
                EndingLimit = new DateTime(2022, 12, 31, 0, 0, 0)
            };
            //Act
            CheckDailySettings.CheckRecurringDailySettings(settings);
            //Assert
            settings.NextExecutionTime.Should().Be("Current date not in the limits");
        }
    }
}
