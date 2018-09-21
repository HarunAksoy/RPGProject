using System;
using System.IO;

namespace Shakes_and_Fidget
{
    public static class SaveLoad
    {
        //Loading the game
        public static void GameLoad()
        {
            //Interface
            CharacterMethods methods = new CharacterMethods();
            Console.Clear();
            //To load the game, you have to type your game name
            Console.WriteLine("Type your game name to load the game:");
            Character.name = Console.ReadLine();
            if (File.Exists("SaveOf" + Character.name + ".txt"))
            {
                //Read the stats out of the .txt files
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
                methods.ContinueHome();
            }
            else
            {
                //If the user doesn't exist, you will get this error
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("This user doesn't exist!");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        //Saving the game
        public static void GameSave()
        {
            CharacterMethods methods = new CharacterMethods();
            //If SafeOf doesn't exist, a game save will be created
            if (!File.Exists("SaveOf.txt"))
            {
                //Write the stats in .txt files
                TextWriter tw = new StreamWriter("SaveOf" + Character.name + ".txt");
                tw.WriteLine(Character.name);
                tw.WriteLine(Performance.gold);
                tw.WriteLine(Performance.experience);
                tw.WriteLine(Performance.energy);
                tw.WriteLine(Level.Level1);
                tw.Close();
                Environment.Exit(0);
            }
        }
    }
}