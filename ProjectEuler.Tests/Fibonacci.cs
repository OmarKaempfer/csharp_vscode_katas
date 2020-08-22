using NUnit.Framework;
using FluentAssertions;

namespace ProjectEuler.Tests
{
    public class Fibonacci
    {
        [Test]
        public void TestUpTo10()
        {
            ProjectEuler.Fibonacci.GetSequenceUpTo(10).Should().Equal(new int[]{0, 1, 1, 2, 3, 5, 8});
        }

        [Test]
        public void TestUpTo1()
        {
            ProjectEuler.Fibonacci.GetSequenceUpTo(1).Should().Equal(new int[]{0, 1, 1});
        }
        
        [Test]
        public void TestUpTo0()
        {
            ProjectEuler.Fibonacci.GetSequenceUpTo(0).Should().Equal(new int[]{0});
        }

        [Test]
        public void TestUpToNegative()
        {
            ProjectEuler.Fibonacci.GetSequenceUpTo(-1).Should().BeEmpty();
        }

        [Test]
        public void TestSumOfEvenNumbersUpTo0()
        {
            ProjectEuler.Fibonacci.SumOfEvenNumbersUpTo(0).Should().Be(0);
        }

        [Test]
        public void TestSumOfEvenNumbersUpTo10()
        {
            ProjectEuler.Fibonacci.SumOfEvenNumbersUpTo(10).Should().Be(10);
        }

        [Test]
        public void TestSumOfEvenNumbersUpTo100()
        {
            ProjectEuler.Fibonacci.SumOfEvenNumbersUpTo(100).Should().Be(44);
        }

        [Test]
        public void TestSumOfEvenNumbersUpTo1000()
        {
            ProjectEuler.Fibonacci.SumOfEvenNumbersUpTo(1000).Should().Be(798);
        }
    }
}
