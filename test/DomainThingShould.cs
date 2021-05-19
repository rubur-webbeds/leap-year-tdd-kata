using LeapYearKata.Domain;
using System;
using Xunit;

namespace LeapYearKata.Test
{
    public class DomainThingShould
    {
        [Fact]
        public void Exist()
        {
            var sut = new LeapYearValidator();
            Assert.NotNull(sut);
        }

        [Theory]
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(7)]
        public void Not_Divisible_By_Four_Returns_False(int value)
        {
            // Arrange
            var sut = new LeapYearValidator();

            // Act
            var result = sut.IsLeapYear(value);

            // Assert
            Assert.False(result);
        }

        [Theory]
        [InlineData(4)]
        [InlineData(8)]
        [InlineData(400)]
        public void Is_Divisible_By_Four_Returns_True(int value)
        {
            // Arrange
            var sut = new LeapYearValidator();

            // Act
            var result = sut.IsLeapYear(value);

            // Assert
            Assert.True(result);
        }

        [Theory]
        [InlineData(4)]
        [InlineData(8)]
        [InlineData(400)]
        public void Is_Divisible_By_400_Returns_True(int value)
        {
            // Arrange
            var sut = new LeapYearValidator();

            // Act
            var result = sut.IsLeapYear(value);

            // Assert
            Assert.True(result);
        }


    }
}
