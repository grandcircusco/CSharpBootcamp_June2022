using ConsoleApp1;
using Xunit;

namespace UnitLecture
{
    public class UnitTest1
    {
        [Fact]//A single test
        public void TwoNumbersAddedUpWillSum()
        {
            //Arrange
            Arithmetic sut = new Arithmetic();

            //Act
            int result = sut.Sum(2, 3);

            //Assert
            Assert.Equal(5, result);
        }
        //Break TTD RULES to show example

        [Theory]
        [InlineData(2,3,5)]//positives
        [InlineData(-2, -3, -5)]//negatives
        [InlineData(-2, 3, 1)]//positives and negatives
        public void TwoNumbersAddedUpWillSumV2(int num1, int num2, int expected)
        {
            //Arrange
            Arithmetic sut = new Arithmetic();

            //Act
            int result = sut.Sum(num1, num2);

            //Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(3,2,1)]
        [InlineData(-3, -2, -1)]
        [InlineData(-3, 2, -5)]
        public void TwoNumbersSubtractedWillTotal(double num1, double num2, double expected)
        {
            //Arrange
            Arithmetic sut = new Arithmetic();

            //Act
            double result = sut.Sub(num1, num2);

            //Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(2, 3, 6)]
        [InlineData(-2, -3, 6)]
        [InlineData(-2, 3, -6)]
        public void TwoNumbersMultipliedWillSum(double num1, double num2, double expected)
        {
            //Arrange
            Arithmetic sut = new Arithmetic();

            //Act
            double result = sut.Multi(num1, num2);

            //Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(6, 3, 2)]
        [InlineData(-6, -3, 2)]
        [InlineData(-6, 3, -2)]
        public void TwoNumbersDividedWillSum(double num1, double num2, double expected)
        {
            //Arrange
            Arithmetic sut = new Arithmetic();

            //Act
            double result = sut.Divide(num1, num2);

            //Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(6, 3, 0)]
        [InlineData(6, 4, 2)]
        [InlineData(-6, -4, -2)]
        [InlineData(-6, 4, -2)]
        public void TwoNumbersDividedWillRemainder(double num1, double num2, double expected)
        {
            //Arrange
            Arithmetic sut = new Arithmetic();

            //Act
            double result = sut.Remainder(num1, num2);

            //Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(32,"c",0)]
        [InlineData(68, "c", 20)]
        [InlineData(100, "f", 212)]
        [InlineData(-40, "f", -40)]
        public void TempsWillConvert(int temp, string unit, int expected)
        {
            //Arrange
            Arithmetic sut = new Arithmetic();

            //Act
            double result = sut.TempConvert(temp, unit);

            //Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("casual" , 53, "Something Comfy A Coat")]
        [InlineData("casual", 54, "Something Comfy A jacket")]
        [InlineData("casual", 71, "Something Comfy No Jacket")]
        [InlineData("semi-formal", 53, "A polo A Coat")]
        [InlineData("semi-formal", 54, "A polo A jacket")]
        [InlineData("semi-formal", 71, "A polo No Jacket")]
        [InlineData("formal", 53, "A suit A Coat")]
        [InlineData("formal", 54, "A suit A jacket")]
        [InlineData("formal", 71, "A suit No Jacket")]
        public void SuggestionsCorrectlySuggested(string eventType, int temp, string expected)
        {
            //Arrange
            Arithmetic sut = new Arithmetic();

            //Act
            string result = sut.SuggestClothes(eventType, temp);

            //Assert
            Assert.Equal(expected, result);
        }
    }
}