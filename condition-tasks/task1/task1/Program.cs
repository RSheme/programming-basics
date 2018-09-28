using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string pos = "";
            int num = 0;
            bool inputcheck = true;
            string input;

            while (true)
            {
                Console.Clear();
                Console.Write($"Ohjelma selvittää onko annettu luku positiivinen, negatiivinen tai nolla.\n");

                if (!inputcheck)
                    Console.Write("\nSyöte ei ole numero.");

                if (pos != "" && inputcheck)
                    Console.Write($"\nNumero {num} on {pos}.");

                Console.Write("\nSyötä numero: ");
                inputcheck = true;
                input = Console.ReadLine();

                if (!Int32.TryParse(input, out num))
                    inputcheck = false;

                if (inputcheck)
                {
                    if (num == 0)
                        pos = "nolla";
                    else if (num > 0)
                        pos = "positiivinen";
                    else
                        pos = "negatiivinen";
                }
            }
        }
    }
}