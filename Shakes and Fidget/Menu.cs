using System;
using System.Diagnostics;

namespace Shakes_and_Fidget
{
    public class Menu
    {
        private static bool isPlaying = true;

        public static void start()
        {
            

            while (isPlaying)
            {
                printMenu();
                checkEntryMenu(Int32.Parse(Console.ReadLine()));
            }
        }

        private static void printMenu()
        {
            Console.Title = "Shakes and Fidget";
            string Title = @"
                            ____________________  ________ 
                            \______   \______   \/  _____/ 
                             |       _/|     ___/   \  ___ 
                             |    |   \|    |   \    \_\  \
                             |____|_  /|____|    \______  /
                                    \/                  \/ ";
            Console.WriteLine(Title);
            Console.WriteLine("\n");
            Console.WriteLine("Create character [1]");
            Console.WriteLine("Load game [2]");
            Console.WriteLine("Quit [3]");
        }

        private static void checkEntryMenu(int entry)
        {
            switch (entry)
            {
                case 1:
                    Console.Clear();
                    Character.checkEntryName();
                    Console.Clear();
                    Character.printMenuClasse();
                    Character.startClasse();
                    break;
                case 2:
                    SaveLoad.GameLoad();
                    Console.Clear();
                    Home.printMenuHome();
                    break;
                case 3:
                    Environment.Exit(0);
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Invalid Input! Try again.");
                    break;
            }
        }
    }
}