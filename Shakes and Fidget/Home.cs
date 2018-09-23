using System;

namespace Shakes_and_Fidget
{
    public class Home
    {
        public static int fullExperience = 100;
        public static int fullEnergy = 100;

        public static void StartHome()
        {
            CheckEntryHome(Int32.Parse(Console.ReadLine()));
        }

        public static void StartQuest()
        {
            CheckEntryQuest(Int32.Parse(Console.ReadLine()));
        }

        public static void StartLeave()
        {
            CheckEntryLeave((Console.ReadLine()));
        }

        public static void PrintMenuHome()
        {
            Console.ForegroundColor = ConsoleColor.White;


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
            Console.WriteLine("🏆 Level: {0}", Level.Level1);
            Console.SetCursorPosition(117, 1);
            Console.WriteLine("\n");
            Console.WriteLine("⛏ Press [1] to do a Quest");
            Console.WriteLine("⛽ Press [2] to refill your energy -> (50 Gold)");
            Console.WriteLine("🛒Press [3] to get to the item shop");
            Console.WriteLine("❌ Press [4] to quit the game");
        }

        public static void CheckEntryHome(int home)
        {
            {
                switch (home)
                {
                    case 1:
                        Console.Clear();
                        Level.CheckLevel();
                        Console.WriteLine("Press [1] to accept the quest");
                        Console.WriteLine("Press [2] to go back home");
                        StartQuest();
                        break;
                    case 2:
                        Performance.CheckGold();
                        break;
                    case 3:
                        Performance.Shop();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Do you want to leave the game without saving?");
                        Console.WriteLine("❌ Type [y] to leave the game without saving");
                        Console.WriteLine("💾 Type [n] to save the game");
                        StartLeave();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid Input! Try again.");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                }
            }
        }

        private static void CheckEntryQuest(int task)
        {
            CharacterMethods methods = new CharacterMethods();
            switch (task)
            {
                case 1:
                    Performance.CheckEnergy();
                    break;
                case 2:
                    methods.ContinueHome();
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid Input! Try again.");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }
        }

        //When you exit the game you can save or not
        private static void CheckEntryLeave(string task)
        {
            switch (task)
            {
                case "y":
                    Environment.Exit(0);
                    break;
                case "n":
                    SaveLoad.GameSave();
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid Input! Try again.");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }
        }
    }
}