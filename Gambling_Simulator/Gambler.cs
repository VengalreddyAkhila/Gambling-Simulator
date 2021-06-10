using System;
using System.Collections.Generic;
using System.Text;

namespace Gambling_Simulator
{
    class Gambler
    {
       
         const int BET = 1;
         const int STAKE = 100;
        public void gamblerstake()
        {
            Console.WriteLine("stake" + STAKE + "bet" + BET);
            Random random = new Random();
            int stakeholder = random.Next(0, 2);
            
                if (stakeholder == 1)
                    Console.WriteLine("wins");
                else
                    Console.WriteLine("loss");
            

        }

        
           
    }
}
