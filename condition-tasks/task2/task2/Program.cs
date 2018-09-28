using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {

            string par = "";
            int num = 0;
            bool inputcheck = true;
            string input;

            while (true)
            {
                Console.Clear();
                Console.Write("Ohjelma selvittää onko annettu luku parillinen vai pariton.\n");

                if (!inputcheck)
                    Console.Write("\nSyöte ei ole numero.");

                if (par != "" && inputcheck)
                    Console.Write($"\nNumero {num} on {par}.");

                Console.Write("\nSyötä numero: ");
                inputcheck = true;
                input = Console.ReadLine();

                if (!Int32.TryParse(input, out num))
                    inputcheck = false;

                if (inputcheck)
                {
                    if (num == 0)
                        par = "nolla";
                    else if (num % 2 == 0)
                        par = "parillinen";
                    else
                        par = "pariton";
                }
            }
        }
    }
}
