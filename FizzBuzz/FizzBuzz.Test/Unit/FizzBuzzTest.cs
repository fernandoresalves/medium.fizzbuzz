using System;
using Xunit;

namespace FizzBuzz.Test.Unit
{
    public class FizzBuzzTest
    {
        [Theory(DisplayName ="Valida Fizz como falso.")]
        [InlineData(-1)]
        [InlineData(1)]
        [InlineData(2)]
        public void Validate_Fizz_ReturnFalse(int number)
        {
            Assert.False(Logic.FizzBuzz.IsFizz(number));
        }

        [Theory(DisplayName = "Valida Fizz como verdadeiro.")]
        [InlineData(0)]
        [InlineData(3)]
        [InlineData(6)]
        public void Validate_Fizz_ReturnTrue(int number)
        {
            Assert.True(Logic.FizzBuzz.IsFizz(number));
        }

        [Theory(DisplayName = "Valida Buzz como falso.")]
        [InlineData(-1)]
        [InlineData(1)]
        [InlineData(2)]
        public void Validate_Buzz_ReturnFalse(int number)
        {
            Assert.False(Logic.FizzBuzz.IsBuzz(number));
        }

        [Theory(DisplayName = "Valida Buzz como verdadeiro.")]
        [InlineData(0)]
        [InlineData(5)]
        [InlineData(15)]
        public void Validate_Buzz_ReturnTrue(int number)
        {
            Assert.True(Logic.FizzBuzz.IsBuzz(number));
        }

        [Theory(DisplayName = "Valida FizzBuzz como falso.")]
        [InlineData(-1)]
        [InlineData(1)]
        [InlineData(2)]
        public void Validate_FizzBuzz_ReturnFalse(int number)
        {      
            Assert.False(Logic.FizzBuzz.IsFizzBuzz(number));
        }

        [Theory(DisplayName = "Valida FizzBuzz como verdadeiro.")]
        [InlineData(0)]
        [InlineData(30)]
        [InlineData(45)]
        public void Validate_FizzBuzz_ReturnTrue(int number)
        {
            Assert.True(Logic.FizzBuzz.IsFizzBuzz(number));
        }
    }
}
