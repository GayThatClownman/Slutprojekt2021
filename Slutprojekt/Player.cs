using System.Collections.Generic;
using System;

namespace Slutprojekt
{
    public class Player
    {
        static Random generator = new Random();

        public int x { get; set; }

        public int y { get; set; }

        public string name { get; set; }

        public int money { get; set; }

        public int attributes { get; set; }

        public int score { get; set; }

        public bool hasGraduated { get; set; }


        // public string job { get; set; }

        private bool hasFinished;

        public Player()
        {

            money = 200;

            x = 0;
            y = 0;

            hasFinished = false;

        }

        public int AddMoney(int n)
        {



            return money;
        }

        public int CalcScore()
        {

            score = money + (attributes * 20);

            return score;

        }

        public void OutputPlayerInfo()
        {

        }


        // Honestly ingen aning hur väl det här fungerar men whatever
        // Den är här nu
        // Okej nevermind den verkar typ fungera ändå

        // Metod som genererar en uppsättning av spelare och lägger in de i en List.
        // Metoden tar emot ett tal, kör den igenom en TryParse och om den lyckas, skapar så många spelare.
        public List<Player> GeneratePlayers()
        {
            // bool generatePlayers = false;

            string pAmountString;
            int pAmountInt;

            pAmountString = Console.ReadLine();
            bool success = int.TryParse(pAmountString, out pAmountInt);

            List<Player> playerList = new List<Player>();

            // while (generatePlayers == false)
            // {

            if (success == true)
            {

                for (int x = 0; x < pAmountInt; x++)
                {

                    playerList.Add(new Player() { name = "Player" + x });


                }

                // generatePlayers = true;
            }

            else
            {
                System.Console.WriteLine("Not a valid input.");
            }

            // }
            // Console.ReadLine();

            return playerList;
        }

    }
}
