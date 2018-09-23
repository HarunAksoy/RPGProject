using System;

namespace Shakes_and_Fidget
{
    public class Quest
    {
        public static void FirstQuest()
        {
            Console.WriteLine(
                "________________________________________________________________________________________________________________________");
            Console.SetCursorPosition(7, 1);
            Console.WriteLine("Energy Cost: {0}, Earned gold: 50, Earned item: the magic slurp, Earned XP: 100",
                Performance.questEnergy);
            Console.WriteLine(
                "________________________________________________________________________________________________________________________");
            Console.WriteLine("Quest Title: The magic slurp from Asgard");
            Console.WriteLine(
                "Quest Description: Hey you, listen! Thou shalt bring the white man to Asgard and get the magic slurp from Asgard.");
            Console.WriteLine("And think of some interesting topics for discussion on the go. And now - let's dance!");
            Console.WriteLine(
                "________________________________________________________________________________________________________________________");
        }

        public static void SecondQuest()
        {
            Console.WriteLine(
                "________________________________________________________________________________________________________________________");
            Console.SetCursorPosition(7, 1);
            Console.WriteLine("Energy Cost: {0}, Earned gold: 50, Earned item: the holy sword, Earned XP: 100",
                Performance.questEnergy);
            Console.WriteLine(
                "________________________________________________________________________________________________________________________");
            Console.WriteLine("Quest Title: The holy sword");
            Console.WriteLine("Quest Description: Hey, psst ... yes, you!I am looking for a holy sword.");
            Console.WriteLine(
                "Go to the Shadow Mountains. When you do a rain dance there, the thing you're looking for falls from the sky.");
            Console.WriteLine(
                "I always wanted to have such a sign. Supposedly it is true as a cheat, but that's not noticeable anyway.");
            Console.WriteLine("And hurry, please!");
            Console.WriteLine(
                "________________________________________________________________________________________________________________________");
        }

        public static void ThirdQuest()
        {
            Console.WriteLine(
                "________________________________________________________________________________________________________________________");
            Console.SetCursorPosition(7, 1);
            Console.WriteLine("Energy Cost: {0}, Earned gold: 500", Performance.questEnergy);
            Console.WriteLine(
                "________________________________________________________________________________________________________________________");
            Console.WriteLine("Quest Title: Pepe the destroyer");
            Console.WriteLine(
                "Quest Description: Do you have time for a small assignment? Journey to the rotting land.");
            Console.WriteLine("But I do not know exactly, because so far no one has ever won against Pepe.");
            Console.WriteLine("If the rumors are true, I'd like to have that written by you.");
            Console.WriteLine(
                "________________________________________________________________________________________________________________________");
        }

        public static void FourthQuest()
        {
            Console.WriteLine(
                "________________________________________________________________________________________________________________________");
            Console.SetCursorPosition(7, 1);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("This quest is a DLC.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(
                "________________________________________________________________________________________________________________________");
        }
    }
}