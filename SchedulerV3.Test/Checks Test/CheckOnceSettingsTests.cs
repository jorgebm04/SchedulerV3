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
                CurrentDate = System.DateTime.Now
            };
            //Act
            bool result = CurrentDateChecker.CheckCurrentDate(settings.CurrentDate);
            //Assert
            result.Should().BeTrue();
        }

        [Fact]
        public void Validate_incorrect_current_date_checker()
        {
            //Arrange
            var settings = new Settings
            {
                CurrentDate = new System.DateTime(2000, 1, 1, 0, 0, 0)
            };
            //Act
            bool result = CurrentDateChecker.CheckCurrentDate(settings.CurrentDate);
            //Assert
            result.Should().BeFalse();
        }

        [Fact]
        public void Validate_correct_once_time_at_checker()
        {
            //Arrange
            var settings = new Settings
            {
                CurrentDate = new System.DateTime(2022, 05, 20, 15, 0, 0),
                OnceTimeAt = new System.DateTime(2022, 05, 30, 15, 0, 0)
            };
            //Act
            bool result = OnceTimeAtChecker.CheckOnceTimeAt(settings.CurrentDate, settings.OnceTimeAt);
            //Assert
            result.Should().BeTrue();
        }

        [Fact]
        public void Validate_incorrect_once_time_at_checker()
        {
            //Arrange
            var settings = new Settings
            {
                CurrentDate = new System.DateTime(2022, 05, 20, 15, 0, 0),
                OnceTimeAt = new System.DateTime(2022, 05, 10, 15, 0, 0)
            };
            //Act
            bool result = OnceTimeAtChecker.CheckOnceTimeAt(settings.CurrentDate, settings.OnceTimeAt);
            //Assert
            result.Should().BeFalse();
        }
    }
}