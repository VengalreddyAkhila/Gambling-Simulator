
using System;

namespace Gambling_Simulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to Gambling_Simulator_Game");
            Gambler gambler = new Gambler();
            gambler.gamblerstake();
            gambler.Win_Loss();
        }
    }
}
