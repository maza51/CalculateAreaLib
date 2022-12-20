using Xunit;

namespace CalculateAreaLib.Tests;

public class CircleTest
{
    [Fact]
    public void ReturnArea()
    {
        var circle = new Circle(200);
        
        var area = circle.GetArea();
        
        Assert.True(area == 125663.70614359173);
    }
}