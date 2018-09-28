using System;

namespace task5
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int evensum = 0;
            int oddsum = 0;
            bool inputcheck = true;
            string input = "";

            while (true)
            {
                Console.Clear();
                Console.Write("Ohjelma kysyy numeroa, ja laskee numeron N! parittomien ja parillisten numeroiden yhteenlasketun arvon.\n");

                if (!inputcheck)
                    Console.Write("\nVirheellinen syöte.");

                if (input != "" && inputcheck)
                    Console.Write($"\nLuvun {count} N! parillisten summa on {evensum} ja parittomien summa on {oddsum}.");

                Console.Write("\nSyötä numero: ");
                inputcheck = true;
                input = Console.ReadLine();

                if (!Int32.TryParse(input, out count))
                    inputcheck = false;

                if (inputcheck)
                {
                    evensum = 0;
                    oddsum = 0;

                    for (int i = 0; i != count;)
                    {
                        if (count < 0)
                            i--;
                        else
                            i++;

                        if (i % 2 == 0)
                            evensum = evensum + i;
                        else
                            oddsum = oddsum + i;
                    }
                }
            }
        }
    }
}