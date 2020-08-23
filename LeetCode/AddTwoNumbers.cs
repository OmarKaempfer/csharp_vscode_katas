using System;
using System.Linq;

namespace LeetCode
{
    public class AddTwoNumbers
    {

        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val=0, ListNode next=null) {
                this.val = val;
                this.next = next;
            }
        }

        /// <summary>
        /// Builds the result in one pass adding node by node
        /// Time: O(max(m,n))
        /// Space: O(max(m,n))
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// <returns></returns>
        public static ListNode AddBigNumbers(ListNode firstNumber, ListNode secondNumber)
        {
            int carry = 0;
            ListNode currentNode = new ListNode();
            ListNode previousNode = currentNode;
            ListNode head = currentNode;

            while(firstNumber != null || secondNumber != null || carry != 0)
            {
                int firstAddend = 0;
                if(firstNumber != null)
                {
                    firstAddend = firstNumber.val;
                    firstNumber = firstNumber.next;
                }

                int secondAddend = 0;
                if(secondNumber != null) 
                {
                    secondAddend = secondNumber.val;
                    secondNumber = secondNumber.next;
                }

                currentNode.val = (firstAddend + secondAddend + carry) % 10;
                carry = (secondAddend + firstAddend + carry) / 10;

                previousNode = currentNode;
                previousNode.next = new ListNode();
                currentNode = previousNode.next;
            }

            previousNode.next = null;
            return head;
        }

        /// <summary>
        /// Parses the two numbers contained in the linked lists, sum them and then
        /// builds a new linked list.
        /// 
        /// Has problems with really big numbers.
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// <returns></returns>
        public static ListNode AddSmallNumbers(ListNode firstNumber, ListNode secondNumber)
        {
            return ToDigitsLinkedList(ParseNumber(firstNumber) + ParseNumber(secondNumber));
        }

        public static int ParseNumber(ListNode lastDigit)
        {
            ListNode currentDigit = lastDigit;
            int number = 0;
            for(int i = 0; currentDigit != null; i++)
            {
                number += (int)Math.Pow(10, i) * currentDigit.val;
                currentDigit = currentDigit.next;
            }

            return number;
        }

        public static ListNode ToDigitsLinkedList(int number)
        {
            ListNode[] digits = number.ToString().ToArray()
                            .Select(digit => (int)Char.GetNumericValue(digit))
                            .Select(digit => new ListNode(digit))
                            .ToArray();

            for (int i = digits.Length - 1; i > 0; i--)
            {
                digits[i].next = digits[i - 1];
            }

            return digits[digits.Length - 1];
        }
    }
}