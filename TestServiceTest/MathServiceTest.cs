using System;
using TestServiceAppXUnit;
using Xunit;

namespace TestServiceTest
{
    public class MathServiceTest
    {
        private MathService _mathService = new MathService();

        [Fact]
        public void AdditionTest()
        {
            double expected = 20;
            double actual = _mathService.Addition(10, 10);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void SubtractionTest()
        {
            double expected = 10;
            double actual = _mathService.Subtraction(20, 10);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void MultiplicationTest()
        {
            double expected = 100;
            double actual = _mathService.Multiplication(10, 10);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void DivisionTest()
        {
            double expected = 4;
            double actual = _mathService.Division(20, 5);
            Assert.Equal(expected, actual);
        }
    }
}
