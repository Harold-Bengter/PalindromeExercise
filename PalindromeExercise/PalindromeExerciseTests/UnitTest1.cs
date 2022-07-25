using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
            [Theory]
            [InlineData("radar", true)]
            [InlineData("Kayak", true)]
            [InlineData("quack", false)]
            [InlineData("madam", true)]
            [InlineData("noon", true)]
            [InlineData("tooth", false)]
        public void IsAPalindrome(string word, bool expected)
        {
            // Arrange
            var wordsmith = new Wordsmith();

            // Act
            var actual = wordsmith.IsAPalindrome(word);

            // Assert
            Assert.Equal(expected, actual);
        }
        

        
    }
}
