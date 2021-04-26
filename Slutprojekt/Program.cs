using System;
using System.Collections.Generic;

namespace Slutprojekt
{
    class Program
    {
        static void Main(string[] args)
        {
            // The Game of Life.

            UIText ui = new UIText();

            bool endState = false;
            bool gameRunning = false;
            List<Player> playerList = new List<Player>(); 
            
            while (endState != true)
            {

                Board board = new Board();
                
                ui.IntroText();                                
                

                ui.GameRules();
                
                gameRunning = true;
                while (gameRunning == true)
                {

                    board.OutputBoard();
                    Console.ReadLine();

                }

            }

        }
    }
}
