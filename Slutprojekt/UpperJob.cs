using System.Collections.Generic;
using System;

namespace Slutprojekt
{
    public class UpperJob : Job
    {
        
        public List<string> jobNames = new List<string>(); 

        public UpperJob()
        {

            salary = generator.Next(80,100);

            tax = generator.Next(50, 70);
            

        }

    }
}
