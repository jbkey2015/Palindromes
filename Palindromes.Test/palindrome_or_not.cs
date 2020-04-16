using System;
using Xunit;

namespace Palindromes.Test
{
    public class palindrome_or_not
    {
        [Fact]
        public void stars_palindrome()
        {
            //Arrange
            var palindrome = "stars";
            var expectedResult = false;
            var palindromeTester = new PalindromeTester();

            //Act
            var actualResult = palindromeTester.IsPalindrome(palindrome);

            //Assert
            Assert.Equal(expectedResult, actualResult);

        }

        [Fact]
        public void Oakakuwakovlilvokawukakao_palindrome()
        {
            //Arrange
            var palindrome = "O, a kak Uwakov lil vo kawu kakao!";
            var expectedResult = true;
            var palindromeTester = new PalindromeTester();

            //Act
            var actualResult = palindromeTester.IsPalindrome(palindrome);

            //Assert
            Assert.Equal(expectedResult, actualResult);

        }
    }
}
