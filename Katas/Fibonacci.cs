using System.Collections.Generic;
using System;

namespace Katas
{
    public class Fibonacci
    {
        public static int[] GetSequenceUpTo(int upperLimit)
        {
            List<int> fibonacciSeries = new List<int>();
            using(var fibonacciEnumerator = Katas.Fibonacci.GetSeries().GetEnumerator())
            {
                fibonacciEnumerator.MoveNext();
                while(fibonacciEnumerator.Current <= upperLimit)
                {
                    fibonacciSeries.Add(fibonacciEnumerator.Current);
                    fibonacciEnumerator.MoveNext();
                }
            }

            return fibonacciSeries.ToArray();
        }

        public static IEnumerable<int> GetSeries() {

            yield return 0;
            yield return 1;

            int previousFibonacciNumber = 0;
            int currentFibonacciNumber = 1;
            while(true) {
                currentFibonacciNumber = currentFibonacciNumber + previousFibonacciNumber;
                previousFibonacciNumber = currentFibonacciNumber - previousFibonacciNumber;
                yield return currentFibonacciNumber;
            }
        }

        public static int SumOfEvenNumbersUpTo(int upperLimit)
        {   
            int sum = 0;
            using(IEnumerator<int> fibonacciSeries = GetSeries().GetEnumerator())
            {
                fibonacciSeries.MoveNext();

                while(fibonacciSeries.Current <= upperLimit)
                {
                    if(fibonacciSeries.Current % 2 == 0)
                    {
                        sum += fibonacciSeries.Current;
                    }
                    fibonacciSeries.MoveNext();
                }
            }

            return sum;
        }
    }
}