﻿using System;
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
           
            Console.WriteLine("Welcome to snake and ladder UC5");

            
            int[] board = new int[101];
           
            for (int i = 1; i < board.Length; i++)
            {
                board[i] = 0;
            }
            
            board[3] = 22;
            board[5] = 8;
            board[11] = 26;
            board[20] = 29;
            board[17] = 4;
            board[19] = 7;
            board[27] = 1;
            board[21] = 9;
            board[70] = 33;
            board[77] = 34;
            board[95] = 42;
            board[88] = 24;
            board[92] = 72;

          
            int player1Position = 0;
            int player2Position = 0;

            
            int currentPlayer = 1;

            
            int numDiceRolls = 0;

            
            while (player1Position != 100 && player2Position != 100)
            {
                
                Random random = new Random();
                int diceRoll = random.Next(1, 7);

                
                if (currentPlayer == 1)
                {
                    if (player1Position + diceRoll <= 100)
                    {
                        player1Position += diceRoll;
                    }

                   
                    if (board[player1Position] != 0)
                    {
                        Console.WriteLine("Player 1 climbed a ladder!");
                        player1Position = board[player1Position];
                    }
                }
                else
                {
                    if (player2Position + diceRoll <= 100)
                    {
                        player2Position += diceRoll;
                    }

                    if (board[player2Position] != 0)
                    {
                        Console.WriteLine("Player 2 climbed a ladder!");
                        player2Position = board[player2Position];
                    }
                }

               
                Console.WriteLine("Player 1 position: " + player1Position);
                Console.WriteLine("Player 2 position: " + player2Position);
                Console.WriteLine();

                
                numDiceRolls++;

               
                currentPlayer = currentPlayer == 1 ? 2 : 1;
            }

           
            if (player1Position == 100)
            {
                Console.WriteLine("Player 1 wins!");
            }
            else
            {
                Console.WriteLine("Player 2 wins!");
            }

            Console.WriteLine("Game Over!");
            Console.WriteLine("Number of dice rolls: " + numDiceRolls);
        }
    }
    
}
