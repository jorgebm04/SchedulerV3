using FluentAssertions;
using SchedulerV3.Checks;
using Xunit;

namespace SchedulerV3.Test.Checks_Test
{
    public class CheckMonthlySettingsTests
    {
        [Fact]
        public void Validate_check_monthly_settings_the_month_freq()
        {
            //Arrange
            var settings = new Settings
            {
                The = true,
                MonthlyFreq = -1
            };
            //Act
            CheckMonthlySettings.CheckRecurrentMonthlySettings(settings);
            //Assert
            settings.NextExecutionTime.Should().Be("Select a frequency for the monthly frequency");
        }

        [Fact]
        public void Validate_check_monthly_settings_the_days_freq()
        {
            //Arrange
            var settings = new Settings
            {
                The = true,
                MonthlyFreq = 0,
                DailyFreq = -1
            };
            //Act
            CheckMonthlySettings.CheckRecurrentMonthlySettings(settings);
            //Assert
            settings.NextExecutionTime.Should().Be("Select a frequency for the days frequency");
        }

        [Fact]
        public void Validate_check_monthly_settings_not_day()
        {
            //Arrange
            var settings = new Settings();
            //Act
            CheckMonthlySettings.CheckRecurrentMonthlySettings(settings);
            //Assert
            settings.NextExecutionTime.Should().Be("Select a monthly configuration.");
        }
    }
}
