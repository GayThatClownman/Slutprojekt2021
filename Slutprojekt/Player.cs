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
            
            x = 1;
            y = 1;

            hasFinished = false;

        }

        public int CalcScore()
        {

            score = money + (attributes * 20);

            return score;
            
        }

    }
}
