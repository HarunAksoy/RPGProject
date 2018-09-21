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
            Console.WriteLine("\n");
            Console.WriteLine("Energy Cost: {0}, Earned gold: 50, Earned XP: 100", Performance.questEnergy);
            Console.WriteLine("\n");
            Console.WriteLine(
                "________________________________________________________________________________________________________________________");
            Console.WriteLine("\n");
            Console.WriteLine("Quest Title: The wise old man");
            Console.WriteLine("Quest Description: Hey you, listen! Thou shalt bring the white man to Maerwymm.");
            Console.WriteLine("And think of some interesting topics for discussion on the go. And now - let's dance!");
            Console.WriteLine("\n");
        }

        public static void SecondQuest()
        {
            Console.WriteLine(
                "________________________________________________________________________________________________________________________");
            Console.SetCursorPosition(7, 1);
            Console.WriteLine("\n");
            Console.WriteLine("Energy Cost: {0}, Earned gold: 50, Earned XP: 100", Performance.questEnergy);
            Console.WriteLine("\n");
            Console.WriteLine(
                "________________________________________________________________________________________________________________________");
            Console.WriteLine("\n");
            Console.WriteLine("Quest Title: The holy shield");
            Console.WriteLine("Quest Description: Hey, psst ... yes, you!I am looking for a holy shield.");
            Console.WriteLine(
                "Go to the Shadow Mountains. When you do a rain dance there, the thing you're looking for falls from the sky.");
            Console.WriteLine(
                "I always wanted to have such a sign. Supposedly it is true as a cheat, but that's not noticeable anyway.");
            Console.WriteLine("And hurry, please!");
            Console.WriteLine("\n");
        }

        public static void ThirdQuest()
        {
            Console.WriteLine(
                "________________________________________________________________________________________________________________________");
            Console.SetCursorPosition(7, 1);
            Console.WriteLine("\n");
            Console.WriteLine("Energy Cost: {0}, Earned gold: 50", Performance.questEnergy);
            Console.WriteLine("\n");
            Console.WriteLine(
                "________________________________________________________________________________________________________________________");
            Console.WriteLine("\n");
            Console.WriteLine("Quest Title: The demon portal");
            Console.WriteLine(
                "Quest Description: Do you have time for a small assignment? Journey to the rotting land.");
            Console.WriteLine("But I do not know exactly, because so far no one has returned from there.");
            Console.WriteLine("If the rumors are true, I'd like to have that written by you.");
            Console.WriteLine("\n");
        }

        public static void FourthQuest()
        {
            Console.WriteLine(
                "________________________________________________________________________________________________________________________");
            Console.SetCursorPosition(7, 1);
            Console.WriteLine("\n");

            Console.WriteLine("\n");
            Console.WriteLine(
                "________________________________________________________________________________________________________________________");
            Console.WriteLine("\n");
            Console.WriteLine("Quest Title: This quest is a DLC.");
            Console.WriteLine(
                "Quest Description: This quest is a DLC.");
            Console.WriteLine("\n");
        }
    }
}