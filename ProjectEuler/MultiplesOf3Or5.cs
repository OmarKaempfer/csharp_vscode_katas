﻿using System.Linq;
using System;

namespace ProjectEuler
{
    public class MultiplesOf3Or5
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine(PrimeFactors.GetLargestPrimeFactorOf(600851475143));
        }

        public static int[] Find(int upperLimit) {

            if(upperLimit <= 0)
            {
                return new int[]{};
            }
            
            return Enumerable.Range(1, upperLimit - 1)
                      .Where(x => x % 3 == 0 | x % 5 == 0)
                      .ToArray();
        }
    }
}
