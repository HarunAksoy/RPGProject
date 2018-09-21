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

        public void CheckEntryName()
        {
            Console.WriteLine("Name: ");
            name = Console.ReadLine();
            if (!File.Exists("SaveOf" + name + ".txt"))
            {
                Console.Clear();
                PrintMenuClasse();
                StartClasse();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Username is already taken, you will be redirected to the homepage.");
                Thread.Sleep(3000);
            }
        }

        public static void StartRace()
        {
            while (isChosingRace)
            {
                CheckEntryRace(Int32.Parse(Console.ReadLine()));
            }
        }

        public static void StartClasse()
        {
            while (isChosingClass)
            {
                CheckEntryClasse(Int32.Parse(Console.ReadLine()));
            }
        }

        public static void PrintMenuRace()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Choose your race:");
            Console.WriteLine("___________________________");
            Console.WriteLine("Press [1] to be an Ogre");
            Console.WriteLine("Press [2] to be a Human");
            Console.WriteLine("Press [3] to be a Goblin");
            Console.WriteLine("Press [4] to be a Blood Elf");
        }

        public static void PrintMenuClasse()
        {
            Console.WriteLine("Choose your class:");
            Console.WriteLine("_________________________");
            Console.WriteLine("Press [1] to be a Monk");
            Console.WriteLine("Press [2] to be a Mage");
            Console.WriteLine("Press [3] to be a Hunter");
            Console.WriteLine("Press [4] to be a Warrior");
        }

        private static void CheckEntryRace(int _race)
        {
            CharacterMethods methods = new CharacterMethods();
            Console.ForegroundColor = ConsoleColor.White;
            {
                switch (_race)
                {
                    case 1:
                        Console.WriteLine("Human [1]{0}", race);
                        methods.ContinueHome();
                        break;
                    case 2:
                        Console.WriteLine("Blood Elf [2]{0}", race);
                        methods.ContinueHome();
                        break;
                    case 3:
                        Console.WriteLine("Gnome [3]{0}", race);
                        methods.ContinueHome();
                        break;
                    case 4:
                        Console.WriteLine("Goblin [4]{0}", race);
                        methods.ContinueHome();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid Input! Try again.");
                        break;
                }
            }
        }

        private static void CheckEntryClasse(int _classe)
        {
            Console.ForegroundColor = ConsoleColor.White;
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