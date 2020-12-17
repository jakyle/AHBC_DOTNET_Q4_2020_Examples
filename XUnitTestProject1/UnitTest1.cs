using System;
using UnitTesting101;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(true, 32)]
        [InlineData(true, 21)]
        [InlineData(false, 13)]
        [InlineData(false, 8)]
        public void Test1(bool expected, int age)
        {
            // ARRANGE
            // "system under test"
            var sut = new SimpleMath();


            // ACT
            var actual = sut.IsOldEnoughToDrink(age);

            // ASSERT
            Assert.Equal(expected, actual);
        }
    }
}
