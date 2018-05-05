using System;
using System.Threading;
using BrawlingBuddies.Enum;
using BrawlingBuddies.Equipment;

namespace BrawlingBuddies
{
    class EntryPoint
    {
        static Random rng = new Random();

        static void Main()
        {
            string playeronename;
            string playertwoname;
            Console.WriteLine("Welcome to Brawling Buddies! What is your name, player one?");
            playeronename = Console.ReadLine();
            Console.WriteLine("What is your name, player two?");
            playertwoname = Console.ReadLine();
            Console.WriteLine("Good luck " + playeronename + " and " + playertwoname + "!");
            Console.WriteLine();

            Fighter playerone = new Fighter(playeronename, Faction.PlayerOne);
            Fighter playertwo = new Fighter(playertwoname, Faction.PlayerTwo);

            while (playerone.IsAlive && playertwo.IsAlive)
            {
                if (rng.Next(0, 100) < 50)
                {
                    playerone.Attack(playertwo);
                }
                else
                {
                    playertwo.Attack(playerone);
                }

                Thread.Sleep(100);
            }
        }
    }

}
