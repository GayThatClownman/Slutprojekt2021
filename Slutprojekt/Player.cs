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

        public string job { get; set; }

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
        // Denna metod fungerar most likely inte för jag kan
        // inte komma hur jag ska separera det olika Players i genereringen.
        public List<Player> GeneratePlayers()
        {
            string pAmountString;
            int pAmountInt;

            pAmountString = Console.ReadLine();
            bool success = int.TryParse(pAmountString, out pAmountInt);

            List<Player> playerList = new List<Player>();

            if (success == true)
            {

                for (int x = 0; x < pAmountInt; x++)
                {

                    playerList.Add(new Player() { name = "Player" + x });


                }

            }

            // Console.ReadLine();

            return playerList;
        }

    }
}
