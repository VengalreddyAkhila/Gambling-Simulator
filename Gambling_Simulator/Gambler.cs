using System;
using System.Collections.Generic;
using System.Text;

namespace Gambling_Simulator
{
    class Gambler
    {
       
         const int bet = 1;
         const int stake = 100;
        public void gamblerstake()
        {
            Console.WriteLine("stake" + stake + "bet" + bet);
            Random random = new Random();
            int stakeholder = random.Next(0, 2);

            for (int i = 0; i <= stake; i++)
            {
                if (stakeholder  == 1)
                    Console.WriteLine("wins");
                else
                    Console.WriteLine("loss");
            }
        }

        
           
    }
}
