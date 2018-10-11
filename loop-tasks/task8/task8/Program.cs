using System;

namespace task8
{
    class Program
    {
        static void Main(string[] args)
        {
            Random roll = new Random();

            Console.Write("Ohjelma arpoo 20 lukua, ja laittaa ne viiden numeron riveihin.\n\nVastaus:\n");

            for (int i = 1; i <= 4; i++)
            {
                Console.Write($"Rivi {i}: ");

                for (int e = 1; e <= 5; e++)
                    Console.Write($"{roll.Next(50)} ");

                Console.Write("\n");
            }
        }
    }
}
