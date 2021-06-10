using System;
using System.Collections.Generic;
using System.Text;

namespace Gambling_Simulator
{
    class Gambler
    {
       
         const int BET = 1;
         const int STAKE = 150;
         //int win = 1;
        

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
        public void Win_Loss()
        {
            int winningAmount = (STAKE + (STAKE / 2));
            int lossingAmount = (STAKE / 2);
            int stakeholder = STAKE;
            int win = 1;
            while(stakeholder < winningAmount && stakeholder > lossingAmount)
            {
                Random random = new Random();
                int check = random.Next(0, 2);
                if (check == win)
                {
                    stakeholder = stakeholder + BET;
                   // Console.WriteLine("stakeholder wins the bet" +stakeholder);
                }
                else
                {
                    stakeholder = stakeholder - BET;
                    Console.WriteLine("stakeholder resigns the bet" +stakeholder);
                }

            }
            Console.WriteLine(stakeholder);          



        }



    }
}
