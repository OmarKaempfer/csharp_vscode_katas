using System.Linq;
using System;
using NUnit.Framework;
using FluentAssertions;
using static LeetCode.AddTwoNumbers;

namespace LeetCode.Tests {
    
    public class AddTwoNumbers {

        [TestCase(4, 4, 8)]
        [TestCase(4, 10, 14)]
        [TestCase(10, 4, 14)]
        [TestCase(14, 10, 24)]
        [TestCase(0, 0, 0)]
        public void Add(int firstAddend, int secondAddend, int result)
        {
            ListNode firstAddendNode = ToDigitsLinkedList(firstAddend);
            ListNode secondAddendNode = ToDigitsLinkedList(secondAddend);

            ParseNumber(LeetCode.AddTwoNumbers.AddSmallNumbers(firstAddendNode, secondAddendNode)).Should().Be(result);
        }

        [Test]
        public void MultipleDigitsNodes()
        {
            ListNode firstAddend = new ListNode(1, new ListNode(12, new ListNode(120)));
            ListNode secondAddend = new ListNode(10, new ListNode(8, new ListNode(20)));
            ParseNumber(LeetCode.AddTwoNumbers.AddSmallNumbers(firstAddend, secondAddend)).Should().Be(14211);
        }

        [TestCase(4, 4, 8)]
        [TestCase(4, 10, 14)]
        [TestCase(10, 4, 14)]
        [TestCase(14, 10, 24)]
        [TestCase(0, 0, 0)]
        [TestCase(342, 465, 807)]
        public void AddBigNumbers(int firstAddend, int secondAddend, int result)
        {
            ListNode firstAddendNode = ToDigitsLinkedList(firstAddend);
            ListNode secondAddendNode = ToDigitsLinkedList(secondAddend);

            ParseNumber(LeetCode.AddTwoNumbers.AddBigNumbers(firstAddendNode, secondAddendNode)).Should().Be(result);
        }
    }
}