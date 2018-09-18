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
            // Ensure that the FormatText method throws a null ref exception
            // when a null is passed
            Assert.Throws<NullReferenceException>(() => Formatter.FormatText(null));
        }
    }
}