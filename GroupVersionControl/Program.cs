
//I am groot

// Lucas Kishore
// Lucas wrote this comment

namespace GroupVersionControl
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
    }
}
