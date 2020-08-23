using NUnit.Framework;
using FluentAssertions;

namespace LeetCode.Tests
{
    public class LongestSubstringWithNoRepeatingCharacters
    {
        [TestCase("", 0)]
        [TestCase("a", 1)]
        [TestCase("asd", 3)]
        [TestCase("asdasd", 3)]
        [TestCase("aaaaa", 1)]
        [TestCase("aab", 2)]
        public void GetLength(string text, int expected)
        {
            LeetCode.LongestSubstringWithNoRepeatingCharacters.GetLength(text).Should().Be(expected);
        }
    }
}