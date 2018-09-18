using System;
using System.IO;

namespace Shakes_and_Fidget
{
    public static class SaveLoad
    {
        public static void GameSave()
        {
            TextWriter tw = new StreamWriter("SavedGame.txt");

            tw.WriteLine(Character.name);
            tw.WriteLine(Performance.gold);
            tw.WriteLine(Performance.experience);
            tw.WriteLine(Performance.energy);

            tw.Close();
        }

        public static void GameLoad()
        {
            TextReader tr = new StreamReader("SavedGame.txt");
            Character.name = tr.ReadLine();
            string goldString = tr.ReadLine();
            string expString = tr.ReadLine();
            string enrgyString = tr.ReadLine();

            Performance.gold = Convert.ToInt32(goldString);
            Performance.experience = Convert.ToInt32(expString);
            Performance.energy = Convert.ToInt32(enrgyString);

            tr.Close();
        }
    }
}