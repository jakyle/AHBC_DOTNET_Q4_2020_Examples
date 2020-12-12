using System;
using UnitTesting101;
using Xunit;

namespace SimpleMathTests
{
    public class SimpleMathTestClass
    {
        //[Fact]
        //public void OurFIsZero_ConvertToC_OuputZero()
        //{
        //    // Arrange  - I'm going to setup all of the classes and test data that I'm going to test
        //    var simpleMath = new SimpleMath();
        //    var test = 0;

        //    // Act - you will CALL the method that you want to test
        //    var result = simpleMath.ConvertToCelsius(0);

        //    // Assert - You are ASSERTING, or making a CLAIM that x will == y , or your test cases will pass
        //    Assert.Equal(result, test);
        //}

        [Fact]
        public void OurFIs90_ConvertToC_OuputThirtyTwoPointTwoTwoTwo()
        {
            // Arrange  - I'm going to setup all of the classes and test data that I'm going to test
            var simpleMath = new SimpleMath();
            var expected = 32.22222222222222;

            // Act - you will CALL the method that you want to test
            var result = simpleMath.ConvertToCelsius(90);

            // Assert - You are ASSERTING, or making a CLAIM that x will == y , or your test cases will pass
            Assert.Equal(expected, result);
        }


        [Fact]
        public void OurFIs212_ConvertToC_OuputOneHundred()
        {
            // Arrange  - I'm going to setup all of the classes and test data that I'm going to test
            var simpleMath = new SimpleMath();
            var expected = 100;

            // Act - you will CALL the method that you want to test
            var result = simpleMath.ConvertToCelsius(212);

            // Assert - You are ASSERTING, or making a CLAIM that x will == y , or your test cases will pass
            Assert.Equal(expected, result);
        }


        [Fact]
        public void LengthAndWidth_GetArea_AreaOfFortyTwo()
        {
            // Arrange  - I'm going to setup all of the classes and test data that I'm going to test
            var simpleMath = new SimpleMath();
            var expected = 42;

            // Act - you will CALL the method that you want to test
            var result = simpleMath.GetAreaOfRoom(6, 7);

            // Assert - You are ASSERTING, or making a CLAIM that x will == y , or your test cases will pass
            Assert.Equal(expected, result);
        }


        [Fact]
        public void OurAgeIsFifteen_CheckIfICanLegallyDrink_ICannotDrink()
        {
            // Arrange  - I'm going to setup all of the classes and test data that I'm going to test
            var simpleMath = new SimpleMath();
            var expected = false;

            // Act - you will CALL the method that you want to test
            var result = simpleMath.IsOldEnoughToDrink(15);

            // Assert - You are ASSERTING, or making a CLAIM that x will == y , or your test cases will pass
            Assert.Equal(expected, result);
        }

        [Fact]
        public void OurAgeIs23_CheckIfICanLegallyDrink_ICanDrink()
        {
            // Arrange  - I'm going to setup all of the classes and test data that I'm going to test
            var simpleMath = new SimpleMath();
            var expected = true;

            // Act - you will CALL the method that you want to test
            var result = simpleMath.IsOldEnoughToDrink(23);

            // Assert - You are ASSERTING, or making a CLAIM that x will == y , or your test cases will pass
            Assert.Equal(expected, result);
        }

    }
}
