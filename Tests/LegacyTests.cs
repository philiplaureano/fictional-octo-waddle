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
            
            // The test will initially fail, but it will give us the value
            // returned by the legacy component
            Assert.Equal(null, result);
            
            // TODO: Write the resulting assertion here with the expected actual value
        }
    }
}