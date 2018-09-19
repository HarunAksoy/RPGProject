using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Threading;

namespace Shakes_and_Fidget
{
    public static class SaveLoad
    {
        

        public static void GameLoad()
        {
            CharacterMethods methods = new CharacterMethods();
            Console.Clear();
            Console.WriteLine("Ihr Benutzername: ");
            Character.name = Console.ReadLine();
            if (File.Exists("SavedGame" + Character.name + ".txt"))
            {
                TextReader tr = new StreamReader("SavedGame" + Character.name + ".txt");
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
                methods.continueHome();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Dieser Benutzer existiert nicht oder wurde nicht abgespeichert");
            }
        }

        public static void GameSave()
        {
            CharacterMethods methods = new CharacterMethods();
            if (!File.Exists("SavedGame.txt"))
            {
                TextWriter tw = new StreamWriter("SavedGame" + Character.name + ".txt");
                tw.WriteLine(Character.name);
                tw.WriteLine(Performance.gold);
                tw.WriteLine(Performance.experience);
                tw.WriteLine(Performance.energy);
                tw.WriteLine(Level.level);
                tw.Close();
                Console.Clear();
                methods.continueHome();
            }
        }
    }
}