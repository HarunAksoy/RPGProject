using System;

namespace Shakes_and_Fidget
{
    public class Endboss
    {
        public static void StartGame()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n______________________________\n\n\tFight Pepe\n\n______________________________\n");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("(Press any key to fight Pepe...)");
            Console.ReadKey();
            Fight();
        }

        public static void YouWon()
        {
            CharacterMethods methods = new CharacterMethods();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\tYou've Won!");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("(Press any key to get to home)");
            Console.ReadKey();
            Performance.gold += 500;
            Level.Level1++;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            methods.ContinueHome();
        }

        public static void YouLost()
        {
            CharacterMethods methods = new CharacterMethods();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\tYou couldn't win against Pepe...");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("(Press any key to get to home)");
            Console.ReadKey();
            Performance.gold += 50;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
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
            Console.ForegroundColor = ConsoleColor.Red;
            if (pepeHealth < 1)
            {
                YouWon();
            }

            if (myHealth < 1)
            {
                YouLost();
            }

            System.Threading.Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Press [1] to attack Pepe with the holy sword");
            Console.WriteLine("Press [2] to heal with the magic slurp from Asgard");
            Console.WriteLine("Press [3] to recharge your energy");
            Console.WriteLine("_________________________________________________");

            inp = Console.ReadLine();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
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

            Console.WriteLine("Your health: " + myHealth + "/100");
            Console.WriteLine("Your energy: " + energy + "/20");
            Console.WriteLine("Pepe's health: " + pepeHealth + "/100");
            myHealth -= rnd.Next(2, 20);
            Console.WriteLine("_________________________________________________");
            System.Threading.Thread.Sleep(1000);


            if (refillEnergy == true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("You had no energy, so you used 5% of your health to get 10 energy.");
                refillEnergy = false;
                System.Threading.Thread.Sleep(1000);
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Pepe attacked you! Your health is now" + myHealth);
            goto Act;
        }
    }
}