using Xunit;
using FluentAssertions;
using SchedulerV3.Calculate;

namespace SchedulerV3.Test.Calculates_Test
{
    public class CalculateOnceTests
    {
        [Fact]
        public void Validate_calculated_date_type_once()
        {
            //Arrange
            var settings = new Settings
            {
                CurrentDate = new System.DateTime(2022, 05, 27, 8, 10, 0),
                OnceTimeAt = new System.DateTime(2022, 05, 30, 14, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 05, 30, 14, 0, 0);
            //Act
            CalculateOnce.CalculateNextExecutionTime(settings);
            //Assert
            settings.NextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy HH:mm"));
        }
    }
}
