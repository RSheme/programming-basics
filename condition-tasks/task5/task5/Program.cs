using System;

namespace task5
{
    class Program
    {
        static void Main(string[] args)
        {
            int discount = 0;
            int age = 0;
            int inputcheck = 0;
            int question = 1;
            decimal price = 16;
            string input;

            while (true)
            {
                Console.Clear();
                Console.Write("Ohjelma laskee maatalousnäyttelyn lipun hinnan.\n");

                if (inputcheck == 1)
                    Console.Write("\nVirheellinen syöte.");

                switch (question)
                {
                    case 1:
                        Console.Write("\nOletko MTK:n jäsen?: ");
                        break;
                    case 2:
                        Console.Write("\nOletko opiskelija?: ");
                        break;
                    case 3:
                        Console.Write("\nOletko varusmies?: ");
                        break;
                    case 4:
                        Console.Write("\nSyötä ikäsi: ");
                        break;
                    case 5:
                        Console.Write($"\nLipun hinta on {(100 - discount) * price / 100} euroa.\n\nAloita alusta painamalla ENTER.\n");
                        break;
                }

                inputcheck = 0;
                input = Console.ReadLine();

                if (question < 4)
                {
                    if (!input.ToLower().Contains("yes") && !input.ToLower().Contains("no") && !input.ToLower().Contains("kyllä") && !input.ToLower().Contains("ei"))
                        inputcheck = 1;
                }
                else if (question == 5)
                {
                    question = 1;
                    inputcheck = 2;
                    discount = 0;
                }
                else
                    if (!Int32.TryParse(input, out age) || age < 0 || age > 125)
                        inputcheck = 1;

                if (inputcheck == 0)
                {
                    if (input.ToLower().Contains("yes") || input.ToLower().Contains("kyllä") && question < 4)
                    {
                        switch (question)
                        {
                            case 1:
                                discount = 15;
                                question++;
                                break;
                            case 2:
                                discount = discount + 45;
                                question = 5;
                                break;
                            case 3:
                                discount = 50;
                                question = 5;
                                break;
                        }
                    }
                    else if (question == 4)
                    {
                        if (age < 7)
                            discount = 100;
                        else if (age >= 7 && age <= 15 || age >= 65)
                            discount = 50;
                        question++;
                    }
                    else
                        question++;
                }
            }
        }
    }
}
