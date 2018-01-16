using System;
using Xunit;
namespace Calculator.Tests
{
    public class TheCalculatorShould
    {
        private TheCalculator _calculator;

        public TheCalculatorShould()
        {
            _calculator = new TheCalculator();
        }

        [Fact]
        public void AddTwoIntegers()
        {
            // Given this input to the method
            int sum = _calculator.Add(54, 29);
            
            // We are asserting that the output should be this
            Assert.Equal(sum, 83);
        }
    }
}