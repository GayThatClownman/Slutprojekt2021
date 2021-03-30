using System;

namespace Slutprojekt
{
    public class Player
    {
        static Random generator = new Random();
        
        public int money;
        
        public int attributes;
        
        public int score;

        public string job;
        
        private bool hasFinished = false;
        
        public Player()
        {

            money = 200;

        }

    }
}
