using System;
using System.Collections.Generic;

namespace ProjectEuler {
    public class PrimeFactors
    {

        public static long[] GetPrimeFactorsOf(long number)
        {
            if(number < 2)
            {
                return new long[]{};
            }

            List<long> primeFactors = new List<long>();
            while(IsEven(number)) {
                
                number /= 2;
                primeFactors.Add(2);
            }

            for(int i = 3; i < Math.Sqrt(number); i += 2)
            {
                if(number % i == 0)
                {
                    number /= i;
                    primeFactors.Add(i);
                }
            }

            if(number != 1)
            {
                primeFactors.Add(number);
            }

            return primeFactors.ToArray();
        }

        public static long GetLargestPrimeFactorOf(long number)
        {
            GetPrimeFactorsOf(number);

            long largestPrimeFactor = 0;
            foreach (long primeFactor in GetPrimeFactorsOf(number))
            {
                if(primeFactor > largestPrimeFactor)
                {
                    largestPrimeFactor = primeFactor;
                }
            }

            return largestPrimeFactor;
        }

        public static bool IsEven(long number)
        {
            return number % 2 == 0;
        }
    }
}