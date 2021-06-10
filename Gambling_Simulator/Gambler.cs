using System;
using System.Collections.Generic;
using System.Text;

namespace Gambling_Simulator
{
    class Gambler
    {
       
        int bet = 1;
        int stake = 100;
        public void gamblerstake()
        {

            for (int i = 0; i <= stake; i++)
            {
                if (bet == 1)
                    Console.WriteLine("win");
                else
                    Console.WriteLine("loss");


            }
        }

        
           
    }
}
