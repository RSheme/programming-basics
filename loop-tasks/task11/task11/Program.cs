using System;

namespace task11
{
    class Program
    {
        static void Main(string[] args)
        {
            Random dice = new Random();
            int result;
            int[] num = new int[6];

            Console.Write("Ohjelma heittää noppaa tuhat kertaa, ja kertoo lopuksi monta kertaa jokaista numeroa heitettiin.\n\nVastaus:\n");

            for (int i = 1; i <= 1000; i++)
            {
                result = dice.Next(6);
                num[result]++;

                Console.Write($"{i}. {result + 1}\n");
            }

            Console.Write($"\nYkkönen heitettiin {num[0]} kertaa.\nKakkonen heitettiin {num[1]} kertaa.\nKolmonen heitettiin {num[2]} kertaa.\nNelonen heitettiin {num[3]} kertaa.\nViitonen heitettiin {num[4]} kertaa.\nKuutonen heitettiin {num[5]} kertaa.\n");
        }
    }
}
