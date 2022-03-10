using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar",true)]
        [InlineData(null,false)]
        [InlineData("hi", false)]
        [InlineData("tttt", true)]
        [InlineData("ttest", false)]
     
        public void Test1(string str,bool expected)
        {
            // arrange
            WordSmith input = new WordSmith();

            //act
            var actual = input.ISAPalindrome(str);

            //assert

            Assert.Equal(expected, actual);
        }
    }
}
