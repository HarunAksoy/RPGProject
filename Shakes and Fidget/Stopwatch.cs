using System;
using System.Media;

namespace Shakes_and_Fidget
{
    public class Stopwatch
    {
        //This is the timer for the quests
        public static void Timer()
        {
            //The background music
            SoundPlayer myPlayer = new SoundPlayer(@"C:\Users\vmadmin\RiderProjects\RPGProject\theme\theme.wav");
            myPlayer.Play();

            for (int a = 20; a >= 0; a--)
            {
                Console.WriteLine(" ");
                Console.Write("You are on quest {0}", a);

                System.Threading.Thread.Sleep(1000);

                Console.Clear();

                if (a <= 0)
                {
                    myPlayer.Stop();
                    Performance.gold += 50;
                    Level.Level1++;
                    Console.Clear();
                    Home.PrintMenuHome();
                    Console.WriteLine(
                        "________________________________________________________________________________________________________________________");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(">You are done with the Quest, you've got {0} Gold and you are Level {1}",
                        Performance.gold, Level.Level1);
                    Console.ForegroundColor = ConsoleColor.White;
                    Home.StartHome();
                }
            }
        }
    }
}