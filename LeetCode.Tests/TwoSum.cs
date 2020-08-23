using NUnit.Framework;
using FluentAssertions;

namespace LeetCode.Tests
{
    public class TwoSum
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(0, new int[]{}, new int[] {})]
        [TestCase(0, new int[]{0, 1}, new int[]{})]
        [TestCase(1, new int[]{0, 1}, new int[]{0, 1})]
        [TestCase(2, new int[]{0, 1, 2}, new int[]{0, 2})]
        [TestCase(3, new int[]{0, 1, 2}, new int[]{1, 2})]
        [TestCase(3, new int[]{0, 1, 2, 2}, new int[]{1, 2})]
        public void BruteForceFind(int target, int[] numbers, int[] result)
        {
            LeetCode.TwoSum.BruteForceFind(numbers, target).Should().Equal(result);
        }

        [TestCase(0, new int[]{}, new int[] {})]
        [TestCase(0, new int[]{0, 1}, new int[]{})]
        [TestCase(1, new int[]{0, 1}, new int[]{0, 1})]
        [TestCase(2, new int[]{0, 1, 2}, new int[]{0, 2})]
        [TestCase(3, new int[]{0, 1, 2}, new int[]{1, 2})]
        [TestCase(3, new int[]{0, 1, 2, 2}, new int[]{1, 2})]
        public void HashTableFind(int target, int[] numbers, int[] result)
        {
            LeetCode.TwoSum.HashTableFind(numbers, target).Should().Equal(result);
        }
    }
}