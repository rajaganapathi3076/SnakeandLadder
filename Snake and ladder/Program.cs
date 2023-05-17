using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_and_ladder
{
    internal class Program
    {
        static void Main()
        {
            int playerPosition = 0;

            while (playerPosition < 100)
            { 
                Console.WriteLine("Welcome to snake and ladder UC4");

               
                Console.WriteLine("Press Enter to roll the dice...");
                Console.ReadLine();

                Random random = new Random();
                int diceRoll = random.Next(1, 7); // Generate a random number between 1 and 6

                Console.WriteLine($"You rolled a {diceRoll}");

                if (playerPosition + diceRoll <= 100)
                {
                    playerPosition += diceRoll;
                    Console.WriteLine($"You are now at position {playerPosition}");
                }
                else
                {
                    Console.WriteLine("Oops! You need to roll a smaller number to reach 100.");
                }

                // Check for special positions like Ladder or Snake
                playerPosition = CheckSpecialPositions(playerPosition);
            }

            Console.WriteLine("Congratulations! You reached the winning position of 100!");
        }

        static int CheckSpecialPositions(int position)
        {
            switch (position)
            {
                case 3:
                    Console.WriteLine("You encountered a ladder! Moving to position 22.");
                    return 22;
                case 8:
                    Console.WriteLine("You encountered a ladder! Moving to position 26.");
                    return 26;
                case 11:
                    Console.WriteLine("You encountered a ladder! Moving to position 40.");
                    return 40;
                case 20:
                    Console.WriteLine("You encountered a ladder! Moving to position 29.");
                    return 29;
                case 17:
                    Console.WriteLine("Oops! You encountered a snake! Moving back to position 4.");
                    return 4;
                case 19:
                    Console.WriteLine("Oops! You encountered a snake! Moving back to position 7.");
                    return 7;
                case 27:
                    Console.WriteLine("Oops! You encountered a snake! Moving back to position 1.");
                    return 1;
                case 56:
                    Console.WriteLine("Oops! You encountered a snake! Moving back to position 8.");
                    return 8;
                case 52:
                    Console.WriteLine("Oops! You encountered a snake! Moving back to position 1.");
                    return 1;
                case 61:
                    Console.WriteLine("You encountered a ladder! Moving to position 78.");
                    return 78;
                case 75:
                    Console.WriteLine("Oops! You encountered a snake! Moving back to position 28.");
                    return 28;
                case 88:
                    Console.WriteLine("You encountered a ladder! Moving to position 92.");
                    return 92;
                case 99:
                    Console.WriteLine("Oops! You encountered a snake! Moving back to position 80.");
                    return 80;
                default:
                    return position;
            }
        }
    }
}
