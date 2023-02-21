namespace APIAC.Tests;

public class Tests
{
    [Test]
    [TestCase(0, -1)]
    [TestCase(0, 1)]
    [TestCase(2, -1)]
    [TestCase(0, -3)]
    [TestCase(-2, -1)]
    public void PointInsideCircleReturnsTrue(double x, double y)
    {
        Assert.IsTrue(APIAC.InsideCircle(x, y));
    }

    [Test]
    [TestCase(2, 2)]
    [TestCase(2, -3)]
    [TestCase(-4, -2)]
    [TestCase(-3, 2)]
    public void PointOutsideCircleReturnsFalse(double x, double y)
    {
        Assert.IsFalse(APIAC.InsideCircle(x, y));
    }
}