using System;
using System.Collections.Generic;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int count;
            int swi;
            bool inputcheck = true;
            List<int> num = new List<int>();
            string input = "";

            while (true)
            {
                Console.Clear();
                Console.Write("Ohjelma kysyy numeroita, ja laittaa ne suuruusjärjestykseen.\n");

                if (input.ToLower().Contains("clear"))
                {
                    num.Clear();
                    Console.Write("\nNumerot poistettu.");
                }
                else if (!inputcheck)
                    Console.Write("\nVirheellinen syöte.");

                if (num.Count > 0 && inputcheck)
                {
                    Console.Write("\nNumerot suuruusjärjestyksessä: ");
                    for (int x = 0; x < num.Count; x++)
                        Console.Write($"{num[x]} ");
                }

                Console.Write($"\nSyötä numero {num.Count + 1}: ");
                inputcheck = true;
                input = Console.ReadLine();

                if (!Int32.TryParse(input, out count))
                    inputcheck = false;

                if (inputcheck)
                {
                    num.Add(count);
                    //num.Sort(); ¯\_(ツ)_/¯

                    for (int i = num.Count - 1; i > 0 && num[i] < num[i - 1]; i--)
                    {
                        swi = num[i - 1];
                        num[i - 1] = num[i];
                        num[i] = swi;
                    }
                }
            }
        }
    }
}