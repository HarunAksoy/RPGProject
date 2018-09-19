using System;
using System.IO;
using System.Net;

namespace Shakes_and_Fidget
{
    public static class SaveLoad
    {
        public static void GameSave()
        {
            if (File.Exists("SavedGame.txt"))
            {
                string validatedName = name;
                int tries = 1;
                
                while (File.Exists("SavedGame.txt"))
                {
                    validatedName = string.Format("{0} [{1}]", name, tries++);
                    TextWriter tw = new StreamWriter("SavedGame.txt");
                    tw.WriteLine(Character.name);
                    tw.WriteLine(Performance.gold);
                    tw.WriteLine(Performance.experience);
                    tw.WriteLine(Performance.energy);
                    tw.WriteLine(Level.level);

                    tw.Close();
                    Console.Clear();
                    Home.printMenuHome();
                }
            }
            else
            {
                {
                    TextWriter tw = new StreamWriter("SavedGame.txt");
                    tw.WriteLine(Character.name);
                    tw.WriteLine(Performance.gold);
                    tw.WriteLine(Performance.experience);
                    tw.WriteLine(Performance.energy);
                    tw.WriteLine(Level.level);

                    tw.Close();
                    Console.Clear();
                    Home.printMenuHome();
                }
            }
        }

        public static void GameLoad()
        {
            Console.Clear();

            TextReader tr = new StreamReader("SavedGame.txt");
            Character.name = tr.ReadLine();
            string goldString = tr.ReadLine();
            string expString = tr.ReadLine();
            string enrgyString = tr.ReadLine();
            string lvlString = tr.ReadLine();

            Performance.gold = Convert.ToInt32(goldString);
            Performance.experience = Convert.ToInt32(expString);
            Performance.energy = Convert.ToInt32(enrgyString);
            Level.level = Convert.ToInt32(lvlString);

            tr.Close();
            Console.Clear();
            Home.printMenuHome();
            Home.startHome();
        }
    }
}