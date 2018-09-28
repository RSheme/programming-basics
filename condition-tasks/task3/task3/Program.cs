using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string pos = "";
            string par = "";
            int num = 0;
            bool inputcheck = true;
            string input;

            while (true)
            {
                Console.Clear();
                Console.Write("Ohjelma selvittää onko annettu luku positiivinen tai negatiivinen sekä onko se parillinen tai pariton.\n");

                if (!inputcheck)
                    Console.Write("\nSyöte ei ole numero.");

                if (pos != "" && inputcheck)
                    Console.Write($"\nNumero {num} on {pos}{par}");

                Console.Write("\nSyötä numero: ");
                inputcheck = true;
                input = Console.ReadLine();

                if (!Int32.TryParse(input, out num))
                    inputcheck = false;

                if (inputcheck)
                {
                    if (num % 2 == 0)
                        par = " ja parillinen.";
                    else
                        par = " ja pariton.";

                    if (num == 0)
                    {
                        pos = "nolla";
                        par = ".";
                    }
                    else if (num > 0)
                        pos = "positiivinen";
                    else
                        pos = "negatiivinen";
                }
            }
        }
    }
}
