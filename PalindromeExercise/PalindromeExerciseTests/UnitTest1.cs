using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("hannah", true)]
        [InlineData("kayak", true)]
        [InlineData("Racecar", true)]
        [InlineData("Hannah", true)]
        [InlineData("Kayak", true)]
        [InlineData("devin", false)]
        [InlineData("bike", false)]
        [InlineData("", false)]
        [InlineData(null, false)]
        public void PalindromeTest(string word, bool expected)
        {
            var p = new WordSmith();

            var actual = p.IsAPalindrome(word);

            Assert.Equal(expected, actual);
        }
    }
}
