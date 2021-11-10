using System;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int siffra = 0;
            while (true)
            {
                Console.WriteLine(("Mata in ett siffra:"));
                string input = Console.ReadLine();
                try
                {
                    siffra = Convert.ToInt32(input);
                    if (siffra < -200 || siffra > 200)
                    {
                        Console.WriteLine("Skriva ett nytt tal...");
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
                catch
                {
                    Console.WriteLine("Ogiltig inmatning...");
                    continue;
                }
            }

            if (siffra > 100)
            {
                for (int i = siffra; i < 100; i--)
                {
                    Console.WriteLine($"Siffra: {i}");
                }
            }
            else if (siffra < 100)
            {
                for (int i = 100; i < siffra; i++)
                {
                    Console.WriteLine($"Siffra: {i}");
                }
            }
           
        }
    }
}
