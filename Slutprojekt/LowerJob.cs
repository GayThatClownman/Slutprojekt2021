using System;
using System.Collections.Generic;

namespace Slutprojekt
{
    public class LowerJob : Job
    {

        public List<string> jobNames = new List<string>() {"BattleEye Developer", "Dart Monkey", "Filler"};

        public LowerJob()
        {

            salary = generator.Next(30, 50);

            tax = generator.Next(15, 25);
            

        }


    }
}
