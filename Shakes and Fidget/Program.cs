using System;
using System.Media;

namespace Shakes_and_Fidget
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Convert unicode
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            //Background music
            SoundPlayer myPlayer = new SoundPlayer(@"C:\Users\vmadmin\RiderProjects\RPGProject\theme\home.wav");
            myPlayer.PlayLooping();
            Menu menu = new Menu();
            menu.Start();
        }
    }
}