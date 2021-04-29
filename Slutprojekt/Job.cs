using System;

namespace Slutprojekt
{
    public class Job
    {
        public Random generator = new Random();

        public string name { get; set; }
        
        public int salary { get; set; }

        public int tax { get; set; }

    }
}
