using System;
using System.Collections.Generic;

namespace extra1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int count;
            int swi;
            bool inputcheck = true;
            Random rnd = new Random();
            List<int> num = new List<int>();

            while (true)
            {
                Console.Clear();
                Console.Write("Ohjelma kysyy montako numeroa se arpoo satunnaisesti, ja laittaa ne suuruusjärjestykseen.\n");

                if (!inputcheck)
                    Console.Write("\nVirheellinen syöte.");

                if (num.Count > 0 && inputcheck)
                {
                    Console.Write("\nNumerot suuruusjärjestyksessä: ");
                    for (int x = 0; x < num.Count; x++)
                        Console.Write(num[x] + " ");
                }

                num.Clear();
                Console.Write("\nSyötä arvottavien numeroiden lukumäärä: ");
                inputcheck = true;
                input = Console.ReadLine();

                if (!Int32.TryParse(input, out count) || count <= 0)
                    inputcheck = false;

                if (inputcheck)
                {
                    for (int i = 0; i < count; i++)
                    {
                        num.Add(rnd.Next(-100, 100));

                        for (int x = num.Count - 1; x > 0 && num[x] < num[x - 1]; x--)
                        {
                            swi = num[x - 1];
                            num[x - 1] = num[x];
                            num[x] = swi;
                        }
                    }
                }
            }
        }
    }
}