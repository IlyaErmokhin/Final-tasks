namespace SortedArrStr.Tests;

public class Tests
{
    [Test]
    public void Sort_IsCorrect()
    {
        var arr = new string[] { "c", "a", "b", "ba", "aa", "ac", "aa", "aa"};
        var sortedArray = new string[] { "a", "aa", "aa", "aa", "ac", "b", "ba", "c" };

        SortArrStr.Sort(arr);
        
        Assert.That(arr, Is.EqualTo(sortedArray));
    }
}