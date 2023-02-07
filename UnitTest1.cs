namespace PrimeNumber.Test
{
    public class Tests
    {
        [TestCase(37)]
        [TestCase(199)]
        [TestCase(601)]
        [TestCase(911)]
        public void NumberPrimeTrue(int n)
        {
            Assert.True(isPrimeNumber.PrimeNumb(n));
        }

        [TestCase(8)]
        [TestCase(44)]
        [TestCase(512)]
        [TestCase(888)]
        public void NumberPrimeNoTrue(int n)
        {
            Assert.False(isPrimeNumber.PrimeNumb(n));

        }
    }
}