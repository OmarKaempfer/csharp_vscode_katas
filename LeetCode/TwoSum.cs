using System;
using System.Collections;

namespace LeetCode
{
    /// <summary>
    /// Given an array of integers, return indices of the two numbers such that they add up to a specific target.
    /// </summary>
    public class TwoSum
    {
        static void Main(string[] args)
        {
        }
        /// <summary>
        /// We iterate over all the other numbers for each element
        /// Time: O(n^2)
        /// Space: O(1)
        /// </summary>
        /// <param name="numbers"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int[] BruteForceFind(int[] numbers, int target)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length && j != i; j++)
                {
                    if(numbers[i] + numbers[j] == target)
                    {
                        return new int[]{i, j};
                    }
                }
            }

            return new int[]{};
        }

        /// <summary>
        /// Improves the time of the complement lookup step by building a
        /// hashtable with the numbers
        /// Time: O(n)
        /// Space: O(n)
        /// </summary>
        /// <param name="numbers"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int[] HashTableFind(int[] numbers, int target)
        {
            Hashtable numbersToIndexes = new Hashtable();

            for (int i = 0; i < numbers.Length; i++)
            {
                int complement = target - numbers[i];
                if(numbersToIndexes.ContainsKey(complement))
                {
                    return new int[]{(int)numbersToIndexes[complement], i};
                }

                numbersToIndexes[numbers[i]] = i;
            }

            return new int[]{};
        }
    }
}
