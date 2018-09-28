using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = -1;
            int oddsum = 0;
            int evensum = 0;
            bool inputcheck = true;
            string input;

            while (true)
            {
                Console.Clear();
                Console.Write("Ohjelma kysyy numeroa, ja laskee numeron N! parittomien ja parillisten numeroiden yhteenlasketun arvon.\n");

                if (!inputcheck)
                    Console.Write("\nVirheellinen syöte.");

                if (count >= 0 && inputcheck)
                    Console.Write($"\nLuvun {count} N! parillisten summa on {evensum} ja parittomien summa on {oddsum}.");

                Console.Write("\nSyötä numero: ");
                inputcheck = true;
                input = Console.ReadLine();

                if (!Int32.TryParse(input, out count) || count < 0)
                    inputcheck = false;

                if (inputcheck)
                {
                    oddsum = 0;
                    evensum = 0;

                    for (int i = 1; i <= count; i++)
                    {
                        if (i % 2 == 0)
                            oddsum = oddsum + i;
                        else
                            evensum = evensum + i;
                    }
                }
            }
        }
    }
}