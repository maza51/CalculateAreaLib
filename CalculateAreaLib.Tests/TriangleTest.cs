using Xunit;

namespace CalculateAreaLib.Tests;

public class TriangleTest
{
    [Fact]
    public void ReturnArea()
    {
        var triangle = new Triangle(12, 12, 12);
        
        var area = triangle.GetArea();
        
        Assert.True(area == 62.353829072479584);
    }
}