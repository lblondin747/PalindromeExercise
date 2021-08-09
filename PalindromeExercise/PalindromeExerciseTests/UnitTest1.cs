using System;
using Xunit;
using PalindromeExercise;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("Rotator", true)]
        [InlineData("Racecar", true)]
        [InlineData("Potato",false)]
        public void isaPalindrome(string input, bool expected)
        {
            var wordSmith = new WordSmith();

            var actual = wordSmith.isaPalindrome(input);

            Assert.Equal(expected, actual);
        }
    }
}
