using System;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int siffra = 0;
            int countTo = 100;

            while (true)
            {
                Console.WriteLine("Ange en siffra: ");
                siffra = Convert.ToInt32(Console.ReadLine());

                if (siffra < 200 && siffra > -200)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Siffra för stor / Liten. Prova igen.");
                }
            }
            if (siffra < 100)
            {
                for (int i = siffra; i <= countTo; i++)
                {
                    Console.WriteLine($"{i}");
                }
            }
            else if (siffra > 100)
            {
                for (int i = siffra; i >= countTo; i--)
                {
                    Console.WriteLine($"{i}");
                }
            }
        }
    }
}
