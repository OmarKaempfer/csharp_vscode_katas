using System;
using System.Collections;
namespace LeetCode
{
    public class LongestSubstringWithNoRepeatingCharacters
    {
        public static int GetLength(string text)
        {
            Hashtable currentSequenceChars = new Hashtable();
            int currentLongest = 0;
            int currentCount = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if(currentSequenceChars.Contains(text[i]))
                {
                    if(currentCount > currentLongest)
                    {
                        currentLongest = currentCount;
                    }
                    currentCount = 0;
                    i = (int)currentSequenceChars[text[i]] + 1;
                    currentSequenceChars = new Hashtable();
                }

                currentSequenceChars.Add(text[i], i);
                currentCount++;
            }

            return Math.Max(currentCount, currentLongest);
        }
    }
}