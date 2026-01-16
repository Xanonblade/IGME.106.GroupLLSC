
//I am groot

// Lucas Kishore
// Lucas wrote this comment

namespace GroupVersionControl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            // Problem #5 Longest Duplicate Substring
            int[] arr1 = new int[] { 2, 2, 4, 10, 10, 10, 10, 4, 2, 2, 2, 4 };
            int[] arr2 = new int[] { 5, 2, 4, 4, 6, 6, 6, 7, 7, 7, 1, 2 };

            int result1 = LongestDuplicateSubstring(arr1);
            int result2 = LongestDuplicateSubstring(arr2);

            Console.WriteLine(result1);
            Console.WriteLine(result2);
        }

        /// <summary>
        /// Returns the number with the longest consecutive duplicate substring in the array.
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int LongestDuplicateSubstring(int[] arr)
        {


            // Count number of duplicates and the duplicate with the highest count
            int currentDuplicateCount = 0;
            int highestDuplicateCount = 0;
            int duplicatedElement = 0 ;

            // Look through the array to check for duplicates
            for (int i = 0; i < arr.Length - 2; i++)
            {

                // Compare current element with the next one
                if (arr[i] == arr[i + 1])
                {
                    // Increment duplicate count
                    currentDuplicateCount++;
                }
                else
                {
                    // Check if current duplicate count is higher than highest duplicate count
                    if (currentDuplicateCount > highestDuplicateCount)
                    {
                        // Gives most recent duplicate
                        // Code

                        // Update highest duplicate count
                        highestDuplicateCount = currentDuplicateCount + 1;
                        duplicatedElement = arr[i - 1];
                    }
                    // Reset current duplicate count
                    currentDuplicateCount = 0;
                }
            }

            // Fix later
            return duplicatedElement;
        }
    }
}
