using System;
using System.Collections.Generic;
using System.Media;
using System.IO;
using System.Linq;

namespace Shakes_and_Fidget
{
    public class Performance
    {
        public static int gold = 50;
        public static int experience = 0;
        public static int energy = 0;
        public static int questEnergy = 100;


        public static void CheckEnergy()
        {
            
            
                
            
            
            if (energy < Home.fullEnergy)
            {
                Console.Clear();
                Home.PrintMenuHome();
                Console.WriteLine(
                    "________________________________________________________________________________________________________________________");
                Console.WriteLine(">You don't have enough Energy to do a Quest!");
                Home.StartHome();
            }

            else if (Level.Level1 == 1 || Level.Level1 == 2)
            {
                energy -= questEnergy;
                Stopwatch.Timer();
                
            }

            else if (Level.Level1 == 3)
            {
                energy -= questEnergy;
                Console.Clear();
                Endboss.StartGame();
            }

            else
            {
                Console.WriteLine(
                    "________________________________________________________________________________________________________________________");
                Console.WriteLine(">You don't have enough energy to do a quest!");
            }
        }

        public static void CheckGold()
        {
            CharacterMethods methods = new CharacterMethods();

            if (gold < 50)
            {
                Console.Clear();
                Home.PrintMenuHome();
                Console.WriteLine(
                    "________________________________________________________________________________________________________________________");
                Console.WriteLine(">You don't have enough gold to refill your energy!");
                Console.ReadLine();
                methods.ContinueHome();
            }

            else
            {
                gold -= 50;
                energy += 100;
                methods.ContinueHome();
            }
        }


        public static void CheckTime()
        {
           
                
        }
    }
}