using System;
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
            Console.WriteLine("👤 Name: {0}", Character.name);
            Console.SetCursorPosition(27, 1);
            Console.WriteLine("💰 Gold: {0}", Performance.gold);
            Console.SetCursorPosition(47, 1);
            Console.WriteLine("🟊 Exp: {0}/{1}", Performance.experience, fullExperience);
            Console.SetCursorPosition(67, 1);
            Console.WriteLine("⚡ Energy: {0}/{1}", Performance.energy, fullEnergy);
            Console.SetCursorPosition(87, 1);
            Console.WriteLine("🏆 Level: {0}", Level.level);
            Console.SetCursorPosition(117, 1);
            Console.WriteLine("\n");
            Console.WriteLine("⛏ Press [1] to do a Quest");
            Console.WriteLine("⛽ Press [2] to refill your energy -> (50 Gold)");
            Console.WriteLine("💾Press [3] to save the game");
            Console.WriteLine("❌ Press [4] to quit the game");
        }

        public static void checkEntryHome(int home)
        {
            {
                switch (home)
                {
                    case 1:
                        Console.Clear();
                        Level.checkLevel();
                        Console.WriteLine("Press [1] to accept the quest");
                        Console.WriteLine("Press [2] to go back home");
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