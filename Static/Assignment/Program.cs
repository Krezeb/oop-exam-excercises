using System;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                IntCollection intCollection = new IntCollection();
                int value = 0;
                string input = Console.ReadLine();
                if (input == "") 
                { 
                    intCollection.ResetList();
                }
                else
                {
                    value = Convert.ToInt32(input);
                    intCollection.AddInt(value);
                    Console.WriteLine($"Current collection is {intCollection.GetListOfInts()}");
                }
            }
        }
    }
}
