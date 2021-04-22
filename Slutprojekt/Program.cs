using System;
using System.Collections.Generic;

namespace Slutprojekt
{
    class Program
    {
        static void Main(string[] args)
        {
            // The Game of Life / Något brädspel.

            bool endState = false;
            bool gameRunning = false;
            List<Player> playerList = new List<Player>(); 
            
            while (endState != true)
            {

                Board board = new Board();
                

                System.Console.WriteLine("Welcome to The Game of Life!");
                System.Console.WriteLine("How many players will be playing?");
                
                Console.ReadLine();

                while (gameRunning == true)
                {

                    board.OutputBoard();
                    Console.ReadLine();

                }

            }

        }
    }
}
