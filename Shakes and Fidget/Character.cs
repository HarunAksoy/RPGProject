using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Shakes_and_Fidget
{
    public class Character
    {
        public static string name;
        public static string classe;
        public static string race;
        private static bool isChosingClass = true;
        private static bool isChosingRace = true;


        public static void startClasse()
        {
            while (isChosingClass)
            {
                checkEntryClasse(Int32.Parse(Console.ReadLine()));
            }
        }

        public static void startRace()
        {
            while (isChosingRace)
            {
                checkEntryRace(Int32.Parse(Console.ReadLine()));
            }
        }


        public static void printMenuClasse()
        {
            Console.WriteLine("Warrior [1]");
            Console.WriteLine("Hunter [2]");
            Console.WriteLine("Mage [3]");
            Console.WriteLine("Monk [4]");
        }

        public static void printMenuRace()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("‍Human [1]");
            Console.WriteLine("Blood Elf [2]");
            Console.WriteLine("Ogre [3]");
            Console.WriteLine("Goblin [4]");
            
        }

        public static void checkEntryName()
        {
            Console.WriteLine("Name: ");
            name = Console.ReadLine();
        }


        public static void checkEntryClasse(int _classe)
        {
            {
                switch (_classe)
                {
                    case 1:
                        Console.WriteLine("Warrior [1]{0}", classe);
                        Console.Clear();
                        printMenuRace();
                        startRace();
                        break;
                    case 2:
                        Console.WriteLine("Hunter [2]{0}", classe);
                        Console.Clear();
                        printMenuRace();
                        startRace();
                        break;
                    case 3:
                        Console.WriteLine("Mage [3]{0}", classe);
                        Console.Clear();
                        printMenuRace();
                        startRace();
                        break;
                    case 4:
                        Console.WriteLine("Monk [4]{0}", classe);
                        Console.Clear();
                        printMenuRace();
                        startRace();
                        break;
                    default:
                        Console.WriteLine("Invalid Input! Try again.");
                        break;
                }
            }
        }

        private static void checkEntryRace(int _race)
        {
            {
                switch (_race)
                {
                    case 1:
                        Console.WriteLine("Human [1]{0}", race);
                        Console.Clear();
                        Home.printMenuHome();
                        Home.startHome();
                        break;
                    case 2:
                        Console.WriteLine("Blood Elf [2]{0}", race);
                        Console.Clear();
                        Home.printMenuHome();
                        Home.startHome();
                        break;
                    case 3:
                        Console.WriteLine("Gnome [3]{0}", race);
                        Console.Clear();
                        Home.printMenuHome();
                        Home.startHome();
                        break;
                    case 4:
                        Console.WriteLine("Goblin [4]{0}", race);
                        Console.Clear();
                        Home.printMenuHome();
                        Home.startHome();
                        break;
                    default:
                        Console.WriteLine("Invalid Input! Try again.");
                        break;
                }
            }
        }
    }
}