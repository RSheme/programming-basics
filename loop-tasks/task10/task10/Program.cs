using System;

namespace task10
{
    class Program
    {
        static void Main(string[] args)
        {
            Random game = new Random();
            double result;

            Console.Write("Ohjelma tulostaa vakioveikkauksen rivin.\n\nVastaus:\n");

            for (int i = 1; i <= 13; i++)
            {
                Console.Write($"{i}. ");

                result = game.NextDouble();

                if (result < 0.4)
                    Console.Write("Kotivoitto.\n");
                else if (result >= 0.4 && result < 0.6)
                    Console.Write("Tasapeli.\n");
                else
                    Console.Write("Vierasvoitto.\n");
            }
        }
    }
}
