using System;
using LegacyCodeLibrary;
using Xunit;

namespace Tests
{
    public class LegacyTests
    {
        [Fact]
        public void ShouldReturnCorrectValueWhenEnteringTestString()
        {
            var result = Formatter.FormatText("<test/>");           
            Assert.Equal(string.Empty, result);           
        }

        [Fact]
        public void ShouldReturnCorrectValueWhenEnteringEmptyString()
        {
            var result = Formatter.FormatText(string.Empty);            
            Assert.Equal(string.Empty, result);
        }
    }
}