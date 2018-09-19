using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;

namespace Shakes_and_Fidget
{
    public class Home
    {
        public static int fullExperience = 100;
        public static int fullEnergy = 100;
        private static bool isChosingHome = true;
        private static bool isChosingQuest = true;


        public static void startHome()
        {
            while (isChosingHome)
            {
                checkEntryHome(Int32.Parse(Console.ReadLine()));
            }
        }

        public static void startQuest()
        {
            while (isChosingQuest)
            {
                checkEntryQuest(Int32.Parse(Console.ReadLine()));
            }
        }


        public static void printMenuHome()
        {
            Console.OutputEncoding = Encoding.Unicode;

            Console.WriteLine(
                "________________________________________________________________________________________________________________________");
            Console.SetCursorPosition(7, 1);
            Console.WriteLine("Name: {0}", Character.name);
            Console.SetCursorPosition(27, 1);
            Console.WriteLine("💰 Gold: {0}", Performance.gold);
            Console.SetCursorPosition(47, 1);
            Console.WriteLine("🟊 Exp: {0}/{1}", Performance.experience, fullExperience);
            Console.SetCursorPosition(67, 1);
            Console.WriteLine("☕ Energy: {0}/{1}", Performance.energy, fullEnergy);
            Console.SetCursorPosition(87, 1);
            Console.WriteLine("🏆 Level: {0}", Level.level);
            Console.SetCursorPosition(117, 1);
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine("⛏ Do a Quest  [1]");
            Console.WriteLine("⛽ Refill Energy [2]  ->  (50 Gold)");
            Console.WriteLine("💾 Save Game [3]");
            Console.WriteLine("❌ Quit [4]");
        }


        public static void checkEntryHome(int home)
        {
            {
                switch (home)
                {
                    case 1:
                        Console.Clear();
                        Level.checkLevel();
                        Console.WriteLine("Accept Quest [1]");
                        Console.WriteLine("Back to Home [2]");
                        startQuest();
                        break;
                    case 2:
                        Performance.checkGold();
                        break;
                    case 3:
                        SaveLoad.GameSave();
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid Input! Try again.");
                        break;
                }
            }
        }

        private static void checkEntryQuest(int task)
        {
            CharacterMethods methods = new CharacterMethods();
            switch (task)
            {
                case 1:
                    Performance.checkEnergy();
                    break;
                case 2:
                    methods.continueHome();
                    break;
                default:
                    Console.WriteLine("Invalid Input! Try again.");
                    break;
            }
        }
    }
}