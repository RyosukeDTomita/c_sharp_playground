using Xunit;
namespace HelloWorld.Tests;
using HelloWorld;

public class CoverageSampleTest
{
    [Fact]
    public void TestIsOddWithOddNumber()
    {
        // Arrange
        var sample = new CoverageSample();
        
        // Act
        bool result = sample.isOdd(5);
        
        // Assert
        Assert.True(result);
    }

    [Fact]
    public void TestIsOddWithEvenNumber()
    {
        // Arrange
        var sample = new CoverageSample();
        
        // Act
        bool result = sample.isOdd(4);
        
        // Assert
        Assert.False(result);
    }
}
