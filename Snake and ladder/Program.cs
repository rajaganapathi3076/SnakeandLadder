using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_and_ladder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to snake and ladder UC3");
            Console.WriteLine("Press anything to start");
            Console.ReadLine();

            int Pl1_position = 0; // player's starting position
            int Pl1_numberOfRolls = 0; // number of times the dice was rolled
            Random random = new Random();

            int Pl1_diceRoll = random.Next(1, 7);
            Pl1_numberOfRolls++;

            Console.WriteLine("Dice for Player 1 Rolled: " + Pl1_diceRoll);

            int Pl1_option = random.Next(0, 3);
            switch (Pl1_option)
            {
                case 0: // No Play
                    Console.WriteLine("No Play");
                    break;
                case 1: // Ladder
                    Pl1_position += Pl1_diceRoll;
                    Console.WriteLine("Ladder!");
                    break;
                case 2: // Snake
                    Pl1_position -= Pl1_diceRoll;
                    Console.WriteLine("Snake!!");
                    break;
            }

            Console.WriteLine("The position for Player 1 is : " + Pl1_position);

        }
    }
}
