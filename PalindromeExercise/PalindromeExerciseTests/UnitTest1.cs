using System;
using Xunit;
using PalindromeExercise;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("RaCeCaR", true)]
        [InlineData("hello", false)]
        [InlineData("", false)]
        public void IsPalindrome(string word, bool expected)
        {
            //arrange
            var test = new IsPalindrome();
            //act
            var actual = test.IsAPalindrome(word);
            //assert
            Assert.Equal(expected, actual);
        }
    }
}
