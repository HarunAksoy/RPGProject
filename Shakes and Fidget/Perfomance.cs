using System;
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
                //Console.WriteLine("You need Energy to do a quest!");
                Console.Clear();
                Home.printMenuHome();
                Console.WriteLine(
                    "________________________________________________________________________________________________________________________");
                Console.WriteLine(">You don't have enough Energy to do a Quest!");
                Home.startHome();
            }

            else if (Level.level == 1 || Level.level == 2)
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
                Console.WriteLine(
                    "________________________________________________________________________________________________________________________");
                Console.WriteLine(">You don't have enough energy to do a quest!");
            }
        }

        public static void checkGold()
        {
            CharacterMethods methods = new CharacterMethods();
            
            if (gold < 50)
            {
                //Console.WriteLine("You dont have enough gold!");
                Console.Clear();
                Home.printMenuHome();
                Console.WriteLine(
                    "________________________________________________________________________________________________________________________");
                Console.WriteLine(">You don't have enough gold to refill your energy!");
                Console.ReadLine();
                methods.continueHome();
            }
            
            else
            {
                gold -= 50;
                energy += 100;
                methods.continueHome();
            }
        }
    }
}