using System;

namespace Shakes_and_Fidget
{
    public class Menu
    {
        private static bool isPlaying = true;

        public void start()
        {
            while (isPlaying)
            {
                printMenu();
                checkEntryMenu(Int32.Parse(Console.ReadLine()));
            }
        }

        private static void printMenu()
        {
            Console.Title = "Shakes and Fidget";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"
                                #######                  #                                          
                                   #    #    # ######    #       ######  ####  ###### #    # #####  
                                   #    #    # #         #       #      #    # #      ##   # #    # 
                                   #    ###### #####     #       #####  #      #####  # #  # #    # 
                                   #    #    # #         #       #      #  ### #      #  # # #    # 
                                   #    #    # #         #       #      #    # #      #   ## #    # 
                                   #    #    # ######    ####### ######  ####  ###### #    # #####  
                                                                                                    
                                                 ######                       
                                 ####  ######    #     # ###### #####  ###### 
                                #    # #         #     # #      #    # #      
                                #    # #####     ######  #####  #    # #####  
                                #    # #         #       #      #####  #      
                                #    # #         #       #      #      #      
                                 ####  #         #       ###### #      ###### ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(">Press [1] to create a character");
            Console.WriteLine(">Press [2] to load game");
            Console.WriteLine(">Press [3] to exit the game");
        }

        private static void checkEntryMenu(int entry)
        {
            switch (entry)
            {
                case 1:
                    Console.Clear();
                    Character.checkEntryName();
                    Console.Clear();
                    break;
                case 2:
                    SaveLoad.GameLoad();
                    break;
                case 3:
                    Environment.Exit(0);
                    break;
                default:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid Input! Try again.");
                    break;
            }
        }
    }
}