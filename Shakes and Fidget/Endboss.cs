using System;
using System.Media;

namespace Shakes_and_Fidget
{
    public class Endboss
    {
        public static void StartGame()
        {
            FightPepe();
        }

        //If you win
        public static void YouWon()
        {
            CharacterMethods methods = new CharacterMethods();
            Console.Clear();
            SoundPlayer victory = new SoundPlayer(@"C:\Users\vmadmin\RiderProjects\RPGProject\theme\victory.wav");
            victory.Play();
            Console.WriteLine("You defeated Pepe and brought peace into the world");
            Console.WriteLine("\n>Press any key to go home");
            Console.ReadKey();
            Performance.gold += 500;
            Level.Level1++;
            Console.Clear();
            methods.ContinueHome();
        }

        //If you lose
        public static void YouLost()
        {
            CharacterMethods methods = new CharacterMethods();
            Console.Clear();
            SoundPlayer defeat = new SoundPlayer(@"C:\Users\vmadmin\RiderProjects\RPGProject\theme\defeat.wav");
            defeat.Play();
            Console.WriteLine("You couldn't win against Pepe...");
            Console.WriteLine("\n>Press any key to go home");
            Console.ReadKey();
            Performance.gold += 50;
            Console.Clear();
            methods.ContinueHome();
        }

        public static void FightPepe()
        {
            SoundPlayer myPlayer = new SoundPlayer(@"C:\Users\vmadmin\RiderProjects\RPGProject\theme\endboss.wav");
            myPlayer.Play();
            Random rnd = new Random();

            int myHealth = 100;
            int energy = 20;
            int pepeHealth = 100;
            bool refillEnergy = false;
            String _fight;

            //Win or Lose the Fight
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

            //Your and pepe's stats
            Console.WriteLine(
                "________________________________________________________________________________________________________________________");
            Console.WriteLine("🖤 Your health: " + myHealth + "/100");
            Console.WriteLine("⚡ Your energy: " + energy + "/20");
            Console.WriteLine("💀 Pepe's health: " + pepeHealth + "/100");

            Console.WriteLine(
                "________________________________________________________________________________________________________________________");
            System.Threading.Thread.Sleep(1000);

            //Fight options
            Console.WriteLine("Press [1] to attack Pepe with the holy sword");
            Console.WriteLine("Press [2] to heal with the magic slurp from Asgard");
            Console.WriteLine("Press [3] to recharge your energy");
            Console.WriteLine(
                "________________________________________________________________________________________________________________________");

            _fight = Console.ReadLine();
            Console.Clear();
            Console.WriteLine(
                "________________________________________________________________________________________________________________________");

            //Switch case for the fight options
            switch (_fight)
            {
                case "1":
                    energy -= rnd.Next(2, 6);
                    myHealth -= rnd.Next(2, 20);
                    pepeHealth -= rnd.Next(9, 15);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(">You attacked Pepe with the holy sword!");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case "2":
                    myHealth += rnd.Next(10, 30);
                    energy -= rnd.Next(2, 7);
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(">You used the magic slurp from Asgard!");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case "3":
                    energy = 20;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(">You recharged your energy!");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }

            //Pepe's counter attack
            Console.WriteLine(
                "________________________________________________________________________________________________________________________");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(">Pepe attacked you back! Your health is now " + myHealth + "/100");
            Console.ForegroundColor = ConsoleColor.White;

            //Energy regen
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

            //If refillEnergy get set on true you'll regen energy
            if (refillEnergy == true)
            {
                Console.WriteLine(
                    "________________________________________________________________________________________________________________________");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(">You had no energy, so you used 5% of your health to get 10 energy.");
                Console.ForegroundColor = ConsoleColor.White;
                refillEnergy = false;
                System.Threading.Thread.Sleep(1000);
            }

            goto Act;
        }
    }
}