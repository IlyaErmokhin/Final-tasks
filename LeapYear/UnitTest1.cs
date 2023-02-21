namespace LeapYear.Tests;

public class Tests
{
    [Test]
    [TestCase(2000)] // multiple of 400
    [TestCase(1004)] // multiple of 4 but not 100
    public void YearIsLeapReturnsTrue(int value)
    {
        var result = LeapYear.IsLeapYear(value);
        
        Assert.That(DateTime.IsLeapYear(value), Is.EqualTo(result));
    }

    [Test]
    [TestCase(2001)] // not multiple of 4
    [TestCase(1900)] // multiple of 100 but not 400
    public void YearIsNotLeapReturnsFalse(int value)
    {
        var result = LeapYear.IsLeapYear(value);
        
        Assert.That(DateTime.IsLeapYear(value), Is.EqualTo(result));
    }
}