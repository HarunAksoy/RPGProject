using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Text;
using System.IO;

namespace Shakes_and_Fidget
{
    public class Character
    {
        public static string name;
        private static string classe;
        private static string race;
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
            Console.WriteLine("Human [1]");
            Console.WriteLine("Blood Elf [2]");
            Console.WriteLine("Ogre [3]");
            Console.WriteLine("Goblin [4]");
        }

        public static void checkEntryName()
        {
            Console.WriteLine("Name: ");
            name = Console.ReadLine();
            if (!File.Exists("SavedGame" + name + ".txt"))
            {
                Console.Clear();
                printMenuClasse();
                startClasse();
            }
            else
            {
                Console.WriteLine("Benutzername vergeben, sie werden wieder auf die Startseite zurückgeleitet");
                Thread.Sleep(3000);
            }
        }


        private static void checkEntryClasse(int _classe)
        {
            CharacterMethods methods = new CharacterMethods();
            {
                switch (_classe)
                {
                    case 1:
                        Console.WriteLine("Warrior [1]{0}", classe);
                        methods.ContinueCharacter();
                        break;
                    case 2:
                        Console.WriteLine("Hunter [2]{0}", classe);
                        methods.ContinueCharacter();

                        break;
                    case 3:
                        Console.WriteLine("Mage [3]{0}", classe);
                        methods.ContinueCharacter();

                        break;
                    case 4:
                        Console.WriteLine("Monk [4]{0}", classe);
                        methods.ContinueCharacter();
                        break;
                    default:
                        Console.WriteLine("Invalid Input! Try again.");
                        break;
                }
            }
        }

        private static void checkEntryRace(int _race)
        {
            CharacterMethods methods = new CharacterMethods();

            {
                switch (_race)
                {
                    case 1:
                        Console.WriteLine("Human [1]{0}", race);
                        methods.continueHome();
                        break;
                    case 2:
                        Console.WriteLine("Blood Elf [2]{0}", race);
                        methods.continueHome();
                        break;
                    case 3:
                        Console.WriteLine("Gnome [3]{0}", race);
                        methods.continueHome();
                        break;
                    case 4:
                        Console.WriteLine("Goblin [4]{0}", race);
                        methods.continueHome();
                        break;
                    default:
                        Console.WriteLine("Invalid Input! Try again.");
                        break;
                }
            }
        }
    }
}