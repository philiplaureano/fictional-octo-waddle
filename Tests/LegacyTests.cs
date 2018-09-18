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

        [Fact]
        public void ShouldBehaveCorrectlyWhenPassingNullValue()
        {
            var result = Formatter.FormatText(null);
            
            // Note: I'm using a random string to guarantee that the test will never pass
            // and so that it'll give me the actual return value that will be used
            // as the expected value
            Assert.Equal(Guid.NewGuid().ToString(), result);
        }
    }
}