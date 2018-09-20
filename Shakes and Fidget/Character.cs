using System;
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

        public void checkEntryName()
        {
            Console.WriteLine("Name: ");
            name = Console.ReadLine();
            if (!File.Exists("SavedOf" + name + ".txt"))
            {
                Console.Clear();
                printMenuClasse();
                startClasse();
            }
            else
            {
                Console.WriteLine("Username is already taken, you will be redirected to the homepage.");
                Thread.Sleep(3000);
            }
        }

        public static void startRace()
        {
            while (isChosingRace)
            {
                checkEntryRace(Int32.Parse(Console.ReadLine()));
            }
        }

        public static void startClasse()
        {
            while (isChosingClass)
            {
                checkEntryClasse(Int32.Parse(Console.ReadLine()));
            }
        }

        public static void printMenuRace()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Choose your race:");
            Console.WriteLine("___________________________");
            Console.WriteLine("Press [1] to be an Ogre");
            Console.WriteLine("Press [2] to be a Human");
            Console.WriteLine("Press [3] to be a Goblin");
            Console.WriteLine("Press [4] to be a Blood Elf");
        }

        public static void printMenuClasse()
        {
            Console.WriteLine("Choose your class:");
            Console.WriteLine("_________________________");
            Console.WriteLine("Press [1] to be a Monk");
            Console.WriteLine("Press [2] to be a Mage");
            Console.WriteLine("Press [3] to be a Hunter");
            Console.WriteLine("Press [4] to be a Warrior");
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
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid Input! Try again.");
                        break;
                }
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
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid Input! Try again.");
                        break;
                }
            }
        }
    }
}