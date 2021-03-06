using System;

namespace Shakes_and_Fidget
{
    public class Menu
    {
        private static bool isPlaying = true;

        public void Start()
        {
            while (isPlaying)
            {
                PrintMenu();
                CheckEntryMenu(Int32.Parse(Console.ReadLine()));
            }
        }

        private static void PrintMenu()
        {
            //Console title = top left of the window
            Console.Title = "The Legend of Pepe";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"
________________________________________________________________________________________________________________________
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
                                     ####  #         #       ###### #      ###### 
________________________________________________________________________________________________________________________
");
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(">Press [1] to create a character");
            Console.WriteLine(">Press [2] to load game");
            Console.WriteLine(">Press [3] to exit the game");
            Console.WriteLine("\n");
            Console.WriteLine("(Please play with sound and turn it down a bit.)");
        }

        private void CheckEntryMenu(int entry)
        {
            switch (entry)
            {
                case 1:
                    Console.Clear();
                    Character character = new Character();
                    character.CheckEntryName();
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
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }
        }
    }
}