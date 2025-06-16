using Xunit;

namespace UnitTestStudy.Tests
{
    public class UnitTestStudyTests
    {
        // 3文字の場合Falseを返すことを確認するテスト
        [Fact]
        public void Test_IsStringLong_ReturnsFalse_ForShortString()
        {
            // Arrange
            string input = "abc";

            // Act
            bool result = StringHelper.IsStringLong(input);

            // Assert
            Assert.False(result);
        }
    }
}