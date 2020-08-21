using System.Linq;
using NUnit.Framework;
using FluentAssertions;

namespace Katas.Tests
{
    public class MultiplesOf3Or5
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestZeroUpperLimit()
        {
            Katas.MultiplesOf3Or5.Find(0).Should().BeEmpty();
        }

        [Test]
        public void TestThousandUpperLimit()
        {
            int sumOfMultiplesOf3 = FindSumOfMultiplesOf(3, 1000);
            int sumOfMultiplesOf5 = FindSumOfMultiplesOf(5, 1000);
            int sumOfMultiplesOf15 = FindSumOfMultiplesOf(15, 1000);

            int sumOfMultiplesOf3Or5 = sumOfMultiplesOf3 + sumOfMultiplesOf5 - sumOfMultiplesOf15;
            Katas.MultiplesOf3Or5.Find(1000).Distinct().Aggregate((x, y) => x + y).Should().Be(sumOfMultiplesOf3Or5);
            Katas.MultiplesOf3Or5.Find(1000).Count().Should().Be(FindCountOfMultiplesOf(5, 1000) 
                                                                + FindCountOfMultiplesOf(3, 1000)  
                                                                - FindCountOfMultiplesOf(15, 1000));
        }

        private int FindSumOfMultiplesOf(int number, int upperLimit)
        {
            int n = FindCountOfMultiplesOf(number, upperLimit);
            return number * (n * (n + 1) / 2);
        }

        private int FindCountOfMultiplesOf(int number, int upperLimit)
        {
            return (upperLimit - 1) / number;
        }
    }
}