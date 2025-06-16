using Xunit;
using UnitTestStudy;

namespace UnitTestStudy.Tests
{
    public class UnitTestStudyCoverageFixTests
    {
        // Coverageが100%になるがテスト品質は変わらない例
        [Fact]
        public void Test_StringHelperCoverageFix_IsStringLong_ReturnsFalse_ForShortString()
        {
            // Arrange
            string input = "abc";

            // Act
            bool result = StringHelperCoverageFix.IsStringLong(input);

            // Assert
            Assert.False(result);
        }
    }
}