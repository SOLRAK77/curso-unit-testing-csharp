using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace StringManipulation.Tests
{
    public class StringOperationsTest
    {
        [Fact]
        public void ConcatenateStrings()
        {
            var stringOperations = new StringOperations();

            var result = stringOperations.ConcatenateStrings("Hello,", "World!");
            Assert.Equal("Hello, World!", result);
        }

        [Fact]
        public void IsPalindrome_True()
        {
            // Arrange
            var stringOperations = new StringOperations();
            // Act
            var result = stringOperations.IsPalindrome("ama");
            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsPalindrome_False()
        {
            // Arrange
            var stringOperations = new StringOperations();
            // Act
            var result = stringOperations.IsPalindrome("adriana");
            // Assert
            Assert.False(result);
        }

        [Fact]
        public void RemoveWhitespace()
        {
            // Arrange
            var stringOperations = new StringOperations();
            // Act
            var result = stringOperations.RemoveWhitespace("Hello world 2025");
            // Assert
            Assert.Equal("Helloworld2025", result);
        }

        [Fact]
        public void RemoveWhitespace_True()
        {
            // Arrange
            var stringOperations = new StringOperations();
            // Act
            var result = stringOperations.RemoveWhitespace("lleva ese libro y ponlo encima de la mesa roja de la derecha");
            // Assert
            Assert.NotNull(result);
            Assert.NotEmpty(result);
            Assert.IsType<string>(result);
            Assert.DoesNotContain(" ", result);
            Assert.Equal("llevaeselibroyponloencimadelamesarojadeladerecha", result);
        }

        [Fact]
        public void QuantintyInWords()
        {
            // Arrange
            var stringOperations = new StringOperations();
            // Act
            var result = stringOperations.QuantintyInWords("Gato", 5);
            // Assert
            Assert.Equal("cinco Gatos", result);
        }

        [Fact]
        public void GetStringLength_Exception()
        {
            // Arrange
            var stringOperations = new StringOperations();
            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => stringOperations.GetStringLength(null));
        }

        [Fact]
        public void GetStringLength()
        {
            // Arrange
            var stringOperations = new StringOperations();
            // Act
            var result = stringOperations.GetStringLength("castillo");
            // Assert
            Assert.Equal(8, result);
        }

        [Fact(Skip = "Pendiente")]
        public void GetStringLength_Pendiente()
        {
            // Arrange
            var stringOperations = new StringOperations();
            // Act
            var result = stringOperations.GetStringLength("castillo");
            // Assert
            Assert.Equal(8, result);
        }


        [Theory]
        [InlineData("V", 5)]
        [InlineData("IV", 4)]
        [InlineData("XL", 40)]
        public void FromRomanToNumber(string input, int expected)
        {
            // Arrange
            var stringOperations = new StringOperations();
            // Act
            var result = stringOperations.FromRomanToNumber(input);
            // Assert
            Assert.Equal(expected, result);
        }
    }
}
