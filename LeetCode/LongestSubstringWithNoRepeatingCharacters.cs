using System;
using System.Collections.Generic;
namespace LeetCode
{
    public class LongestSubstringWithNoRepeatingCharacters
    {
        /// <summary>
        /// Sliding window approach visiting each char just 1 time
        /// Time: O(n)
        /// Space: O(min(m, n)) where 'n' is the size of the string and 'm' is the size of the alphabet
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static int GetLength(string text)
        {
            Dictionary<char, int> currentSequenceChars = new Dictionary<char, int>();
            int currentLongest = 0;
            int currentCount = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if(currentSequenceChars.ContainsKey(text[i]) && i - currentSequenceChars[text[i]] <= currentCount)
                {
                    currentLongest = Math.Max(currentLongest, currentCount);
                    currentCount = i - currentSequenceChars[text[i]] - 1;
                }

                currentSequenceChars[text[i]] = i;
                currentCount++;
            }

            return Math.Max(currentCount, currentLongest);
        }
    }
}