using System;

namespace task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ohjelma tulostaa 1-9 kertotaulun.\n\nVastaus:\n");

            for (int i = 1; i <= 9; i++)
            {
                for (int e = 1; e <= 9; e++)
                    Console.Write($"{i} x {e} = {i * e}\n");

                Console.Write("\n");
            }
        }
    }
}
