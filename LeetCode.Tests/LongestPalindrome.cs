using System.Net.Mime;
using NUnit.Framework;
using FluentAssertions;

namespace LeetCode.Tests
{
    public class LongestPalindrome
    {
        [TestCase("", "")]
        [TestCase("a", "a")]
        [TestCase("aa", "aa")]
        [TestCase("abba", "abba")]
        [TestCase("alspabbazxcblliu", "abba")]
        [TestCase("abcdefg", "a")]
        public void Of(string text, string longestPalindrome)
        {
            LeetCode.LongestPalindrome.Of(text).Should().Be(longestPalindrome);
        }

        [TestCase("", 0, -1, true)]
        [TestCase("a", 0, 0, true)]
        [TestCase("aa", 0, 1, true)]
        [TestCase("abba", 0, 3, true)]
        [TestCase("aba", 0, 2, true)]
        [TestCase("ab", 0, 1, false)]
        [TestCase("asdfg", 0, 4, false)]
        [TestCase("cabas", 1, 3, true)]
        [TestCase("cabasdc", 1, 3, true)]
        [TestCase("cabbasdc", 1, 4, true)]
        [TestCase("vcabbasdc", 2, 5, true)]
        public void IsPalindrome(string text, int left, int right, bool expected)
        {
            LeetCode.LongestPalindrome.IsPalindrome(text, left, right).Should().Be(expected);
        }
    }
}