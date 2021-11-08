using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions1
{
    class Calculator
    {
        public void ComputeAverage()
        {
            List<int> numbers = new List<int>();
            while (true)
            {
                Console.WriteLine("Enter a number or press enter to compute the average.");
                string input = Console.ReadLine();
                if (input == "")
                {
                    break;
                }
                bool success = int.TryParse(input, out int result);
                if (success)
                {
                    numbers.Add(result);
                    Console.WriteLine("Number Added Successfully...");
                }
                else
                {
                    Console.WriteLine("Du har angivit ett ogiltigt värde. Försök igen.");
                    continue;
                }
            }

            // Input done, now compute average
            if (numbers.Count == 0)
            {
                Console.WriteLine($"The average is: 0");
                return;
            }

            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            double average = sum / numbers.Count;
            Console.WriteLine($"The average is: {average}");
        }
    }
}
