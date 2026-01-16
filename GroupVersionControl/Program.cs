
//I am groot - Laurin Zanon

// Lucas Kishore
// Lucas wrote this comment

namespace GroupVersionControl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Problem #1: Dice Sum
            DiceSum();

            // Test LongestSortedSequence
            Console.WriteLine(LongestSortedSequence(new int[] { 3, 8, 10, 1, 9, 14, -3, 0, 14, 207, 56, 98 }));
            Console.WriteLine(LongestSortedSequence(new int[] { 17, 42, 3, 5, 5, 5, 8, 2, 4, 6, 1, 19 }));

            //Palindrome
            string[] words = { "racecar", "happy birthday", "tacocat", "programming" };
            for (int i = 0; i < words.Length; i++)
            {
                if (IsPalindrome(words[i]))
                {
                    Console.WriteLine($"{words[i]} is a palindrome!");
                }
                else
                {
                    Console.WriteLine($"{words[i]} is not a palindrome!");
                }
            }
        }

        /// <summary>
        /// Rolls 2d6 until user given sum is reached
        /// </summary>
        public static void DiceSum()
        {
            Random rng = new Random();

            //Loop for valid sum
            int sum = 0;
            while (sum < 2 || sum > 12)
            {
                Console.Write($"Desired dice sum: ");
                sum = int.Parse(Console.ReadLine()!);
                if (sum > 2 && sum < 12)
                {
                    //Valid
                    break;
                }
                else
                {
                    sum = 0;
                    Console.WriteLine("Invalid sum.\n");
                }
            }

            //Rolling for desired sum
            int rand1 = 0;
            int rand2 = 0;
            while ((rand1 + rand2) != sum)
            {
                rand1 = rng.Next(1, 7);
                rand2 = rng.Next(1, 7);
                Console.WriteLine($"{rand1} + {rand2} = {rand1 + rand2}");
            }
        }


        /// <summary>
        /// Checks if a string is a palindrome
        /// </summary>
        /// <param name="sequence"></param>
        /// <returns> Returns true if a string is a palindrome and false otherwise</returns>
        public static bool IsPalindrome(string sequence)
        {
            string reversed = "";
            sequence = sequence.ToLower();
            for (int i = sequence.Length - 1; i >= 0; i--)
            {
                reversed += sequence[i];
            }

            return reversed == sequence;
        }

        /// <summary>
        /// Finds the longest sequence of increasing numbers in an array.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        private static int LongestSortedSequence(int[] nums)
        {
            if (nums.Length == 0)
                return 0;

            int count = 1;
            int longestCount = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                // increase count
                if (nums[i] > nums[i - 1])
                {
                    count++;
                }
                // increase longest count and reset count
                else {
                    if (count > longestCount)
                    {
                        longestCount = count;
                    }
                    count = 1;
                }
            }

            return longestCount;
        }
    }
}
