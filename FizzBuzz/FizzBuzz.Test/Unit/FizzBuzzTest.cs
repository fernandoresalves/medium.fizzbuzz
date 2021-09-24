using System;
using Xunit;

namespace FizzBuzz.Test.Unit
{
    public class FizzBuzzTest
    {
        [Theory(DisplayName ="Valida Fizz como falso.")]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(1)]
        public void Validate_Fizz_ReturnFalse(int number)
        {
            Assert.False(Logic.FizzBuzz.IsFizz(number));
        }

        [Theory(DisplayName = "Valida Fizz como verdadeiro.")]
        [InlineData(3)]
        [InlineData(6)]
        [InlineData(9)]
        public void Validate_Fizz_ReturnTrue(int number)
        {
            Assert.True(Logic.FizzBuzz.IsFizz(number));
        }

        [Theory(DisplayName = "Valida Buzz como falso.")]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(1)]
        public void Validate_Buzz_ReturnFalse(int number)
        {
            Assert.False(Logic.FizzBuzz.IsBuzz(number));
        }

        [Theory(DisplayName = "Valida Buzz como verdadeiro.")]
        [InlineData(5)]
        [InlineData(10)]
        [InlineData(15)]
        public void Validate_Buzz_ReturnTrue(int number)
        {
            Assert.True(Logic.FizzBuzz.IsBuzz(number));
        }

        [Theory(DisplayName = "Valida FizzBuzz como falso.")]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(1)]
        public void Validate_FizzBuzz_ReturnFalse(int number)
        {
            Assert.False(Logic.FizzBuzz.IsFizzBuzz(number));
        }

        [Theory(DisplayName = "Valida FizzBuzz como verdadeiro.")]
        [InlineData(15)]
        [InlineData(30)]
        [InlineData(45)]
        public void Validate_FizzBuzz_ReturnTrue(int number)
        {
            Assert.True(Logic.FizzBuzz.IsFizzBuzz(number));
        }
    }
}
