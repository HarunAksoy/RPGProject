using System;
using System.Collections.Generic;

namespace Shakes_and_Fidget
{
    public class Performance
    {
        public static int gold = 50;
        public static int experience = 0;
        public static int energy = 0;
        public static int questEnergy = 100;

        //Checking if you have enough energy
        public static void CheckEnergy()
        {
            if (energy < Home.fullEnergy)
            {
                Console.Clear();
                Home.PrintMenuHome();
                Console.WriteLine(
                    "________________________________________________________________________________________________________________________");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(">You don't have enough Energy to do a Quest!");
                Console.ForegroundColor = ConsoleColor.White;
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
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(">You don't have enough energy to do a quest!");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        //Checking if you have enough gold
        public static void CheckGold()
        {
            CharacterMethods methods = new CharacterMethods();

            if (gold < 50)
            {
                Console.Clear();
                Home.PrintMenuHome();
                Console.WriteLine(
                    "________________________________________________________________________________________________________________________");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(">You don't have enough gold to refill your energy!");
                Console.ForegroundColor = ConsoleColor.White;
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

        //Go to the shop (there is nothing to buy)
        public static void Shop()
        {
            List<string> list = new List<string>();
            Console.ForegroundColor = ConsoleColor.Red;
            list.Add("In processing!");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (var VARIABLE in list)
            {
                Console.WriteLine(VARIABLE);
            }
        }
    }
}