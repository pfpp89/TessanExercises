using System;
using System.Collections.Generic;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = new int[] { 1, 1, 2, 3, 5, 6, 12, 13, 15, 15, 16, 18, 20, 27 };

            int targetValue = 8;

            bool canGetValue = checkForPairsThatSumUpTo(inputArray, targetValue);

            Console.WriteLine("A sum of two elements that adds up to {0} {1} be obtained.",
                targetValue,
                canGetValue ? "can" : "cannot");
        }

        /// <summary>
        /// This method will return true if the input array cntains at least
        /// a pair of elements that adds up to the value supplied.
        /// </summary>
        /// <param name="inputArray">The array of integers where the check
        /// will be performed.</param>
        /// <param name="targetValue">The sum value we want to obtain.</param>
        /// <returns>True if the sum of two array elements adds up to the
        /// integer supplied, false otherwise.</returns>
        private static bool checkForPairsThatSumUpTo(int[] inputArray, int targetValue)
        {
            // Check for validity:
            if (inputArray==null)
            {
                return false;
            }

            // Create an hashset to store the differences:
            HashSet<int> hs = new HashSet<int>();

            // Cycle through elements of input array:
            for (int i = 0; i < inputArray.Length; i++)
            {
                // Calculate the difference:
                int temporaryValue = targetValue - inputArray[i];

                if (hs.Contains(temporaryValue))
                {
                    // A sum has been found, no need to continue:
                    return true;
                }

                hs.Add(inputArray[i]);
            }

            // Arriving here, no valid sum has been found:
            return false;
        }
    }
}
