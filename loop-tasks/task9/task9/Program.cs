using System;

namespace task9
{
    class Program
    {
        static void Main(string[] args)
        {
            Random coin = new Random();
            int kruuna = 0;
            int count = 1;
            string input;
            bool inputcheck = true;

            do
            {
                Console.Clear();
                Console.Write("Ohjelma heittää kolikkoa käyttäjän antaman määrän ja kertoo montako kertaa tuli kruuna tai klaava.\n\n");

                if (count != 1)
                    Console.Write("Virheellinen syöte.\n");

                Console.Write("Syötä numero: ");

                input = Console.ReadLine();
                inputcheck = Int32.TryParse(input, out count);

            } while (!inputcheck || count < 1);

            for (int i = 1; i <= count; i++)
            {
                if (coin.Next(2) == 0)
                    kruuna++;
            }

            Console.Clear();
            Console.Write($"Ohjelma heittää kolikkoa käyttäjän antaman määrän ja kertoo montako kertaa tuli kruuna tai klaava.\n\nKruuna heitettiin {kruuna} kertaa ja klaava {count - kruuna} kertaa.\n");
        }
    }
}
