﻿using System;
using System.Runtime.CompilerServices;


namespace Shakes_and_Fidget
{
    internal class Program
    {
        
        
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            
            Menu menu = new Menu();
            menu.Start();
            
        }
        
    }
}