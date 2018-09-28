using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            double sum = 1;
            bool inputcheck = true;
            string input;

            while (true)
            {
                Console.Clear();
                Console.Write("Ohjelma kysyy numeroa, ja laskee numeron N! kertoman arvon.\n");

                if (!inputcheck)
                    Console.Write("\nVirheellinen syöte.");

                if (count > 0 && inputcheck)
                    Console.Write($"\nLuvun {count} N! kertoman arvo on {sum}.");

                Console.Write("\nSyötä numero: ");
                inputcheck = true;
                input = Console.ReadLine();

                if (!Int32.TryParse(input, out count) || count < 1)
                    inputcheck = false;

                if (inputcheck)
                {
                    sum = 1;
                    for (int i = 1; i <= count; i++)
                    {
                        sum = sum * i;
                    }
                }
            }
        }
    }
}
