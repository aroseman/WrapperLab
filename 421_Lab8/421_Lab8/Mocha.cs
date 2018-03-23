using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _421_Lab8
{
    class Mocha : Coffee
    {
        /// <summary>
        /// Makes a Mocha Coffee
        /// 1. Indicate the machine as running and display the purchased type of coffee to LED. 
        /// 2. Grind coffee beans for 8 seconds.
        /// 3. Heat up the water to 150 degree F.
        /// 4. Indicate the machine is not running to the LED.
        /// </summary>
        /// <param name="cmm"></param>
        public void run(CMM cmm)
        {
            cmm.LEDNumber = 13;
            cmm.GrindingTime = 8;
            cmm.Temperature = 200;
            cmm.AddCondiment()
        }
    }
}
