using FluentAssertions;
using NUnit.Framework;

namespace ProjectEuler.Tests
{
    public class PrimeFactors
    {
        [TestCase(0, new long[]{})]
        [TestCase(1, new long[]{})]
        [TestCase(2, new long[]{2})]
        [TestCase(3, new long[]{3})]
        [TestCase(4, new long[]{2, 2})]
        [TestCase(5, new long[]{5})]
        [TestCase(13195, new long[]{5, 7, 13, 29})]
        public void GetPrimeFactors(long number, long[] primeFactors)
        {
            ProjectEuler.PrimeFactors.GetPrimeFactorsOf(number).Should().Equal(primeFactors);
        }

        [TestCase(0, 0)]
        [TestCase(1, 0)]
        [TestCase(2, 2)]
        [TestCase(2, 2)]
        [TestCase(3, 3)]
        [TestCase(4, 2)]
        [TestCase(13195, 29)]
        public void GetLargestPrimeFactor(int number, int largestPrimeFactor)
        {
            ProjectEuler.PrimeFactors.GetLargestPrimeFactorOf(number).Should().Be(largestPrimeFactor);
        }
    }
}