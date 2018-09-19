using System;
using System.Data;
using System.Security.Cryptography.X509Certificates;


namespace Shakes_and_Fidget

{
    public class Endboss
    {
        

        public static void startGame()
        {
            Console.Title = "Endboss";
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n******************************\n\n\tFight Game\n\n******************************\n");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("(Press any key to start!)");
            Console.ReadKey();
            Action();
        }

        public static void Youwon()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\tYou Won!");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("(Press any key to get to home)");
            Console.ReadKey();
            Performance.gold += 50;
            Level.level++;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Home.printMenuHome();
            Home.startHome();
        }

        public static void Youlost()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\tYou Lost!!!!!!");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("(Press any key to get to home)");
            Console.ReadKey();
            Performance.gold += 500;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Home.printMenuHome();
            Home.startHome();
        }

        public static void Action()
        {
            Random rnd = new Random();

            bool uh = false;
            int energy = 20;
            int health = 100;
            int rh = 100;
            String inp;


            Console.Clear();
            Act:
            Console.ForegroundColor = ConsoleColor.Red;
            if (rh < 1)
            {
                Youwon();
            }

            if (health < 1)
            {
                Youlost();
            }

            System.Threading.Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(
                "\n-------------------------------------------------\n Punch[p]\n\n Regen[r]\n\n Recharge Energy[e]\n-------------------------------------------------");
            Console.Write("\n\n Input: ");
            inp = Console.ReadLine();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("-------------------------------------------------");

            switch (inp)
            {
                case "p":
                    energy -= rnd.Next(2, 6);
                    ;
                    rh -= rnd.Next(9, 15);
                    ;
                    Console.WriteLine(" You punched the enemy!");
                    break;

                case "r":
                    health += rnd.Next(10, 30);
                    energy -= rnd.Next(2, 7);
                    Console.WriteLine(" You got healed!");
                    break;

                case "e":
                    energy = 20;
                    Console.WriteLine(" Recharged Energy!");
                    break;
            }

            if (energy < 1)
            {
                energy = 10;
                health -= 7;
                uh = true;
            }

            if (health > 100)
            {
                health = 100;
            }

            Console.WriteLine("\n Health: " + health + "%\n Energy: " + energy + "\n Enemy's health: " + rh + "%");
            health -= rnd.Next(2, 20);
            Console.WriteLine("-------------------------------------------------");
            System.Threading.Thread.Sleep(1000);


            if (uh == true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(
                    "\n-------------------------------------------------\nYou had no energy, so you used 5% of you health to get 10 energy.\n-------------------------------------------------");
                uh = false;
                System.Threading.Thread.Sleep(1000);
            }


            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(
                "\n\n-------------------------------------------------\n\nThe enemy attacked! You health is now at " +
                health + "%.\n\n-------------------------------------------------\n");


            goto Act;
        }
    }
}