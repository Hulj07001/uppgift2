using System;
namespace Uppgift2
{
    class Program
    {
        static void Main(string[] args)
        {
            //ändrar färgen till blå
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            //ändrar textfärgen till vit
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(":(");
            Console.WriteLine("Windows krashade på grund av oväntat fel");
            Console.WriteLine("datorn måste startas om");
        }
    }
}