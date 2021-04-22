using System;

namespace Slutprojekt
{
    public class Board
    {
        // Baserat på Mickes C#-Referens

        public int [,] board;

        public Board()
        {

            board = new int[10,15];
        
        }

        public void OutputBoard()
        {
            for (int x = 0; x < board.GetLength(0); x++)
            {
                for (int y = 0; y < board.GetLength(1); y++)
                {
                    System.Console.Write(board[x,y]);
                }
                
                System.Console.WriteLine();

            }
        }
    }
}
