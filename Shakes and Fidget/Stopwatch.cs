using System;

namespace Shakes_and_Fidget
{
    public class Stopwatch
    {
        public static void Timer()
        {
            
            for (int a = 3; a >= 0; a--)
            {
                Console.Write("You are on quest {0}", a);

                System.Threading.Thread.Sleep(1000);

                Console.Clear();

                if (a <= 0)
                {
                    Performance.gold += 50;
                    Level.level++;
                    Console.Clear();
                    Home.printMenuHome();
                    Console.WriteLine(
                        "________________________________________________________________________________________________________________________");
                    Console.WriteLine(">You are done with the Quest, you've got {0} Gold and you are Level {1}", Performance.gold, Level.level);
                    Home.startHome();
                }
            }
        }
    }
}