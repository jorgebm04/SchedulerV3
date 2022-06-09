using Xunit;
using FluentAssertions;

namespace SchedulerV3.Test
{
    public class CheckOnceSettingsTests
    {
        [Fact]
        public void Validate_correct_current_date_checker()
        {
            //Arrange
            var settings = new Settings
            {
                currentDate = System.DateTime.Now
            };
            //Act
            bool result = CurrentDateChecker.CheckCurrentDate(settings.currentDate);
            //Assert
            result.Should().BeTrue();
        }

        [Fact]
        public void Validate_incorrect_current_date_checker()
        {
            //Arrange
            var settings = new Settings
            {
                currentDate = new System.DateTime(2000, 1, 1, 0, 0, 0)
            };
            //Act
            bool result = CurrentDateChecker.CheckCurrentDate(settings.currentDate);
            //Assert
            result.Should().BeFalse();
        }

        [Fact]
        public void Validate_correct_once_time_at_checker()
        {
            //Arrange
            var settings = new Settings
            {
                currentDate = new System.DateTime(2022, 05, 20, 15, 0, 0),
                onceTimeAt = new System.DateTime(2022, 05, 30, 15, 0, 0)
            };
            //Act
            bool result = OnceTimeAtChecker.CheckOnceTimeAt(settings.currentDate, settings.onceTimeAt);
            //Assert
            result.Should().BeTrue();
        }

        [Fact]
        public void Validate_incorrect_once_time_at_checker()
        {
            //Arrange
            var settings = new Settings
            {
                currentDate = new System.DateTime(2022, 05, 20, 15, 0, 0),
                onceTimeAt = new System.DateTime(2022, 05, 10, 15, 0, 0)
            };
            //Act
            bool result = OnceTimeAtChecker.CheckOnceTimeAt(settings.currentDate, settings.onceTimeAt);
            //Assert
            result.Should().BeFalse();
        }
    }
}