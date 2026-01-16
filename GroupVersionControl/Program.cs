
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
                if (sum >2 && sum < 12)
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
    }
}
