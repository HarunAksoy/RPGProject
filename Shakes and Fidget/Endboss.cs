using System;

namespace Shakes_and_Fidget
{
    public class Endboss
    {
        public static void StartGame()
        {
            Console.WriteLine("\n______________________________\n\n\tFight Pepe\n\n______________________________\n");
            Console.WriteLine("(Press any key to fight Pepe...)");
            Console.ReadKey();
            Fight();
        }

        public static void YouWon()
        {
            CharacterMethods methods = new CharacterMethods();
            Console.Clear();
            Console.WriteLine("\n\tYou defeated Pepe and brought peace into the world");
            Console.WriteLine("(Press any key to get to home)");
            Console.ReadKey();
            Performance.gold += 500;
            Level.Level1++;
            Console.Clear();
            methods.ContinueHome();
        }

        public static void YouLost()
        {
            CharacterMethods methods = new CharacterMethods();
            Console.Clear();
            Console.WriteLine("\n\tYou couldn't win against Pepe...");
            Console.WriteLine("(Press any key to get to home)");
            Console.ReadKey();
            Performance.gold += 50;
            Console.Clear();
            methods.ContinueHome();
        }

        public static void Fight()
        {
            Random rnd = new Random();

            int myHealth = 100;
            int energy = 20;
            int pepeHealth = 100;
            bool refillEnergy = false;
            String inp;


            Console.Clear();
            Act:
            if (pepeHealth < 1)
            {
                YouWon();
            }

            if (myHealth < 1)
            {
                YouLost();
            }

            Console.WriteLine("Press [1] to attack Pepe with the holy sword");
            Console.WriteLine("Press [2] to heal with the magic slurp from Asgard");
            Console.WriteLine("Press [3] to recharge your energy");
            Console.WriteLine("_________________________________________________");

            inp = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("_________________________________________________");

            switch (inp)
            {
                case "1":
                    energy -= rnd.Next(2, 6);
                    pepeHealth -= rnd.Next(9, 15);
                    Console.WriteLine(">You attacked Pepe with the holy sword!");
                    Console.WriteLine("\n");
                    break;
                case "2":
                    myHealth += rnd.Next(10, 30);
                    energy -= rnd.Next(2, 7);
                    Console.WriteLine(">You used the magic slurp from Asgard!");
                    break;
                case "3":
                    energy = 20;
                    Console.WriteLine("You recharged your energy!");
                    break;
            }

            if (energy < 1)
            {
                energy = 10;
                myHealth -= 7;
                refillEnergy = true;
            }

            if (myHealth > 100)
            {
                myHealth = 100;
            }

            if (refillEnergy == true)
            {
                Console.WriteLine("You had no energy, so you used 5% of your health to get 10 energy.");
                refillEnergy = false;
                System.Threading.Thread.Sleep(1000);
            }

            Console.WriteLine("🖤 Your health: " + myHealth + "/100");
            Console.WriteLine("⚡ Your energy: " + energy + "/20");
            Console.WriteLine("💀 Pepe's health: " + pepeHealth + "/100");

            myHealth -= rnd.Next(2, 20);
            Console.WriteLine("_________________________________________________");
            System.Threading.Thread.Sleep(1000);

            Console.WriteLine("\n");
            Console.WriteLine("Pepe attacked you! Your health is now " + myHealth);
            Console.WriteLine("_________________________________________________");
            Console.WriteLine("\n");
            goto Act;
        }
    }
}