using System;
using System.Collections.Generic;
using System.Linq;

namespace task9
{
    class Program
    {
        static void Main(string[] args)
        {
            Random coin = new Random();
            int[] result = new int[2];
            List<string> breaklist = new List<string>() { "quit", "exit", "stop", "leave", "close", "break", "escape", "disintegrate", "i am bored", "divide by zero", "termin", "lopet", "loppu", "poistu", "sulje", "ovi auki tai tapahtuu hirveitä" };
            int count = 1;
            string input = "";

            while (true)
            {
                Console.Clear();
                Console.Write("Ohjelma heittää kolikkoa käyttäjän antaman määrän ja kertoo montako kertaa tuli kruuna tai klaava.\n\n");

                if (count < 1)
                    Console.Write("Virheellinen syöte.\n");
                else if (input == count.ToString())
                {
                    Console.Write($"Kruuna heitettiin {result[0]} kertaa ja klaava {result[1]} kertaa.\n");
                    Array.Clear(result, 0, result.Length);
                }

                Console.Write("Syötä numero: ");
                input = Console.ReadLine();

                if (breaklist.Any(input.ToLower().Contains))
                    break;

                Int32.TryParse(input, out count);

                for (int i = 1; count > 0 && i <= count; i++)
                {
                    result[coin.Next(2)]++;
                }
            }
        }
    }
}
