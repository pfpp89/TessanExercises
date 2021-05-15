using System;

namespace Exercise1
{
    class Program
    {
        // Call function for the case supplied:
        public static void Main()
        {
            int sumValue = 26;
            int[] possibilities = { 1, 2 };
            
            // Print the result to the console:
            Console.Write("Result: " + countNumberOfPossibilities(possibilities, sumValue));
        }

        static int countNumberOfPossibilities(int[] possibleValues, int maximumCount)
        {
            if (maximumCount < 1 || possibleValues == null || possibleValues.Length < 1)
            {
                // Protect against:
                // > Requested maximum count being inferior to 0;
                // > Null array of values supplied;
                // > Empty array of values supplied.
                return -1;
            }

            int[] countPerPossibleResult = new int[maximumCount + 1];

            // base case
            countPerPossibleResult[0] = 1;

            // On the outer cycle, count until the desired value:
            for (int i = 1; i <= maximumCount; i++)
            {
                // The inner cycle goes through the possible elements:
                for (int j = 0; j < possibleValues.Length; j++)
                {
                    if (i >= possibleValues[j])
                    {
                        countPerPossibleResult[i] = countPerPossibleResult[i] + countPerPossibleResult[i - possibleValues[j]];
                    }
                }
            }

            // Return the number of ways to sum up to the value supplied:
            return countPerPossibleResult[maximumCount];
        }
    }
}
