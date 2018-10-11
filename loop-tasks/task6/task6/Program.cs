using System;

namespace task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ohjelma tulostaa kokonaislukuja ja niiden neliöjuuret.\n\n");
            Console.Write($"Luku\tNeliöjuuri\n");

            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"{i}\t{Math.Round(Math.Sqrt(i), 2)}\n");
            }
        }
    }
}
