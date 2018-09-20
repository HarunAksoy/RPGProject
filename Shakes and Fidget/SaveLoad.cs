using System;
using System.IO;

namespace Shakes_and_Fidget
{
    public static class SaveLoad
    {
        public static void GameLoad()
        {
            CharacterMethods methods = new CharacterMethods();
            Console.Clear();
            Console.WriteLine("Type your username to load the game:");
            Character.name = Console.ReadLine();
            if (File.Exists("SaveOf" + Character.name + ".txt"))
            {
                TextReader tr = new StreamReader("SaveOf" + Character.name + ".txt");
                Character.name = tr.ReadLine();
                string goldString = tr.ReadLine();
                string expString = tr.ReadLine();
                string enrgyString = tr.ReadLine();
                string lvlString = tr.ReadLine();
                Performance.gold = Convert.ToInt32(goldString);
                Performance.experience = Convert.ToInt32(expString);
                Performance.energy = Convert.ToInt32(enrgyString);
                Level.Level1 = Convert.ToInt32(lvlString);
                tr.Close();
                methods.continueHome();
            }
            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("This user doesn't exist!");
            }
        }

        public static void GameSave()
        {
            CharacterMethods methods = new CharacterMethods();
            if (!File.Exists("SaveOf.txt"))
            {
                TextWriter tw = new StreamWriter("SaveOf" + Character.name + ".txt");
                tw.WriteLine(Character.name);
                tw.WriteLine(Performance.gold);
                tw.WriteLine(Performance.experience);
                tw.WriteLine(Performance.energy);
                tw.WriteLine(Level.Level1);
                tw.Close();
                Console.Clear();
                methods.continueHome();
            }
        }
    }
}