using NUnit.Framework;
using FluentAssertions;

namespace Katas.Tests
{
    public class Fibonacci
    {
        [Test]
        public void TestUpTo10()
        {
            Katas.Fibonacci.GetSequenceUpTo(10).Should().Equal(new int[]{0, 1, 1, 2, 3, 5, 8});
        }

        [Test]
        public void TestUpTo1()
        {
            Katas.Fibonacci.GetSequenceUpTo(1).Should().Equal(new int[]{0, 1, 1});
        }
        
        [Test]
        public void TestUpTo0()
        {
            Katas.Fibonacci.GetSequenceUpTo(0).Should().Equal(new int[]{0});
        }

        [Test]
        public void TestUpToNegative()
        {
            Katas.Fibonacci.GetSequenceUpTo(-1).Should().BeEmpty();
        }

        [Test]
        public void TestSumOfEvenNumbersUpTo0() {
            Katas.Fibonacci.SumOfEvenNumbersUpTo(0).Should().Be(0);
        }

        [Test]
        public void TestSumOfEvenNumbersUpTo10() {
            Katas.Fibonacci.SumOfEvenNumbersUpTo(10).Should().Be(10);
        }

        [Test]
        public void TestSumOfEvenNumbersUpTo100() {
            Katas.Fibonacci.SumOfEvenNumbersUpTo(100).Should().Be(44);
        }

        [Test]
        public void TestSumOfEvenNumbersUpTo1000() {
            Katas.Fibonacci.SumOfEvenNumbersUpTo(1000).Should().Be(798);
        }
    }
}
