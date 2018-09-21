using System;
using System.Media;

namespace Shakes_and_Fidget
{
    public class Stopwatch
    {
        
        public static void Timer()
        {
            SoundPlayer myPlayer = new SoundPlayer(@"C:\Users\vmadmin\RiderProjects\RPGProject\theme\theme.wav");
            myPlayer.Play();
            
            for (int a = 20; a >= 0; a--)
            {

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
                    Console.WriteLine(">You are done with the Quest, you've got {0} Gold and you are Level {1}", Performance.gold, Level.Level1);
                    Home.StartHome();
                }
            }
        }
    }
}