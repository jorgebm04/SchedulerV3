using FluentAssertions;
using SchedulerV3.Checks;
using SchedulerV3.Descriptions;
using System;
using Xunit;

namespace SchedulerV3.Test.Checks_Test
{
    public class CheckOnceSettingsTests
    {
        [Fact]
        public void Validate_incorrect_current_date_checker_settings()
        {
            //Arrange
            var settings = new Settings
            {
                CurrentDate = new DateTime(2022, 1, 1, 0, 0, 0)
            };
            //Act
            CheckOnceSettings.CheckSettings(settings);
            //Assert
            settings.NextExecutionTime.Should().Be("Current date not correct.");
        }

        [Fact]
        public void Validate_once_description()
        {
            //Arrange
            var settings = new Settings
            {
                CalculatedDate = new DateTime(2022, 06, 16, 10, 0, 0)
            };
            //Act
            OnceDescription.SetDescription(settings);
            //Assert
            settings.Description.Should().Be("Occurs once. Schedule will be used on " + settings.CalculatedDate.ToString("dd'/'MM'/'yyyy") + " at " +
                        settings.CalculatedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_incorrect_once_time_at_date_checker_settings()
        {
            //Arrange
            var settings = new Settings
            {
                CurrentDate = DateTime.Now,
                OnceTimeAt = new DateTime(2022,1,1,0,0,0)
            };
            //Act
            CheckOnceSettings.CheckSettings(settings);
            //Assert
            settings.NextExecutionTime.Should().Be("Once time at date not valid");
        }

        [Fact]
        public void Validate_correct_current_date_checker()
        {
            //Arrange
            var settings = new Settings
            {
                CurrentDate = DateTime.Now
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