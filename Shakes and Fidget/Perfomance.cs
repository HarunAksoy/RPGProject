using System;
using System.Diagnostics;
using System.Media;

namespace Shakes_and_Fidget
{
    public class Performance
    {
        public static int gold = 50;
        public static int experience = 0;
        public static int energy = 0;
        public static int questEnergy = 100;


        public static void checkEnergy()
        {
            SoundPlayer myPlayer = new SoundPlayer(@"C:\Users\vmadmin\RiderProjects\RPGProject\theme\theme.wav");

            if (energy < Home.fullEnergy)

            {
                Console.WriteLine("You need Energy to do a quest!");
            }
            
            else if(Level.level == 1 || Level.level == 2)
            {
                energy -= questEnergy;

                myPlayer.Play();
                Stopwatch.Timer();
            }

            else if (Level.level == 3)
            {
                energy -= questEnergy;
                Console.Clear();
                Endboss.startGame();
            }
            
            else
            {
                
                Console.WriteLine("To be continued!");
            }
            
        }


        public static void checkGold()
        {
            if (gold < 50)
            {
                Console.WriteLine("You dont have enough gold!");
            }
            else
            {
                gold -= 50;
                energy += 100;
                Console.Clear();
                Home.printMenuHome();
            }
        }
    }
}