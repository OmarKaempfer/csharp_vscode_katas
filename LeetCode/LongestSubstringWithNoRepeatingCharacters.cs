using System;
using System.Collections.Generic;
namespace LeetCode
{
    public class LongestSubstringWithNoRepeatingCharacters
    {
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