using System;

namespace Shakes_and_Fidget
{
    public class Stopwatch
    {
        public static void Timer()
        {
            CharacterMethods methods = new CharacterMethods();
            for (int a = 3; a >= 0; a--)
            {
                Console.Write("You are on quest {0}", a);

                System.Threading.Thread.Sleep(1000);

                Console.Clear();

                if (a <= 0)
                {
                    Performance.gold += 50;
                    Level.level++;
                    //Console.Write wird nicht angezeigt wegen dem Interface
                    methods.continueHome();
                    Console.Write("You are done with the quest!");
                }
            }
        }
    }
}