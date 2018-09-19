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
        public static List<string> Files = new List<string>();

        /*void Start()
        {
            for (int i = 0; i < Files.Count; i++)
            {
                
            }
        }*/
        
        public static void GameLoad()
        {
            Console.Clear();
            
            TextReader tr = new StreamReader("SavedGame" +  DateTime.Now.ToString("yyyyMMdd_hhmmss" + ".txt"));
            
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
        
        public static void GameSave()
        {
            if (File.Exists("SavedGame.txt"))
            {
                TextWriter tw = new StreamWriter("SavedGame " + Character.name + ".txt");
                tw.WriteLine(Character.name);
                tw.WriteLine(Performance.gold);
                tw.WriteLine(Performance.experience);
                tw.WriteLine(Performance.energy);
                tw.WriteLine(Level.level);

                tw.Close();
                Console.Clear();
                Home.printMenuHome();
            }

            else
            {
                {
                    TextWriter tw = new StreamWriter("SavedGame " + Character.name + ".txt");
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
        
        
    }
}